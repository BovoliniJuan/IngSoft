using Controladoras.Vendedor;
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

namespace Vista.ModuloVendedores
{
    public partial class FormMisPublicaciones : Form
    {
        Sesion? _sesion;
        public FormMisPublicaciones(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
            CargarPublicaciones();
        }
        private void CargarPublicaciones()
        {
            dgvPublicaciones.DataSource = null;
            dgvPublicaciones.AutoGenerateColumns = false; // Desactiva la generación automática de columnas

            dgvPublicaciones.Columns.Clear(); // Limpia cualquier configuración previa de columnas

            // Define las columnas manualmente
            dgvPublicaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descripcion",
                HeaderText = "Descripcion",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPublicaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaInicio",
                HeaderText = "Fecha de inicio",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPublicaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaFin",
                HeaderText = "Fecha de Fin",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPublicaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPublicaciones.DataSource = ControladoraPublicaciones.Instancia.RecuperarPublicacionesVendedor(_sesion);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnPausar_Click(object sender, EventArgs e)
        {

        }
    }
}
