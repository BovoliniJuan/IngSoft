using Controladoras;
using Controladoras.Mensajeria;
using Controladoras.Seguridad;
using Entidades;
using Microsoft.AspNetCore.Identity;
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

namespace Vista.ModuloInicio
{
    public partial class FormRecuperarClave : Form
    {
        private readonly ControladoraSeguridad _controladoraSeguridad;
        private string _codigoRecuperacion;

        private FormInicioSesion formInicioSesion;
        public FormRecuperarClave(FormInicioSesion formInicioSesion)
        {
            InitializeComponent();
            this.formInicioSesion = formInicioSesion;
            _controladoraSeguridad = new ControladoraSeguridad(Context.Instancia);
            panel1.Visible = true;  // Mostrar panel de email y código
            panel2.Visible = false; // Ocultar panel de cambio de contraseña
        }
        private void btnEnviarCodigo_Click_1(object sender, EventArgs e)
        {
            string emailUsuario = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(emailUsuario))
            {
                MessageBox.Show("Por favor, ingrese su correo electrónico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el correo pertenece a un usuario
            var usuario = Context.Instancia.Usuarios.FirstOrDefault(u => u.Email == emailUsuario);
            if (usuario == null)
            {
                MessageBox.Show("No existe un usuario registrado con ese correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generar y enviar el código
            _codigoRecuperacion = ControladoraInicioSesion.GenerarCodigo();
            ControladoraMails.Instancia.EnviarCodigoRecuperacion(emailUsuario, _codigoRecuperacion);

            MessageBox.Show("Se ha enviado un código de recuperación a su correo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnValidarCodigo_Click(object sender, EventArgs e)
        {

            string codigoIngresado = txtCodigo.Text.Trim();

            if (codigoIngresado == _codigoRecuperacion)
            {
                MessageBox.Show("Código validado correctamente. Puede cambiar su contraseña.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ocultar el Panel 1 y mostrar el Panel 2
                panel1.Visible = false;
                panel2.Visible = true;
            }
            else
            {
                MessageBox.Show("El código ingresado es incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            string nuevaContrasenia = txtNuevaContrasenia.Text.Trim();
            string confirmarContrasenia = txtConfirmarContrasenia.Text.Trim();

            if (string.IsNullOrEmpty(nuevaContrasenia) || string.IsNullOrEmpty(confirmarContrasenia))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nuevaContrasenia != confirmarContrasenia)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cambiar la contraseña del usuario
            var usuario = Context.Instancia.Usuarios.FirstOrDefault(u => u.Email == txtEmail.Text.Trim());
            if (usuario != null)
            {
                var hashedPassword = new PasswordHasher<Usuario>().HashPassword(usuario, nuevaContrasenia);
                usuario.Contrasenia = hashedPassword;
                Context.Instancia.Usuarios.Update(usuario);
                Context.Instancia.SaveChanges();

                MessageBox.Show("Su contraseña ha sido actualizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cerrar el formulario
            }
            else
            {
                MessageBox.Show("Error al actualizar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
