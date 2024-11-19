using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Persona
    {
        private int idPersona;
        private string nombreCompleto;
        private int dni;
        private string direccion;

        [Key]
        public int IdPersona { get { return idPersona; } set { value = idPersona; } }
        public string NombreCompleto { get { return nombreCompleto; }set { value = nombreCompleto; } }
        public int DNI { get { return dni; }set { value = dni; } }
        public string Direccion { get {  return direccion; } set {  direccion = value; } } 
        
        public Persona() { }

       
    }
}
