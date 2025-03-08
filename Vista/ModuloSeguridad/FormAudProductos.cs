using Controladoras.Seguridad;
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
    public partial class FormAudProductos : Form
    {
        public FormAudProductos()
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
                DataPropertyName = "NombreProducto",
                HeaderText = "Producto",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DescripcionProducto",
                HeaderText = "Descripcion",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CantidadProducto",
                HeaderText = "Cantidad",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fecha_Auditoria",
                HeaderText = "Fecha",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TipoMovimiento",
                HeaderText = "Tipo de Movimiento",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });
            dgvAuditoria.DataSource = ControladoraAuditorias.Instancia.RecuperarAuditoriasProductos();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
