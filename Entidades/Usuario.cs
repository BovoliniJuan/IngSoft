namespace Entidades
{
    public class Usuario
    {
        private string nombreUsuario;
        private string contrasenia;
        private string email;
        private string direccion;
        
        public string NombreUsuario {  get { return nombreUsuario; } set {  nombreUsuario = value; } }
        public string Contrasenia { get {  return contrasenia; } set {  contrasenia = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Direccion { get {  return direccion; } set {  direccion = value; } } 
        
        public Usuario() { }

        public void IniciarSesion() 
        {

        }
        public void Registrar() 
        {

        }
    }
}
