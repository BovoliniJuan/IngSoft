using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;
using Entidades.Seguridad2;

namespace Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string contrasenia;
        private string email;
        private EstadoUsuario estadoUsuario;
        private List<Componente> componentes;

        [Key]
        public int IdUsuario { get { return idUsuario; } set { idUsuario = value; } }
        public string NombreUsuario { get { return nombreUsuario; } set { nombreUsuario = value; } }
        public string Contrasenia { get { return contrasenia; } set { contrasenia = value; } }
        public string Email { get { return email; } set { email = value; } }
        public EstadoUsuario EstadoUsuario { get { return estadoUsuario; } set { estadoUsuario = value; }}

        public List<Componente> Componentes{get { return componentes; }set { componentes = value; }}
        public Usuario() 
        {
            componentes = new List<Componente>();
        }
        public List<Accion> ObtenerAcciones()
        {
            var acciones = new List<Accion>();

            // Acciones personalizadas
            acciones.AddRange(Componentes.OfType<Accion>());

            // Acciones de los grupos
            var grupos = Componentes.OfType<Grupo>();
            foreach (var grupo in grupos)
            {
                var accionesDelGrupo = grupo.Componentes.OfType<Accion>();
                acciones.AddRange(accionesDelGrupo);
            }

            return acciones.Distinct().ToList(); // Elimina duplicados si una acción está en varios grupos
        }

        private void RecogerAcciones(Componente componente, List<Accion> acciones)
        {
            if (componente is Accion accion)
            {
                acciones.Add(accion);
            }
            else if (componente is Grupo grupo)
            {
                foreach (var hijo in grupo.RecuperarHijos())
                {
                    RecogerAcciones(hijo, acciones);
                }
            }
        }
    }
}
