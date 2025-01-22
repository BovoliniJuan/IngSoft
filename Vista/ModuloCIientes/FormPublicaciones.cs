using Controladoras.Administrador;
using Controladoras.Cliente;
using Controladoras.Vendedor;
using Entidades;
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
    public partial class FormPublicaciones : Form
    {
        Sesion? _sesion;
        public FormPublicaciones(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
            CargarPublicaciones();
            CargarCarrito();
            chkMenorP.CheckedChanged += Filtros_CheckedChanged;
            chkMayorP.CheckedChanged += Filtros_CheckedChanged;
            chkMenorA.CheckedChanged += Filtros_CheckedChanged;
            chkMayorA.CheckedChanged += Filtros_CheckedChanged;
        }
        private void CargarPublicaciones()
        {
            dgvPublicaciones.DataSource = null;
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

            dgvPublicaciones.DataSource = ControladoraPublicaciones.Instancia.RecuperarPublicaciones().ToList();

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
                publicaciones = publicaciones.OrderBy(p => p.Precio).ToList();
            }
            else if (chkMayorP.Checked)
            {
                publicaciones = publicaciones.OrderByDescending(p => p.Precio).ToList();
            }

            if (chkMenorA.Checked)
            {
                publicaciones = publicaciones.OrderByDescending(p => p.FechaInicio).ToList();
            }
            else if (chkMayorA.Checked)
            {
                publicaciones = publicaciones.OrderBy(p => p.FechaInicio).ToList();
            }

            // Actualizar el DataGridView con las publicaciones filtradas
            dgvPublicaciones.DataSource = null;
            dgvPublicaciones.DataSource = publicaciones;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPublicaciones.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, seleccione una publicación para agregar al carrito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var publicacionSeleccionada = dgvPublicaciones.CurrentRow.DataBoundItem as Publicacion;

                if (publicacionSeleccionada != null)
                {
                    var cliente = ControladoraCarrito.Instancia.ObtenerClientePorUsuario(_sesion.UsuarioSesion);

                    if (cliente != null)
                    {
                        var carrito = ControladoraCarrito.Instancia.ObtenerCarritoActivo(cliente);

                        if (carrito != null)
                        {
                            carrito.Publicaciones.Add(publicacionSeleccionada);
                            ControladoraCarrito.Instancia.ActualizarCarrito(carrito);
                            MessageBox.Show("Publicación agregada al carrito con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Error al agregar la publicación al carrito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            FormMiCarrito formMiCarrito = new FormMiCarrito(_sesion);
            formMiCarrito.ShowDialog();
            this.Close();
        }
    }
}
