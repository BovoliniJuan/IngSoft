using Controladoras;
using Controladoras.Seguridad;
using Entidades;
using Entidades.Seguridad;
using Entidades.Seguridad2;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormRegistro : Form
    {

        private FormInicioSesion formInicioSesion;
        public FormRegistro(FormInicioSesion formInicioSesion)
        {
            InitializeComponent();
            this.formInicioSesion = formInicioSesion;
        }


        // Método auxiliar para validar el formato de email
        private bool EsEmailValido(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var nombreUsuario = txtNombreUsuario.Text.Trim();
            var email = txtEmail.Text.Trim();
            var contrasenia = txtContra.Text.Trim();

            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("El email no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(contrasenia))
            {
                MessageBox.Show("La contraseña no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar formato de email
            if (!EsEmailValido(email))
            {
                MessageBox.Show("El formato del email no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar al método de registro
            var resultado = ControladoraRegistro.Instancia.RegistrarUsuario(nombreUsuario, email, contrasenia);

            MessageBox.Show(resultado, "Registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
