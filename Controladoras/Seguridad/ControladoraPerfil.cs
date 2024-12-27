using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladoras.Seguridad
{
    public class ControladoraPerfil
    {
        private static ControladoraPerfil instancia;

        public static ControladoraPerfil Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraPerfil();
                }
                return instancia;
            }
        }


        public ControladoraPerfil()
        {
        }


        public string ObtenerEstadoUsuario(int usuarioId)
        {
            var usuario = Context.Instancia.Usuarios
                         .Include(u => u.EstadoUsuario)
                         .FirstOrDefault(u => u.IdUsuario == usuarioId);

            if (usuario != null && usuario.EstadoUsuario != null)
            {
                return usuario.EstadoUsuario.EstadoUsuarioNombre;
            }

            return "EstadoUsuario inexistente";
        }
    }
}
