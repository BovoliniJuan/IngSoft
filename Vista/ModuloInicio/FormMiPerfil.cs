using Controladoras.Seguridad;
using Controladoras.Vendedor;
using Entidades.EntidadesVendedores;
using Entidades.Seguridad2;
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
    public partial class FormMiPerfil : Form
    {
        Sesion? _sesion;
        public FormMiPerfil(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
            ActualizarPerfil();
        }
        private void ActualizarPerfil()
        {
            dgvMiPerfil.DataSource = null;
            dgvMiPerfil.AutoGenerateColumns = false;
            dgvMiPerfil.Columns.Clear();

            dgvMiPerfil.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreUsuario",
                HeaderText = "Usuario",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvMiPerfil.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });


            var miPerfil = ControladoraGestionUsuarios.Instancia.RecuperarUsuariosSesion(_sesion).ToList();
            dgvMiPerfil.DataSource = miPerfil;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            FormRecuperarClave formRecuperarClave = new FormRecuperarClave();
            formRecuperarClave.Show();
        }
    }
}
