using Controladoras;
using Controladoras.Administrador;
using Controladoras.Seguridad;
using Entidades;
using Entidades.Seguridad;
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
    public partial class FormGrupos : Form
    {
        public FormGrupos()
        {
            InitializeComponent();
            CargarGrupos();
            CargarUsuarios();
        }
        private void CargarGrupos()
        {
            // Obtener los grupos desde la base de datos y cargarlos en el ComboBox
            //var grupos = ControladoraGestionGrupos.Instancia.RecuperarGrupos();

            cmbGrupos.DataSource = ControladoraGestionGrupos.Instancia.RecuperarGrupos();
            /*cmbGrupos.DisplayMember = "NombreGrupo"; 
            cmbGrupos.ValueMember = "IdGrupo";*/

        }
      
        private void CargarUsuarios()
        {
            // Cargar todos los usuarios inicialmente
            var usuarios = ControladoraAdministrador.Instancia.ObtenerTodosLosUsuarios();
            dgvUsuarios.DataSource = usuarios.Select(u => new
            {
                u.IdUsuario,
                u.NombreUsuario,
                u.Email,
                TieneGrupo = u.Componentes.OfType<Grupo>().Any() ? "Sí" : "No"
            }).ToList();
        }

        private void AplicarFiltros()
        {
            // Obtener los usuarios de la base de datos
            var usuarios = ControladoraAdministrador.Instancia.ObtenerTodosLosUsuarios();

            // Aplicar filtros según el estado de los CheckBoxes
            if (chkSinGrupo.Checked && !chkConGrupo.Checked)
            {
                // Filtrar usuarios que no tienen grupo o que están en el grupo "Pendiente"
                usuarios = usuarios.Where(u =>
                    !u.Componentes.OfType<Grupo>().Any() ||
                    u.Componentes.OfType<Grupo>().All(g => g.NombreGrupo == "Pendiente")
                ).ToList();
            }
            else if (!chkSinGrupo.Checked && chkConGrupo.Checked)
            {
                // Filtrar usuarios que tienen al menos un grupo y que no sea únicamente el grupo "Pendiente"
                usuarios = usuarios.Where(u =>
                    u.Componentes.OfType<Grupo>().Any() &&
                    !u.Componentes.OfType<Grupo>().All(g => g.NombreGrupo == "Pendiente")
                ).ToList();
            }

            // Asignar los datos al DataGridView
            dgvUsuarios.DataSource = usuarios.Select(u => new
            {
                u.IdUsuario,
                u.NombreUsuario,
                u.Email,
                TieneGrupo = u.Componentes.OfType<Grupo>().Any()
                    ? string.Join(", ", u.Componentes.OfType<Grupo>().Select(g => g.NombreGrupo))
                    : "No"
            }).ToList();
        }



        private void btnAsignarGrupo_Click(object sender, EventArgs e)
        {
            // Validar selección de usuario
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar selección de grupo
            if (cmbGrupos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un grupo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener datos seleccionados
            var idUsuario = (int)dgvUsuarios.SelectedRows[0].Cells["IdUsuario"].Value;
            var grupoSeleccionado = (Grupo)cmbGrupos.SelectedItem;

            // Asignar grupo al usuario
            var resultado = ControladoraAdministrador.Instancia.AsignarGrupoAUsuario(idUsuario, grupoSeleccionado);
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refrescar la lista de usuarios
            CargarUsuarios();
        }

        private void chkSinGrupo_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void chkConGrupo_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }
    }
}
