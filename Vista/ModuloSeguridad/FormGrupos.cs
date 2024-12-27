using Controladoras;
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
        private readonly ControladoraSeguridad _controladoraSeguridad;
        public FormGrupos()
        {
            InitializeComponent();
            _controladoraSeguridad = new ControladoraSeguridad(Context.Instancia);
            CargarUsuariosPendientes();
        }

        private void CargarUsuariosPendientes()
        {
            var usuariosPendientes = _controladoraSeguridad.ObtenerUsuariosConGrupoTemporal();
            dgvUsuarios.DataSource = usuariosPendientes; // Asumimos que tienes un DataGridView
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            var usuarioSeleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
            var grupoFinal = CrearGrupoFinal(); // Lógica para seleccionar el grupo
            _controladoraSeguridad.AsignarGrupo(usuarioSeleccionado, grupoFinal);
            MessageBox.Show("Usuario aprobado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarUsuariosPendientes();
        }

        private Grupo CrearGrupoFinal()
        {
            // Lógica para asignar un grupo final según el rol del usuario
            return new Grupo { NombreGrupo = "Final", Permisos = new PermisoGrupo() }; // Ejemplo
        }
    }
}
