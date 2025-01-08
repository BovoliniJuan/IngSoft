﻿using Entidades.Seguridad;
using Entidades;
using Microsoft.AspNetCore.Identity;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controladoras.Mensajeria;
using Entidades.EntidadesClientes;
using Entidades.EntidadesVendedores;

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

        public string RegistrarUsuario(
        string nombreUsuario, string email, string contrasenia,
        string nombreCompleto, string direccion, int dni,
        long telefonoP, string nombreEmpresa = null, long telefonoE = 0, bool esVendedor = false)
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

                // Crear el usuario
                var nuevoUsuario = new Usuario
                {
                    NombreUsuario = nombreUsuario,
                    Email = email,
                    EstadoUsuario = new EstadoUsuario { EstadoUsuarioNombre = "Pendiente" }
                };

                // Encriptar la contraseña
                nuevoUsuario.Contrasenia = _passwordHasher.HashPassword(nuevoUsuario, contrasenia);

                // Crear Persona (Cliente o Vendedor)
                if (esVendedor)
                {
                    if (string.IsNullOrWhiteSpace(nombreEmpresa))
                        return "El nombre de la empresa no puede estar vacío para un vendedor.";
                    if (telefonoE <= 0)
                        return "El teléfono de la empresa debe ser un número válido.";

                    var vendedor = new Vendedor
                    {
                        NombreCompleto = nombreCompleto,
                        DNI = dni,
                        Direccion = direccion,
                        Usuario = nuevoUsuario,
                        NombreEmpresa = nombreEmpresa,
                        TelefonoEmpresa = telefonoE
                    };

                    Context.Instancia.Vendedores.Add(vendedor);
                }
                else
                {
                    if (telefonoP <= 0)
                        return "El teléfono personal debe ser un número válido.";

                    var cliente = new Cliente
                    {
                        NombreCompleto = nombreCompleto,
                        DNI = dni,
                        Direccion = direccion,
                        Usuario = nuevoUsuario,
                        Telefono = telefonoP
                    };

                    Context.Instancia.Clientes.Add(cliente);
                }

                // Guardar en la base de datos
                Context.Instancia.Usuarios.Add(nuevoUsuario);
                Context.Instancia.SaveChanges();

                // Enviar notificación de registro
                Mensajeria.ControladoraMails.Instancia.NotificarRegistroExitoso(email, nombreUsuario);

                return "Usuario registrado exitosamente. Pendiente de aprobación del administrador.";
            }
            catch (Exception ex)
            {
                return $"Error al registrar el usuario: {ex.Message}";
            }
        }


        /*public string RegistrarUsuario(string nombreUsuario, string email, string contrasenia)
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
                    EstadoUsuario = new EstadoUsuario { EstadoUsuarioNombre = "Pendiente" }
                };

                // Encriptar la contraseña
                nuevoUsuario.Contrasenia = _passwordHasher.HashPassword(nuevoUsuario, contrasenia);

                // Guardar en la base de datos
                Context.Instancia.Usuarios.Add(nuevoUsuario);
                Context.Instancia.SaveChanges();

                // Enviar notificación de registro
                Mensajeria.ControladoraMails.Instancia.NotificarRegistroExitoso(email, nombreUsuario);

                return "Usuario registrado exitosamente. Pendiente de aprobación del administrador.";
            }
            catch (Exception ex)
            {
                return $"Error al registrar el usuario: {ex.Message}";
            }
        }*/


    }
}
