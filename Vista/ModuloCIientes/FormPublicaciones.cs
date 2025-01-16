using Controladoras.Administrador;
using Controladoras.Cliente;
using Controladoras.Vendedor;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.ModuloCIientes
{
    public partial class FormPublicaciones : Form
    {
        public FormPublicaciones()
        {
            InitializeComponent();
            CargarPublicaciones();
            chkMenorP.CheckedChanged += Filtros_CheckedChanged;
            chkMayorP.CheckedChanged += Filtros_CheckedChanged;
            chkMenorA.CheckedChanged += Filtros_CheckedChanged;
            chkMayorA.CheckedChanged += Filtros_CheckedChanged;
        }
        private void CargarPublicaciones()
        {
            dgvPublicaciones.DataSource = null;
            dgvPublicaciones.DataSource = ControladoraPublicaciones.Instancia.RecuperarPublicaciones();
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = ControladoraCarrito.Instancia.RecuperarCarrito();

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscador.Text.Trim();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                // Si el texto está vacío, carga todas las publicaciones
                CargarPublicaciones();
            }
            else
            {
                // Filtra las publicaciones por el nombre del producto
                dgvPublicaciones.DataSource = null;
                dgvPublicaciones.DataSource = ControladoraPublicaciones.Instancia.FiltrarPublicacionesPorNombre(textoBusqueda);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscador.Text.Trim();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                MessageBox.Show("Por favor, ingrese un texto para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgvPublicaciones.DataSource = null;
                dgvPublicaciones.DataSource = ControladoraPublicaciones.Instancia.FiltrarPublicacionesPorNombre(textoBusqueda);
            }
        }
        private void Filtros_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMenorP.Checked)
            {
                chkMayorP.Checked = false;
            }
            else if (chkMayorP.Checked)
            {
                chkMenorP.Checked = false;
            }

            if (chkMenorA.Checked)
            {
                chkMayorA.Checked = false;
            }
            else if (chkMayorA.Checked)
            {
                chkMenorA.Checked = false;
            }

            AplicarFiltros();
        }
        

        private void AplicarFiltros()
        {
            var publicaciones = ControladoraPublicaciones.Instancia.RecuperarPublicaciones().ToList();

            // Aplicar filtros
            if (chkMenorP.Checked)
            {
                publicaciones = publicaciones.OrderBy(p => p.Producto.Precio).ToList();
            }
            else if (chkMayorP.Checked)
            {
                publicaciones = publicaciones.OrderByDescending(p => p.Producto.Precio).ToList();
            }

            if (chkMenorA.Checked)
            {
                publicaciones = publicaciones.OrderBy(p => p.FechaInicio).ToList();
            }
            else if (chkMayorA.Checked)
            {
                publicaciones = publicaciones.OrderByDescending(p => p.FechaInicio).ToList();
            }

            // Actualizar el DataGridView con las publicaciones filtradas
            dgvPublicaciones.DataSource = null;
            dgvPublicaciones.DataSource = publicaciones;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

      
    }
}
