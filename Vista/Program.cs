using Entidades.Seguridad;
using Entidades.Seguridad2;
using Entidades;
using Modelo;
using Controladoras.Seguridad;
using Entidades.EntidadesVendedores;
using Microsoft.EntityFrameworkCore;

namespace Vista
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           // InicializarDatosBase();
           
            Application.Run(new FormInicioSesion());
        }
        private static void InicializarDatosBase()
        {
            
            
                // Crear estado para el grupo y usuario
                var estadoGrupoActivo = new EstadoGrupo { EstadoGrupoNombre = "Activo" };
                var estadoUsuarioActivo = new EstadoUsuario { EstadoUsuarioNombre = "Activo" };

                // Crear módulo de administrador
                var moduloAdministrador = new Modulo
                {
                    NombreModulo = "ModuloAdministrador"
                };

                // Verificar si el módulo ya existe
                var moduloExistente = Context.Instancia.Modulos.FirstOrDefault(m => m.NombreModulo == moduloAdministrador.NombreModulo);
                if (moduloExistente != null)
                {
                    moduloAdministrador = moduloExistente;
                }
                else
                {
                    Context.Instancia.Modulos.Add(moduloAdministrador);
                }

                // Crear formulario de administrador y asociarlo al módulo
                var formularioAdministrador = new Formulario
                {
                    NombreFormulario = "FormularioAdministrador",
                    Modulo = moduloAdministrador
                };

                // Crear acción asociada al formulario de administrador
                var accionAdministrador = new Accion
                {
                    Nombre = "Acceso a Administrador",
                    Formulario = formularioAdministrador
                };

                // Crear grupo Administrador
                var grupoAdministrador = new Grupo
                {
                    Nombre = "Administrador",
                    EstadoGrupo = estadoGrupoActivo
                };

                // Agregar acción al grupo
                grupoAdministrador.Agregar(accionAdministrador);

                // Crear usuario Administrador
                var usuarioAdministrador = new Usuario
                {
                    NombreUsuario = "admin",
                    Contrasenia = "admin123", 
                    Email = "admin@admin.com",
                    EstadoUsuario = estadoUsuarioActivo
                };
                var contrasenia = "admin123";


                // Asignar grupo al usuario
                usuarioAdministrador.Componentes.Add(grupoAdministrador);

                // Verificar y agregar datos al contexto si no existen
                if (!Context.Instancia.EstadosGrupo.Any(e => e.EstadoGrupoNombre == estadoGrupoActivo.EstadoGrupoNombre))
                    Context.Instancia.EstadosGrupo.Add(estadoGrupoActivo);

                if (!Context.Instancia.EstadosUsuario.Any(e => e.EstadoUsuarioNombre == estadoUsuarioActivo.EstadoUsuarioNombre))
                    Context.Instancia.EstadosUsuario.Add(estadoUsuarioActivo);

                if (!Context.Instancia.Formularios.Any(f => f.NombreFormulario == formularioAdministrador.NombreFormulario))
                    Context.Instancia.Formularios.Add(formularioAdministrador);

                if (!Context.Instancia.Acciones.Any(a => a.Nombre == accionAdministrador.Nombre))
                    Context.Instancia.Acciones.Add(accionAdministrador);

                if (!Context.Instancia.Grupos.Any(g => g.Nombre == grupoAdministrador.Nombre))
                    Context.Instancia.Grupos.Add(grupoAdministrador);

                if (!Context.Instancia.Usuarios.Any(u => u.NombreUsuario == usuarioAdministrador.NombreUsuario))
                    ControladoraRegistro.Instancia.CrearUsuario(usuarioAdministrador, contrasenia);
            var moduloCliente = new Modulo
            {
                NombreModulo = "ModuloCliente"
            };
            var moduloExistenteC = Context.Instancia.Modulos.FirstOrDefault(m => m.NombreModulo == moduloCliente.NombreModulo);
            if (moduloExistenteC != null)
            {
                moduloCliente = moduloExistente;
            }
            else
            {
                Context.Instancia.Modulos.Add(moduloCliente);
            }

            // Crear formulario de administrador y asociarlo al módulo
            var formularioCliente = new Formulario
            {
                NombreFormulario = "FormularioCliente",
                Modulo = moduloCliente
            };

            // Crear acción asociada al formulario de administrador
            var accionCliente = new Accion
            {
                Nombre = "Acceso a Cliente",
                Formulario = formularioCliente
            };




            // Crear grupo Administrador
            var grupoCliente = new Grupo
            {
                Nombre = "Cliente",
                EstadoGrupo = estadoGrupoActivo
            };

            // Agregar acción al grupo
            grupoCliente.Agregar(accionCliente);


            if (!Context.Instancia.Formularios.Any(f => f.NombreFormulario == formularioCliente.NombreFormulario))
                Context.Instancia.Formularios.Add(formularioCliente);

            if (!Context.Instancia.Acciones.Any(a => a.Nombre == accionCliente.Nombre))
                Context.Instancia.Acciones.Add(accionCliente);

            if (!Context.Instancia.Grupos.Any(g => g.Nombre == grupoCliente.Nombre))
                Context.Instancia.Grupos.Add(grupoCliente);

            var moduloVendedor = new Modulo
            {
                NombreModulo = "ModuloVendedor"
            };
            var moduloExistenteV = Context.Instancia.Modulos.FirstOrDefault(m => m.NombreModulo == moduloVendedor.NombreModulo);
            if (moduloExistenteV != null)
            {
                moduloVendedor = moduloExistente;
            }
            else
            {
                Context.Instancia.Modulos.Add(moduloVendedor);
            }

            // Crear formulario de administrador y asociarlo al módulo
            var formVendedor = new Formulario
            {
                NombreFormulario = "FormularioVendedor",
                Modulo = moduloVendedor
            };

            // Crear acción asociada al formulario de administrador
            var accionVendedor = new Accion
            {
                Nombre = "Acceso a Vendedor",
                Formulario = formVendedor
            };


            // Crear grupo Administrador
            var grupoVendedor = new Grupo
            {
                Nombre = "Vendedor",
                EstadoGrupo = estadoGrupoActivo
            };

            // Agregar acción al grupo
            grupoVendedor.Agregar(accionVendedor);

            if (!Context.Instancia.Formularios.Any(f => f.NombreFormulario == formVendedor.NombreFormulario))
                Context.Instancia.Formularios.Add(formVendedor);

            if (!Context.Instancia.Acciones.Any(a => a.Nombre == accionVendedor.Nombre))
                Context.Instancia.Acciones.Add(accionVendedor);

            if (!Context.Instancia.Grupos.Any(g => g.Nombre == grupoVendedor.Nombre))
                Context.Instancia.Grupos.Add(grupoVendedor);
            // Guardar cambios
            Context.Instancia.SaveChanges();

                Console.WriteLine("Usuario Administrador creado correctamente con acceso al Formulario Administrador.");
            
            
        }
       
        
    }
}