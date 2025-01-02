using Controladoras;
using Controladoras.Seguridad;
using Entidades.Seguridad2;
using Vista.ModuloInicio;

namespace Vista
{
    public partial class FormInicioSesion : Form
    {
        private readonly ControladoraInicioSesion _controladoraInicioSesion;

        public FormInicioSesion()
        {
            InitializeComponent();
            _controladoraInicioSesion = ControladoraInicioSesion.Instancia;
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

                var acciones = usuario.ObtenerAcciones();

                if (acciones.Count == 0)
                {
                    MessageBox.Show("El usuario no tiene acciones asignadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AbrirFormulariosSegunAcciones(acciones);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirFormulariosSegunAcciones(List<Accion> acciones)
        {
            var formulariosDisponibles = new Dictionary<string, Func<Form>>
            {
            { "FormularioVendedores", () => new FormVendedores() },
            { "FormularioClientes", () => new FormClientes() }
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
