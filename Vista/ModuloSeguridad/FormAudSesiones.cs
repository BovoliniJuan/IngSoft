using Controladoras.Seguridad;
using Controladoras.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.ModuloSeguridad
{
    public partial class FormAudSesiones : Form
    {
        public FormAudSesiones()
        {
            InitializeComponent();
            CargarDatos();
        }
        public void CargarDatos() 
        {
            dgvAuditoria.DataSource = null;
            dgvAuditoria.AutoGenerateColumns = false;
            dgvAuditoria.Columns.Clear();

            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreUsuario",
                HeaderText = "Usuario",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaMovimiento",
                HeaderText = "Fecha",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TipoMovimiento",
                HeaderText = "Tipo de Movimiento",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });
            dgvAuditoria.DataSource = ControladoraAuditorias.Instancia.RecuperarAuditoriasSesiones();
        }
       
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
