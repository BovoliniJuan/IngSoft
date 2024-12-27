using Entidades.Seguridad;
using Entidades;
using Microsoft.AspNetCore.Identity;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladoras.Seguridad
{
    public class ControladoraRegistro
        {
            private static ControladoraRegistro instancia;
            private readonly PasswordHasher<Usuario> _passwordHasher;

            public static ControladoraRegistro Instancia
            {
                get
                {
                    if (instancia == null)
                    {
                        instancia = new ControladoraRegistro();
                    }
                    return instancia;
                }
            }

            private ControladoraRegistro()
            {
                _passwordHasher = new PasswordHasher<Usuario>();
            }

            public string RegistrarUsuario(string nombreUsuario, string email, string contrasenia)
            {
                try
                {
                    // Validaciones básicas
                    if (string.IsNullOrWhiteSpace(nombreUsuario))
                        return "El nombre de usuario no puede estar vacío.";

                    if (string.IsNullOrWhiteSpace(email))
                        return "El email no puede estar vacío.";

                    if (string.IsNullOrWhiteSpace(contrasenia))
                        return "La contraseña no puede estar vacía.";

                    if (Context.Instancia.Usuarios.Any(u => u.NombreUsuario == nombreUsuario))
                        return "El nombre de usuario ya está en uso.";

                    if (Context.Instancia.Usuarios.Any(u => u.Email == email))
                        return "El email ya está registrado.";

                    // Crear el nuevo usuario
                    var nuevoUsuario = new Usuario
                    {
                        NombreUsuario = nombreUsuario,
                        Email = email,
                        EstadoUsuario = new EstadoUsuario { EstadoUsuarioNombre = "Activo" } // Estado inicial
                    };

                    // Encriptar la contraseña
                    nuevoUsuario.Contrasenia = _passwordHasher.HashPassword(nuevoUsuario, contrasenia);

                    // Guardar en la base de datos
                    Context.Instancia.Usuarios.Add(nuevoUsuario);
                    Context.Instancia.SaveChanges();

                    return "Usuario registrado exitosamente.";
                }
                catch (Exception ex)
                {
                    return $"Error al registrar el usuario: {ex.Message}";
                }
            }
        }
}
