using Controladoras;
using Controladoras.Seguridad;
using Entidades;
using Entidades.Seguridad2;
using Vista.ModuloInicio;
using Vista.ModuloSeguridad;

namespace Vista
{
    public partial class FormInicioSesion : Form
    {
        private readonly ControladoraInicioSesion _controladoraInicioSesion;

        public FormInicioSesion()
        {
            InitializeComponent();
            _controladoraInicioSesion = ControladoraInicioSesion.Instancia;
            txtboxContra.PasswordChar = '*';
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtboxUsuario.Text.Trim();
            string contrasenia = txtboxContra.Text.Trim();

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var usuario = _controladoraInicioSesion.VerificarCredenciales(nombreUsuario, contrasenia);

                if (usuario == null)
                {
                    MessageBox.Show("Credenciales incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Sesion sesion = CrearSesion(usuario);

                var usuarioCompleto = ControladoraInicioSesion.Instancia.Buscar(nombreUsuario);
                var acciones = usuarioCompleto.ObtenerAcciones();


                if (acciones.Count == 0)
                {
                    MessageBox.Show("El usuario no tiene acciones asignadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                RegistrarAuditoriaSesion(usuario.IdUsuario, "Login");

                AbrirFormulariosSegunAcciones(acciones, sesion);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Sesion CrearSesion(Usuario usuario)
        {
            return new Sesion
            {
                UsuarioSesion = usuario,
                SesionPerfil = usuario.Componentes.OfType<Accion>().ToList()
            };
        }

        private void RegistrarAuditoriaSesion(int usuarioId, string tipoMovimiento)
        {
            AuditoriaSesion auditoria = new AuditoriaSesion
            {
                UsuarioId = usuarioId,
                FechaMovimiento = DateTime.Now,
                TipoMovimiento = tipoMovimiento
            };

            ControladoraInicioSesion.Instancia.Registrar(auditoria);
        }

        private void AbrirFormulariosSegunAcciones(List<Accion> acciones, Sesion sesion)
        {
            var formulariosDisponibles = new Dictionary<string, Func<Form>>
            {
            { "FormularioVendedor", () => new FormVendedores(sesion) },
            { "FormularioCliente", () => new FormClientes(sesion) },
            { "FormularioAdministrador",() => new FormAdministrador(sesion) },
            };

            foreach (var accion in acciones)
            {
                if (accion.Formulario != null && formulariosDisponibles.TryGetValue(accion.Formulario.NombreFormulario, out var crearFormulario))
                {
                    var formulario = crearFormulario();
                    formulario.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Formulario no reconocido: {accion.Formulario?.NombreFormulario}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
            
        


        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro(this);
            formRegistro.Show();
        }

        private void linkOlvidarContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecuperarClave formRecuperarClave = new FormRecuperarClave(this);
            formRecuperarClave.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
