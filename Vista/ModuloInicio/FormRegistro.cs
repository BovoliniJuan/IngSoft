using Controladoras;
using Controladoras.Seguridad;
using Entidades;
using Entidades.EntidadesClientes;
using Entidades.Seguridad;
using Entidades.Seguridad2;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Vista
{
    public partial class FormRegistro : Form
    {

        private FormInicioSesion formInicioSesion;
        private readonly PasswordHasher<Usuario> _passwordHasher;

        public FormRegistro(FormInicioSesion formInicioSesion)
        {
            InitializeComponent();
            this.formInicioSesion = formInicioSesion;
            pnlClientes.Visible = true;
            pnlVendedores.Visible = false;

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
            string nombreCompleto = txtNombre.Text.Trim();
            var direccion = txtDireccion.Text.Trim();
            //var dni = int.Parse(txtDni.Text.Trim());
            var dni = (int)numDNI.Value;
            var esVendedor = chkVendedor.Checked;
            if (!EsEmailValido(email))
            {
                MessageBox.Show("El formato del email no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(nombreCompleto))
            {
                MessageBox.Show("El nombre completo es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string resultado;

            Usuario usuario = new Usuario();
            usuario.NombreUsuario = nombreUsuario;
            usuario.Contrasenia = contrasenia;
            usuario.Email = email;
            usuario.EstadoUsuario =  new EstadoUsuario { EstadoUsuarioNombre = "Pendiente" };

            ControladoraRegistro.Instancia.CrearUsuario(usuario,contrasenia);

            if (esVendedor)
            {
                var nombreEmpresa = txtNombreEmpresa.Text.Trim();
                var telefonoE = long.Parse(txtTelEmpresa.Text.Trim());
                resultado = ControladoraRegistro.Instancia.RegistrarUsuario(
                    nombreUsuario, email, contrasenia, nombreCompleto, direccion, dni, 0, nombreEmpresa, telefonoE, true);
            }
            else
            {
           
                var telefonoP =(long)numTelefP.Value;
                Cliente cliente = new Cliente();
                cliente.Telefono = telefonoP;
                cliente.NombreCompleto = nombreCompleto;
                cliente.DNI = dni;
                cliente.Direccion = direccion;
                cliente.Usuario = usuario;

                resultado = ControladoraRegistro.Instancia.RegistrarCliente(cliente);
            }

            MessageBox.Show(resultado, "Registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*var nombreUsuario = txtNombreUsuario.Text.Trim();
            var email = txtEmail.Text.Trim();
            var contrasenia = txtContra.Text.Trim();
            var nombreCompleto = txtNombre.Text.Trim();
            var direccion = txtDireccion.Text.Trim();
            var nombreEmpresa = txtNombreEmpresa.Text.Trim();
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
            if (string.IsNullOrWhiteSpace(nombreCompleto))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("La direccion no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtDni.Text, out int dni) || dni <= 0)
            {
                MessageBox.Show("El DNI debe ser un número válido y mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(chkVendedor.Checked)
            {
                if (string.IsNullOrWhiteSpace(nombreEmpresa))
                {
                    MessageBox.Show("El nombre de la empresa no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtTelEmpresa.Text, out int telefonoE) || telefonoE <= 0)
                {
                    MessageBox.Show("El teléfono de la empresa debe ser un número válido y mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (!int.TryParse(txtTelPerso.Text, out int telefonoP) || telefonoP <= 0)
                {
                    MessageBox.Show("El teléfono personal debe ser un número válido y mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
                      
            // Validar formato de email
            if (!EsEmailValido(email))
            {
                MessageBox.Show("El formato del email no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar al método de registro
            
            var resultado = ControladoraRegistro.Instancia.RegistrarUsuario(nombreUsuario, email, contrasenia);

            MessageBox.Show(resultado, "Registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        private void chkVendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVendedor.Checked) 
            {
                pnlClientes.Visible = false;
                pnlVendedores.Visible = true;
            }
            else
            {
                pnlClientes.Visible = true;
                pnlVendedores.Visible = false;
            }
            
        }
    }

}
