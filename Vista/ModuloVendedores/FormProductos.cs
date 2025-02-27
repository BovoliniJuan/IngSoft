using Controladoras.Cliente;
using Controladoras.Vendedor;
using Entidades.EntidadesVendedores;
using Entidades.Seguridad2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        Sesion? _sesion;
        public FormProductos(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
            CargarProductos();
        }


        private void CargarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.AutoGenerateColumns = false; // Desactiva la generación automática de columnas

            dgvProductos.Columns.Clear(); // Limpia cualquier configuración previa de columnas

            // Define las columnas manualmente
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descripcion",
                HeaderText = "Descripción",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProductos.DataSource = ControladoraProductos.Instancia.RecuperarProductosVendedor(_sesion);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                var productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                var formModificar = new FormAgregarProd(productoSeleccionado,_sesion);
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
            if (dgvProductos.CurrentRow != null)
            {
                var productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                var resultado = ControladoraProductos.Instancia.EliminarProducto(productoSeleccionado, _sesion);
                CargarProductos();
                MessageBox.Show(resultado, "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No tienes ninguna producto seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void chkMenorPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMenorPrecio.Checked)
            {
                // Desmarcar otros filtros de precio
                chkMayorPrecio.Checked = false;
            }
            AplicarFiltros();
        }

        private void chkMayorPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMayorPrecio.Checked)
            {
                // Desmarcar otros filtros de precio
                chkMenorPrecio.Checked = false;
            }
            AplicarFiltros();
        }

        private void chkMenorCantidad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMenorCantidad.Checked)
            {
                // Desmarcar otros filtros de cantidad
                chkMayorCantidad.Checked = false;
            }
            AplicarFiltros();
        }

        private void chkMayorCantidad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMayorCantidad.Checked)
            {
                // Desmarcar otros filtros de cantidad
                chkMenorCantidad.Checked = false;
            }
            AplicarFiltros();
        }
        private void AplicarFiltros()
        {
            if (_sesion == null)
            {
                MessageBox.Show("Sesión no válida. No se pueden cargar los productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var productos = ControladoraProductos.Instancia.RecuperarProductosVendedor(_sesion).ToList(); 

            if (chkMenorPrecio.Checked)
            {
                productos = productos.OrderBy(p => p.Precio).ToList();
            }
            else if (chkMayorPrecio.Checked)
            {
                productos = productos.OrderByDescending(p => p.Precio).ToList();
            }

            if (chkMenorCantidad.Checked)
            {
                productos = productos.OrderBy(p => p.Cantidad).ToList();
            }
            else if (chkMayorCantidad.Checked)
            {
                productos = productos.OrderByDescending(p => p.Cantidad).ToList();
            }

            dgvProductos.DataSource = new ReadOnlyCollection<Producto>(productos);
        }


    }
}
