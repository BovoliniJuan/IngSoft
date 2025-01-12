using Entidades.Seguridad;
using Entidades.Seguridad2;
using Entidades;
using Modelo;
using Controladoras.Seguridad;

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
            //InicializarDatosBase();
            Application.Run(new FormInicioSesion());
        }
        private static void InicializarDatosBase()
        {
            using (var context = Context.Instancia)
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
                var moduloExistente = context.Modulos.FirstOrDefault(m => m.NombreModulo == moduloAdministrador.NombreModulo);
                if (moduloExistente != null)
                {
                    moduloAdministrador = moduloExistente;
                }
                else
                {
                    context.Modulos.Add(moduloAdministrador);
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
                if (!context.EstadosGrupo.Any(e => e.EstadoGrupoNombre == estadoGrupoActivo.EstadoGrupoNombre))
                    context.EstadosGrupo.Add(estadoGrupoActivo);

                if (!context.EstadosUsuario.Any(e => e.EstadoUsuarioNombre == estadoUsuarioActivo.EstadoUsuarioNombre))
                    context.EstadosUsuario.Add(estadoUsuarioActivo);

                if (!context.Formularios.Any(f => f.NombreFormulario == formularioAdministrador.NombreFormulario))
                    context.Formularios.Add(formularioAdministrador);

                if (!context.Acciones.Any(a => a.Nombre == accionAdministrador.Nombre))
                    context.Acciones.Add(accionAdministrador);

                if (!context.Grupos.Any(g => g.Nombre == grupoAdministrador.Nombre))
                    context.Grupos.Add(grupoAdministrador);

                if (!context.Usuarios.Any(u => u.NombreUsuario == usuarioAdministrador.NombreUsuario))
                    ControladoraRegistro.Instancia.CrearUsuario(usuarioAdministrador, contrasenia);


                // Guardar cambios
                context.SaveChanges();

                Console.WriteLine("Usuario Administrador creado correctamente con acceso al Formulario Administrador.");
            }
        }
    }
}