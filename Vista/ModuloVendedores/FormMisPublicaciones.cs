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

namespace Vista.ModuloVendedores
{
    public partial class FormMisPublicaciones : Form
    {
        Sesion? _sesion;
        private List<Publicacion> publicaciones; 

        public FormMisPublicaciones(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
            CargarPublicaciones();
        }
        private void CargarPublicaciones()
        {
            dgvPublicaciones.DataSource = null;
            dgvPublicaciones.AutoGenerateColumns = false;
            dgvPublicaciones.Columns.Clear();

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
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPublicaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPublicaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Recuperar las publicaciones del vendedor y almacenarlas
            publicaciones = ControladoraPublicaciones.Instancia.RecuperarPublicacionesVendedor(_sesion).ToList();
            dgvPublicaciones.DataSource = publicaciones;
        }
        

        private void AplicarFiltros()
        {
            var publicacionesFiltradas = publicaciones.AsEnumerable();

            // Filtrar por menor antigüedad (orden por FechaInicio ascendente)
            if (chkMenorAnt.Checked)
                publicacionesFiltradas = publicacionesFiltradas.OrderBy(p => p.FechaInicio);

            // Filtrar por mayor antigüedad (orden por FechaInicio descendente)
            if (chkMayorAnt.Checked)
                publicacionesFiltradas = publicacionesFiltradas.OrderByDescending(p => p.FechaInicio);

            // Filtrar por menor cantidad
            if (chkMenorCant.Checked)
                publicacionesFiltradas = publicacionesFiltradas.OrderBy(p => p.Cantidad);

            // Filtrar por mayor cantidad
            if (chkMayorCant.Checked)
                publicacionesFiltradas = publicacionesFiltradas.OrderByDescending(p => p.Cantidad);

            // Filtrar por menor precio
            if (chkMenorPrec.Checked)
                publicacionesFiltradas = publicacionesFiltradas.OrderByDescending(p => p.Precio);


            // Filtrar por mayor precio
            if (chkMayorPrec.Checked)
                publicacionesFiltradas = publicacionesFiltradas.OrderBy(p => p.Precio);


            // Actualizar el DataSource con los datos filtrados
            dgvPublicaciones.DataSource = publicacionesFiltradas.ToList();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPublicaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una publicación para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var publicacionSeleccionada = dgvPublicaciones.SelectedRows[0].DataBoundItem as Publicacion;
            if (publicacionSeleccionada == null)
            {
                MessageBox.Show("No se pudo obtener la publicación seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmacion = MessageBox.Show($"¿Está seguro que desea eliminar la publicación \"{publicacionSeleccionada.Descripcion}\"?",
                                               "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    int cantidadDevuelta = ControladoraPublicaciones.Instancia.EliminarPublicacion(publicacionSeleccionada.IdPublicacion);

                    var producto = ControladoraProductos.Instancia.ObtenerProductoPorId(publicacionSeleccionada.IdProducto);
                    if (producto != null)
                    {
                        producto.Cantidad += cantidadDevuelta; // Devolver la cantidad al stock
                        ControladoraProductos.Instancia.ActualizarProducto(producto,_sesion);
                    }

                    MessageBox.Show("Publicación eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPublicaciones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la publicación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (dgvPublicaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una publicación para pausar o habilitar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var publicacionSeleccionada = dgvPublicaciones.SelectedRows[0].DataBoundItem as Publicacion;
            if (publicacionSeleccionada == null)
            {
                MessageBox.Show("No se pudo obtener la publicación seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cambiar el estado de la publicación
            publicacionSeleccionada.Estado = !publicacionSeleccionada.Estado;
            ControladoraPublicaciones.Instancia.ActualizarPublicacion(publicacionSeleccionada);

            var estado = publicacionSeleccionada.Estado ? "habilitada" : "pausada";
            MessageBox.Show($"La publicación ha sido {estado} correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarPublicaciones();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkMenorAnt_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void chkMayorAnt_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void chkMenorCant_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void chkMayorCant_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void chkMenorPrec_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void chkMayorPrec_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }
    }
}
