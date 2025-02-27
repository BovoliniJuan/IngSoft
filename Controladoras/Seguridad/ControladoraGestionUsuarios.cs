using Entidades.Seguridad;
using Entidades.Seguridad2;
using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entidades.EntidadesVendedores;

namespace Controladoras.Seguridad
{
    public class ControladoraGestionUsuarios
    {

        private static ControladoraGestionUsuarios instancia;


        public static ControladoraGestionUsuarios Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraGestionUsuarios();
                }
                return instancia;
            }
        }

        public ReadOnlyCollection<Usuario> RecuperarUsuariosSesion(Sesion sesion)
        {
            try
            {
              var usuariosSesiion = Context.Instancia.Usuarios
                        .Where(u => u.IdUsuario != null && u.IdUsuario == sesion.UsuarioSesion.IdUsuario)
                        .ToList();
                    return new ReadOnlyCollection<Usuario>(usuariosSesiion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar Usuarios: " + ex.Message);
            }
        }

        public ControladoraGestionUsuarios()
        {
        }



        public ReadOnlyCollection<Usuario> RecuperarUsuarios()
        {
            try
            {
                // Incluimos el Estado si es una entidad relacionada.
                return Context.Instancia.Usuarios
                              .Include(u => u.Componentes) // Aseguramos que los componentes se carguen
                              .Include(u => u.EstadoUsuario) // Incluimos la relación con Estado
                              .ToList()
                              .AsReadOnly();
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        public Usuario Buscar(string nombreUsuario)
        {
            var usuario = Context.Instancia.Usuarios.FirstOrDefault(u => u.NombreUsuario.ToLower() == nombreUsuario.ToLower());
            return usuario;
        }



        public string AgregarUsuario(Usuario usuario)
        {
            try
            {
                var usuarioExistente = Buscar(usuario.NombreUsuario);

                if (usuarioExistente == null)
                {
                    var estadoUsuario = Context.Instancia.EstadosUsuario.FirstOrDefault(e => e.EstadoUsuarioId == usuario.EstadoUsuario.EstadoUsuarioId);

                    usuario.EstadoUsuario = estadoUsuario;

                    var componentesIds = usuario.Componentes.Select(c => c.Id).ToList();

                    var acciones = Context.Instancia.Acciones.Where(a => componentesIds.Contains(a.Id)).ToList();
                    var grupos = Context.Instancia.Grupos.Where(g => componentesIds.Contains(g.Id)).ToList();

                    var componentes = acciones.Cast<Componente>().Concat(grupos.Cast<Componente>()).ToList();

                    usuario.Componentes = componentes;

                    Context.Instancia.Usuarios.Add(usuario);
                    Context.Instancia.SaveChanges();

                    return "Usuario agregado correctamente y se envió la contraseña por correo";
                }
                else
                {
                    return "Ya existe un usuario con ese nombre de usuario";
                }
            }
            catch (Exception ex)
            {
                // Para mayor detalle, puedes registrar el mensaje de la excepción en un log o devolverlo para depuración.
                return "Error desconocido: " + ex.InnerException.Message;
            }
        }



        public string EliminarUsuario(Usuario usuario)
        {
            try
            {
                var usuarioExistente = Buscar(usuario.NombreUsuario);

                if (usuarioExistente != null)
                {
                    Context.Instancia.Usuarios.Remove(usuario);
                    Context.Instancia.SaveChanges();

                    return "Usuario eliminado correctamente";
                }
                else
                {
                    return "El usuario no existe";
                }
            }
            catch (Exception ex)
            {
                return "Error desconocido";
            }
        }



        public string ModificarUsuario(Usuario usuario)
        {
            try
            {
                // Buscar el usuario existente junto con sus componentes
                var usuarioExistente = ObtenerUsuarioExistente(usuario.IdUsuario);

                if (usuarioExistente == null)
                {
                    return "El usuario no existe";
                }

                // Actualizar los datos básicos del usuario
                ActualizarInformacionBasicaUsuario(usuarioExistente, usuario);

                // Obtener los componentes actualizados para el usuario
                var nuevosComponentes = ObtenerComponentesActualizados(usuario);

                // Asignar los nuevos componentes al usuario
                usuarioExistente.Componentes = nuevosComponentes;

                // Guardar los cambios en la base de datos
                Context.Instancia.Usuarios.Update(usuarioExistente);
                Context.Instancia.SaveChanges();
                return "Usuario modificado correctamente";
            }
            catch (Exception ex)
            {
                // Manejo de errores
                return $"Error al guardar los cambios: {ex.Message}";
            }
        }



        public string ActualizarClaveUsuario(Usuario usuario)
        {
            // Buscar el usuario existente junto con sus componentes
            var usuarioExistente = ObtenerUsuarioExistente(usuario.IdUsuario);

            if (usuarioExistente == null)
            {
                return "El usuario no existe";
            }

            usuarioExistente.Contrasenia = usuario.Contrasenia;

            Context.Instancia.Update(usuarioExistente);
            Context.Instancia.SaveChanges();
            return "Usuario modificado correctamente";
        }



        private Usuario ObtenerUsuarioExistente(int usuarioId)
        {
            return Context.Instancia.Usuarios
                .Include(u => u.Componentes)
                .FirstOrDefault(u => u.IdUsuario == usuarioId);
        }



        private void ActualizarInformacionBasicaUsuario(Usuario usuarioExistente, Usuario usuario)
        {
            usuarioExistente.NombreUsuario = usuario.NombreUsuario;
            usuarioExistente.Email = usuario.Email;
            usuarioExistente.EstadoUsuario = Context.Instancia.EstadosUsuario
                .FirstOrDefault(e => e.EstadoUsuarioId == usuario.EstadoUsuario.EstadoUsuarioId);
        }



        private List<Componente> ObtenerComponentesActualizados(Usuario usuario)
        {
            var accionesIds = usuario.Componentes.OfType<Accion>().Select(a => a.Id).ToList();
            var gruposIds = usuario.Componentes.OfType<Grupo>().Select(g => g.Id).ToList();

            var nuevasAcciones = Context.Instancia.Acciones.Where(a => accionesIds.Contains(a.Id)).ToList();
            var nuevosGrupos = Context.Instancia.Grupos.Include(g => g.Componentes).Where(g => gruposIds.Contains(g.Id)).ToList();

            var nuevosComponentes = nuevasAcciones.Cast<Componente>()
                .Concat(nuevosGrupos.Cast<Componente>())
                .Concat(nuevosGrupos.SelectMany(g => g.Componentes))
                .Distinct().ToList();

            return nuevosComponentes;
        }




        public ReadOnlyCollection<EstadoUsuario> ObtenerEstadosUsuarios()
        {
            try
            {
                // Obtener todos los estados desde la base de datos
                return Context.Instancia.EstadosUsuario.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                // Manejar la excepción según sea necesario
                throw new Exception("Error al obtener los estados de usuario", ex);
            }
        }
    }
}
