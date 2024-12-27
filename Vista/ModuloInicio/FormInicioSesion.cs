using Controladoras;

namespace Vista
{
    public partial class FormInicioSesion : Form
    {
        private readonly ControladoraSeguridad _controladoraSeguridad;

        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtboxUsuario.Text.Trim();
            string contrasenia = txtboxContra.Text.Trim();

            // Validar campos vacíos
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentar iniciar sesión
            string formularioRedirigir = _controladoraSeguridad.IniciarSesion(nombreUsuario, contrasenia);

            if (formularioRedirigir == null)
            {
                // Si no se obtiene un formulario, mostrar mensaje de error
                MessageBox.Show("Credenciales incorrectas o usuario sin permisos asignados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Redirigir al formulario correspondiente
            switch (formularioRedirigir)
            {
                case "FormularioVendedores":
                    FormVendedores formVendedores = new FormVendedores();
                    formVendedores.Show();
                    break;

                case "FormularioClientes":
                    FormClientes formClientes = new FormClientes();
                    formClientes.Show();
                    break;

                default:
                    MessageBox.Show("No se pudo determinar la sección a la que tiene acceso el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            // Cerrar el formulario de inicio de sesión
            this.Close();
        }

        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro(this);
            formRegistro.Show();
        }
    }
}
