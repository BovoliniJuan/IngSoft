using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string contrasenia;
        private string email;
        private Grupo grupo;

        [Key]
        public int IdUsuario { get { return idUsuario; } set { idUsuario = value; } }
        public string NombreUsuario { get { return nombreUsuario; } set { nombreUsuario = value; } }
        public string Contrasenia { get { return contrasenia; } set { contrasenia = value; } }
        public string Email { get { return email; } set { email = value; } }
        public Grupo Grupo { get { return grupo; } set { grupo = value; } }

        public Usuario() { }
        public void IniciarSesion()
        {

        }
        public void Registrar()
        {

        }
    }
}
