using Controladoras.Seguridad;
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

namespace Vista.ModuloSeguridad
{
    public partial class FormGestionarGrupos : Form
    {
        public FormGestionarGrupos()
        {
            InitializeComponent();
            dgvGrupos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var estados = ControladoraGestionGrupos.Instancia.ObtenerEstadosGrupos();
            cmbEstado.DataSource = estados;
            cmbEstado.DisplayMember = "EstadoGrupoNombre"; // Muestra el nombre del estado
            cmbEstado.ValueMember = "EstadoGrupoId"; // Usa el ID del estado para la selección
            cmbEstado.SelectedIndex = 0;
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            dgvGrupos.DataSource = null;
            dgvGrupos.DataSource = ControladoraGestionGrupos.Instancia.RecuperarGrupos();
            Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formAgregarGrupo = new FormCrearGrupos();
            formAgregarGrupo.ShowDialog();
            ActualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.CurrentRow != null)
            {
                var grupoSeleccionado = (Grupo)dgvGrupos.CurrentRow.DataBoundItem;
                var formModificar = new FormCrearGrupos(grupoSeleccionado);
                formModificar.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("No tienes ningún grupo seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.SelectedRows.Count > 0)
            {
                var grupoSeleccionado = dgvGrupos.SelectedRows[0].DataBoundItem as Grupo;

                DialogResult respuesta = MessageBox.Show(
                    "¿Estás seguro que quieres eliminar el grupo: " + grupoSeleccionado.Id + " ?",
                    "Eliminar Grupo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = ControladoraGestionGrupos.Instancia.EliminarGrupo(grupoSeleccionado);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("No tienes ningún grupo seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                // Si el texto está vacío, carga todas las publicaciones
                ActualizarGrilla();
            }
            else
            {
                // Filtra las publicaciones por el nombre del producto
                dgvGrupos.DataSource = null;
                dgvGrupos.DataSource = ControladoraGestionGrupos.Instancia.FiltrarGruposPorNombre(textoBusqueda);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool? filtroEstado = null;
            if (cmbEstado.SelectedItem != null)
            {
                string estadoSeleccionado = cmbEstado.SelectedItem.ToString();
                if (estadoSeleccionado == "Activo")
                    filtroEstado = true;
                else if (estadoSeleccionado == "Inactivo")
                    filtroEstado = false;
                else
                    filtroEstado = null; // "Todos"
            }
            var listaGrupos = new List<Grupo>(ControladoraGestionGrupos.Instancia.RecuperarGrupos());
            if (filtroEstado.HasValue)
            {
                listaGrupos = listaGrupos
                    .Where(g => g.EstadoGrupo.EstadoGrupoNombre == (filtroEstado.Value ? "Activo" : "Inactivo"))
                    .ToList();
            }

            dgvGrupos.DataSource = null;
            dgvGrupos.DataSource = listaGrupos;

        }
    }
}
