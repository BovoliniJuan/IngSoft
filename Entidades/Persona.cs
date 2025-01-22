using System.ComponentModel.DataAnnotations;
using Entidades.Seguridad;

namespace Entidades
{
    public class Persona
    {
        //private int idPersona;
        private string nombreCompleto;
        private int dni;
        private string direccion;
        private Usuario usuario;

       // [Key]
        //public int IdPersona { get { return idPersona; } set { value = idPersona; } }
        public string? NombreCompleto{ get { return nombreCompleto; }set { nombreCompleto = value; } }
        public int DNI { get { return dni; }set { dni = value; } }
        public string Direccion { get {  return direccion; } set {  direccion = value; } } 
        public Usuario Usuario { get { return usuario; } set { usuario = value; } }

        public Persona() { }

       
    }
}
