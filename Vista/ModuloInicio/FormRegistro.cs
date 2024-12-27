using Controladoras;
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
        private readonly ControladoraSeguridad _controladoraSeguridad;

        private FormInicioSesion formInicioSesion;
        public FormRegistro(FormInicioSesion formInicioSesion)
        {
            InitializeComponent();
            this.formInicioSesion = formInicioSesion;
            _controladoraSeguridad = new ControladoraSeguridad(Context.Instancia);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();
            string email = txtEmail.Text.Trim();
            bool esVendedor = chkVendedor.Checked;
            bool esCliente = chkCliente.Checked;

            // Validar campos vacíos
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasenia) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear un nuevo usuario sin grupo asignado
            Usuario nuevoUsuario = new Usuario
            {
                NombreUsuario = nombreUsuario,
                Contrasenia = contrasenia,
                Email = email
            };

            // Crear un grupo de permisos para el usuario
            PermisoGrupo grupoTemporal = new PermisoGrupo();

            if (esVendedor)
            {
                grupoTemporal.Agregar(new Permiso("Vendedor", true));
            }

            if (esCliente)
            {
                grupoTemporal.Agregar(new Permiso("Cliente", true));
            }

            // Asignar el grupo temporal al usuario
            Grupo grupo = new Grupo
            {
                NombreGrupo = "Temporal",
                Permisos = grupoTemporal
            };

            nuevoUsuario.Grupo = grupo;

            try
            {
                _controladoraSeguridad.RegistrarUsuario(nuevoUsuario);
                MessageBox.Show("Usuario registrado exitosamente. Pendiente de aprobación del administrador.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cerrar el formulario después de registrar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
