using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladoras.Administrador
{

    public class ControladoraAdministrador
    {
        private static ControladoraAdministrador instancia;

        public static ControladoraAdministrador Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraAdministrador();
                }
                return instancia;
            }
        }

        private ControladoraAdministrador() { }


        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            return Context.Instancia.Usuarios.ToList();
        }

        public List<Usuario> FiltrarUsuariosPorGrupo(bool sinGrupo = true)
        {
            return Context.Instancia.Usuarios
                .Where(u => sinGrupo ? !u.Componentes.OfType<Grupo>().Any() : u.Componentes.OfType<Grupo>().Any())
                .ToList();
        }


        public string AsignarGrupoAUsuario(int idUsuario, Grupo grupo)
        {
            try
            {
                var usuario = Context.Instancia.Usuarios.FirstOrDefault(u => u.IdUsuario == idUsuario);

                if (usuario == null)
                    return "Usuario no encontrado.";

                if (grupo == null)
                    return "El grupo no puede ser nulo.";

                if (usuario.Componentes.OfType<Grupo>().Any(g => g.IdGrupo == grupo.IdGrupo))
                    return "El usuario ya pertenece a este grupo.";

                usuario.Componentes.Add(grupo);
                Context.Instancia.SaveChanges();
                Mensajeria.ControladoraMails.Instancia.NotificarAsignacionGrupo(usuario.Email,usuario.NombreUsuario, grupo.NombreGrupo);
                return "Grupo asignado exitosamente.";
            }
            catch (Exception ex)
            {
                return $"Error al asignar el grupo: {ex.Message}";
            }
        }
    }

}
