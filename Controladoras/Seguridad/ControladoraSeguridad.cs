using Entidades;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Controladoras
{
    public class ControladoraSeguridad
    {
        private readonly Context _context;
        private readonly PasswordHasher<Usuario> _passwordHasher;


        public ControladoraSeguridad(Context context)
        {
            _context = context;
            _passwordHasher = new PasswordHasher<Usuario>();

        }

        public string IniciarSesion(string nombreUsuario, string contrasenia)
        {
            // Buscar el usuario por nombre de usuario, incluyendo su grupo y permisos
            var usuario = _context.Usuarios
                                  .Include(u => u.Grupo)
                                  .ThenInclude(g => g.Permisos)
                                  .FirstOrDefault(u => u.NombreUsuario == nombreUsuario);

            if (usuario == null)
            {
                Console.WriteLine("Usuario no encontrado.");
                return null;
            }

            // Validar la contraseña usando PasswordHasher
            var resultado = _passwordHasher.VerifyHashedPassword(usuario, usuario.Contrasenia, contrasenia);

            if (resultado == PasswordVerificationResult.Success)
            {
                Console.WriteLine("Inicio de sesión exitoso.");

                // Verificar permisos y devolver el formulario correspondiente
                return VerificarAcceso(usuario);
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta.");
                return null;
            }
        }

        public void RegistrarUsuario(Usuario usuario)
        {
            if (_context.Usuarios.Any(u => u.NombreUsuario == usuario.NombreUsuario))
            {
                Console.WriteLine("El nombre de usuario ya está registrado.");
                return;
            }

            // Hash de la contraseña
            usuario.Contrasenia = _passwordHasher.HashPassword(usuario, usuario.Contrasenia);

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            Console.WriteLine("Usuario registrado exitosamente.");
        }
        private string VerificarAcceso(Usuario usuario)
        {
            if (usuario.Grupo?.Permisos == null)
            {
                Console.WriteLine("El usuario no tiene permisos asignados.");
                return null;
            }

            // Verificar el permiso de vendedor
            if (usuario.Grupo.Permisos.Obtener(0)?.TieneAcceso() == true)
            {
                Console.WriteLine("Redirigiendo al formulario de vendedores.");
                return "FormularioVendedores";
            }

            // Verificar el permiso de cliente
            if (usuario.Grupo.Permisos.Obtener(1)?.TieneAcceso() == true)
            {
                Console.WriteLine("Redirigiendo al formulario de clientes.");
                return "FormularioClientes";
            }

            Console.WriteLine("El usuario no tiene acceso a ninguna sección específica.");
            return null;
        }
        public List<Usuario> ObtenerUsuariosConGrupoTemporal()
        {
            return _context.Usuarios
                           .Include(u => u.Grupo)
                           .Where(u => u.Grupo != null && u.Grupo.NombreGrupo == "Temporal")
                           .ToList();
        }

        public void AsignarGrupo(Usuario usuario, Grupo nuevoGrupo)
        {
            var usuarioDb = _context.Usuarios
                                    .Include(u => u.Grupo)
                                    .FirstOrDefault(u => u.IdUsuario == usuario.IdUsuario);

            if (usuarioDb != null)
            {
                usuarioDb.Grupo = nuevoGrupo;
                _context.SaveChanges();
                Console.WriteLine($"El grupo '{nuevoGrupo.NombreGrupo}' ha sido asignado al usuario '{usuarioDb.NombreUsuario}'.");
            }
            else
            {
                Console.WriteLine("Usuario no encontrado en la base de datos.");
            }
        }

        public Grupo CrearGrupo(string nombreGrupo, List<PermisoComponent> permisos)
        {
            var grupo = new Grupo
            {
                NombreGrupo = nombreGrupo,
                Permisos = new PermisoGrupo()
            };

            foreach (var permiso in permisos)
            {
                grupo.Permisos.Agregar(permiso);
            }

            _context.Grupos.Add(grupo);
            _context.SaveChanges();
            Console.WriteLine($"Grupo '{nombreGrupo}' creado exitosamente.");
            return grupo;
        }

        public List<Grupo> ObtenerGrupos()
        {
            return _context.Grupos.Include(g => g.Permisos).ToList();
        }

        /*private string VerificarAcceso(Usuario usuario)
        {
            if (usuario.Grupo == null || usuario.Grupo.Permisos == null)
            {
                Console.WriteLine("El usuario no tiene permisos asignados.");
                return null;
            }

            if (usuario.Grupo.Permisos.TienePermiso("Vendedor"))
            {
                Console.WriteLine("Redirigiendo al formulario de vendedores.");
                return "FormularioVendedores"; // Nombre del formulario
            }

            if (usuario.Grupo.Permisos.TienePermiso("Cliente"))
            {
                Console.WriteLine("Redirigiendo al formulario de clientes.");
                return "FormularioClientes"; // Nombre del formulario
            }

            Console.WriteLine("El usuario no tiene acceso a ninguna sección específica.");
            return null;
        }*/
    }
}
