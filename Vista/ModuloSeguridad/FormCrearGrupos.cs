using Controladoras.Seguridad;
using Entidades;
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

namespace Vista.ModuloSeguridad
{
    public partial class FormCrearGrupos : Form
    {
        private Grupo grupo;
        private bool modificar = false;
        public FormCrearGrupos()
        {
            InitializeComponent();

            this.grupo = new Grupo();
            var estados = ControladoraGestionGrupos.Instancia.ObtenerEstadosGrupos();


            cmbEstado.DataSource = estados;
            cmbEstado.DisplayMember = "EstadoGrupoNombre"; // Muestra el nombre del estado
            cmbEstado.ValueMember = "EstadoGrupoId"; // Usa el ID del estado para la selección

            cmbEstado.SelectedIndex = 0;

            modificar = false;
        }
        // Constructor Modificar
        public FormCrearGrupos(Grupo grupoSeleccionado)
        {
            InitializeComponent();

            this.grupo = grupoSeleccionado;
            this.modificar = true;


            var estados = ControladoraGestionGrupos.Instancia.ObtenerEstadosGrupos();

            cmbEstado.DataSource = estados;
            cmbEstado.DisplayMember = "EstadoGrupoNombre"; // Muestra el nombre del estado
            cmbEstado.ValueMember = "EstadoGrupoId"; // Usa el ID del estado para la selección
            cmbEstado.SelectedValue = grupo.EstadoGrupo;


            CargarDatosGrupo(); // Cargar los datos correctamente

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            var accionesSeleccionadas = ObtenerAccionesSeleccionadas();
            if (accionesSeleccionadas.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una acción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            grupo.Nombre = txtNombre.Text;
            grupo.IdGrupo = int.Parse(txtCodigo.Text.Trim());
            grupo.EstadoGrupo = (EstadoGrupo)cmbEstado.SelectedItem;
            grupo.Componentes = accionesSeleccionadas;

            string mensaje = modificar
                ? ControladoraGestionGrupos.Instancia.ModificarGrupo(grupo)
                : ControladoraGestionGrupos.Instancia.AgregarGrupo(grupo);

            MessageBox.Show(mensaje, "Información Grupo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeAcciones_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // Desactivar temporalmente el evento AfterCheck
            treeAcciones.AfterCheck -= treeAcciones_AfterCheck;

            try
            {
                if (e.Node.Nodes.Count > 0) // Nodo padre
                {
                    foreach (TreeNode subNodo in e.Node.Nodes)
                    {
                        subNodo.Checked = e.Node.Checked; // Marcar/desmarcar todos los subnodos
                    }
                }
                else // Nodo hijo
                {
                    TreeNode nodoPadre = e.Node.Parent;
                    if (nodoPadre != null)
                    {
                        // Si todos los subnodos están marcados, marca el nodo padre
                        nodoPadre.Checked = nodoPadre.Nodes.Cast<TreeNode>().All(n => n.Checked);
                    }
                }
            }
            finally
            {
                // Volver a activar el evento AfterCheck
                treeAcciones.AfterCheck += treeAcciones_AfterCheck;
            }
        }
        private List<Componente> ObtenerAccionesSeleccionadas()
        {
            List<Componente> accionesSeleccionadas = new List<Componente>();

            foreach (TreeNode nodo in treeAcciones.Nodes)
            {
                if (nodo.Checked)
                {
                    // Agregar la acción del nodo padre
                    var nombreAccion = nodo.Text;
                    var accion = ControladoraAcciones.Instancia.ObtenerAccionPorNombre(nombreAccion);
                    if (accion != null)
                    {
                        accionesSeleccionadas.Add(accion);
                    }

                    // Agregar todas las acciones de los subnodos si el nodo padre está marcado
                    foreach (TreeNode subNodo in nodo.Nodes)
                    {
                        var nombreSubAccion = subNodo.Text;
                        var subAccion = ControladoraAcciones.Instancia.ObtenerAccionPorNombre(nombreSubAccion);
                        if (subAccion != null)
                        {
                            accionesSeleccionadas.Add(subAccion);
                        }
                    }
                }
                else
                {
                    // Si el nodo padre no está marcado, verificar los subnodos individualmente
                    foreach (TreeNode subNodo in nodo.Nodes)
                    {
                        if (subNodo.Checked) // Si el subnodo está marcado, agregarlo
                        {
                            var nombreSubAccion = subNodo.Text;
                            var subAccion = ControladoraAcciones.Instancia.ObtenerAccionPorNombre(nombreSubAccion);
                            if (subAccion != null)
                            {
                                accionesSeleccionadas.Add(subAccion);
                            }
                        }
                    }
                }
            }

            return accionesSeleccionadas.Distinct().ToList(); // Asegurarse de que no haya duplicados
        }




        private void CargarAccionesGrupo()
        {
            // Obtener los nombres de las acciones asignadas al usuario desde la base de datos
            var accionesAsignadas = ControladoraAcciones.Instancia.ObtenerAccionesGrupo(grupo).Select(a => a.Nombre).ToList();

            // Recorrer cada nodo en el TreeView 
            foreach (TreeNode nodoCategoria in treeAcciones.Nodes)
            {
                // Recorrer cada subnodo dentro de la categoría
                foreach (TreeNode nodoAccion in nodoCategoria.Nodes)
                {
                    // Verificar que el Tag no sea nulo y que sea de tipo string
                    if (nodoAccion.Tag is string nombreAccion)
                    {
                        // Si la acción está asignada al grupo, marcarla como seleccionada
                        if (accionesAsignadas.Contains(nombreAccion))
                        {
                            nodoAccion.Checked = true;
                        }
                    }
                }
            }
        }




        private void CargarDatosGrupo()
        {
            txtNombre.Text = grupo.Nombre;
            cmbEstado.SelectedValue = grupo.EstadoGrupo.EstadoGrupoId;
            CargarAccionesGrupo();
        }



        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del grupo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    }
}
