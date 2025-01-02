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
                // Buscar el usuario en la base de datos y cargar sus relaciones
                var usuario = Context.Instancia.Usuarios
                    .Include(u => u.EstadoUsuario) // Estado del usuario
                    .Include(u => u.Componentes)  // Componentes (Acciones y Grupos)
                        .ThenInclude(c => c.Grupos) // Grupos dentro de los componentes
                    .Include(u => u.Componentes)
                        .ThenInclude(c => (c as Accion).Formulario) // Formularios de las acciones
                    .FirstOrDefault(u => u.NombreUsuario == nombreUsuario);

                if (usuario == null)
                {
                    throw new Exception("Usuario no encontrado.");
                }

                // Verificar el estado del usuario
                if (usuario.EstadoUsuario.EstadoUsuarioNombre != "Activo")
                {
                    throw new Exception("El usuario no está activo.");
                }

                // Validar la contraseña
                var resultado = _passwordHasher.VerifyHashedPassword(usuario, usuario.Contrasenia, contrasenia);
                if (resultado == PasswordVerificationResult.Failed)
                {
                    throw new Exception("La contraseña es incorrecta.");
                }

                // Devolver el usuario con sus componentes cargados si las credenciales son válidas
                return usuario;
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



        /* public void Registrar(AuditoriaSesion auditoriaSesion)
         {
             try
             {
                 // Agregar la auditoría de sesión a la base de datos
                 Context.Instancia.AuditoriasSesiones.Add(auditoriaSesion);
                 Context.Instancia.SaveChanges();
             }
             catch (Exception ex)
             {
                 throw; // Manejo de excepciones en caso de algún error
             }
         }*/
    }
}
