using Controladoras.Cliente;
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

namespace Vista.ModuloCIientes
{
    public partial class FormMiCarrito : Form
    {
        Sesion? _sesion;
        public FormMiCarrito(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
            CargarCarrito();
        }

        private void CargarCarrito()
        {
            try
            {
                var cliente = ControladoraCarrito.Instancia.ObtenerClientePorUsuario(_sesion.UsuarioSesion);
                if (cliente != null)
                {
                    var carrito = ControladoraCarrito.Instancia.ObtenerCarritoPorCliente(cliente);

                    if (carrito != null)
                    {
                        dgvCarrito.DataSource = null;
                        dgvCarrito.AutoGenerateColumns = false;
                        dgvCarrito.Columns.Clear();

                        dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            DataPropertyName = "Descripcion",
                            HeaderText = "Descripcion",
                            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                        });

                        dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            DataPropertyName = "FechaInicio",
                            HeaderText = "Fecha de inicio",
                            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                        });

                        dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            DataPropertyName = "FechaFin",
                            HeaderText = "Fecha de Fin",
                            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                        });

                        dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            DataPropertyName = "Cantidad",
                            HeaderText = "Cantidad",
                            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                        });

                        dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            DataPropertyName = "Precio",
                            HeaderText = "Precio",
                            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                        });

                        dgvCarrito.DataSource = carrito.Publicaciones.ToList();
                    }
                    else
                    {
                        MessageBox.Show("El cliente no tiene un carrito de compras asociado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el cliente asociado al usuario de la sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el carrito de compras: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCarrito.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, seleccione una publicación para eliminar del carrito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var publicacionSeleccionada = dgvCarrito.CurrentRow.DataBoundItem as Publicacion;

                if (publicacionSeleccionada != null)
                {
                    var cliente = ControladoraCarrito.Instancia.ObtenerClientePorUsuario(_sesion.UsuarioSesion);

                    if (cliente != null)
                    {
                        var carrito = ControladoraCarrito.Instancia.ObtenerCarritoActivo(cliente);

                        if (carrito != null)
                        {
                            carrito.Publicaciones.Remove(publicacionSeleccionada);
                            ControladoraCarrito.Instancia.ActualizarCarrito(carrito);
                            MessageBox.Show("Publicación eliminada del carrito con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarCarrito();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un carrito activo para este cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente asociado a esta sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la publicación del carrito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            FormCompra formCompra = new FormCompra(_sesion);
            formCompra.ShowDialog();
            this.Close();
        }
    }
}
