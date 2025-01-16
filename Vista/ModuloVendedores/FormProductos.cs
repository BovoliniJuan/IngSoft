using Controladoras.Cliente;
using Controladoras.Vendedor;
using Entidades.EntidadesVendedores;
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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = ControladoraProductos.Instancia.RecuperarProductos();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                var productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                var formModificar = new FormAgregarProd(productoSeleccionado);
                formModificar.ShowDialog();
                CargarProductos();
            }
            else
            {
                MessageBox.Show("No tienes ninguna producto seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
