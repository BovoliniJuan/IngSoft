using Entidades.Seguridad2;
using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using iText.Commons.Actions.Contexts;

namespace Controladoras.Seguridad
{
    public class ControladoraInicioSesion
    {
        private static ControladoraInicioSesion instancia;
        private readonly PasswordHasher<Usuario> _passwordHasher;

        public static ControladoraInicioSesion Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraInicioSesion();
                }
                return instancia;
            }
        }

        public ControladoraInicioSesion() 
        {
            _passwordHasher = new PasswordHasher<Usuario>();
        }
        public Usuario Buscar(string nombreUsuario)
        {
            var usuario = Context.Instancia.Usuarios
                .AsNoTracking()
                .Include(u => u.EstadoUsuario)
                .Include(u => u.Componentes)
                    .ThenInclude(c => (c as Grupo).EstadoGrupo)
                .Include(u => u.Componentes)
                    .ThenInclude(c => (c as Grupo).Componentes)
                        .ThenInclude(gc => (gc as Accion).Formulario)
                            .ThenInclude(f => f.Modulo)
                .Include(u => u.Componentes)
                    .ThenInclude(c => (c as Accion).Formulario)
                        .ThenInclude(f => f.Modulo)
                .FirstOrDefault(u => u.NombreUsuario == nombreUsuario);


            if (usuario != null)
            {
                var grupos = usuario.Componentes.OfType<Grupo>().ToList();


                // Para cada grupo, se filtran sus componentes para obtener solo las Acciones asociadas a ese grupo
                foreach (var grupo in grupos)
                {
                    var accionesDelGrupo = grupo.Componentes.OfType<Accion>().ToList();
                }

                //  Filtra los componentes del usuario para obtener todas las Acciones que no están dentro de ningún grupo (acciones personalizadas)
                var accionesPersonalizadas = usuario.Componentes.OfType<Accion>().ToList();

            }

            return usuario;
        }

        public Usuario BuscarUsuario(string nombreUsuario)
        {
            var usuario = Context.Instancia.Usuarios.Include(u => u.EstadoUsuario)
                .Include(u => u.Componentes)
                .ThenInclude(c => (c as Accion).Formulario)
                .ThenInclude(f => f.Modulo).FirstOrDefault(u => u.NombreUsuario == nombreUsuario);

            if (usuario != null)
            {
                var grupos = usuario.Componentes.OfType<Grupo>().ToList();
                foreach (var grupo in grupos)
                {
                    // Cargar el estado del grupo
                    Context.Instancia.Entry(grupo).Reference(g => g.EstadoGrupo).Load();
                }
            }

            return usuario;

        }



        public string CambiarClave(int usuarioId, string nuevaContrasenia)
        {
            try
            {
                var usuario = Context.Instancia.Usuarios.FirstOrDefault(u => u.IdUsuario == usuarioId);
                if (usuario != null)
                {
                    // Hashea la nueva contraseña
                    var hashedPassword = _passwordHasher.HashPassword(usuario, nuevaContrasenia);
                    usuario.Contrasenia = hashedPassword;

                    // Actualiza el usuario en la base de datos
                    Context.Instancia.Usuarios.Update(usuario);
                    Context.Instancia.SaveChanges();

                    return "La clave ha sido cambiada exitosamente.";
                }
                else
                {
                    return "Usuario no encontrado.";
                }
            }
            catch (Exception ex)
            {
                return $"Error al cambiar la clave: {ex.Message}";
            }
        }
        public Usuario VerificarCredenciales(string nombreUsuario, string contrasenia)
        {
            try
            {
                
                var listaUsuarios = Context.Instancia.Usuarios.Include(u => u.EstadoUsuario)
                    .Include(u => u.Componentes).ToList().AsReadOnly();
                
                var usuarioEncontrado = listaUsuarios.FirstOrDefault(x => x.NombreUsuario == nombreUsuario);
                if (usuarioEncontrado == null)
                {
                    throw new Exception("Usuario no encontrado.");
                }

            
                // Validar la contraseña
                var resultado = _passwordHasher.VerifyHashedPassword(usuarioEncontrado, usuarioEncontrado.Contrasenia, contrasenia);
                if (resultado == PasswordVerificationResult.Failed)
                {
                    throw new Exception("La contraseña es incorrecta.");
                }
                // Verificar el estado del usuario
                if (usuarioEncontrado.EstadoUsuario.EstadoUsuarioNombre != "Activo")
                {
                    throw new Exception("El usuario no está activo.");
                }
                // Devolver el usuario con sus componentes cargados si las credenciales son válidas
                return usuarioEncontrado;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new Exception($"Error al verificar las credenciales: {ex.Message}");
            }
        }
       
        public static string GenerarCodigo()
        {
            var caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(caracteres, 6)
                                        .Select(s => s[random.Next(s.Length)]).ToArray());
        }



        public void Registrar(AuditoriaSesion auditoriaSesion)
        {
            try
            {
                Context.Instancia.AuditoriasSesiones.Add(auditoriaSesion);
                Context.Instancia.SaveChanges();
            }
            catch (Exception ex)
            {
                throw; 
            }
        }
    }
}
