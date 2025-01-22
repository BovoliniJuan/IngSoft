using Controladoras.Vendedor;
using Entidades.EntidadesVendedores;
using Entidades.EntidadesVenta;
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
    public partial class FormPedidos : Form
    {
        Sesion _sesion;
        private List<Pedido> _pedidosOriginales;

        public FormPedidos(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
            LlenarGrilla();
        }
        private void LlenarGrilla()
        {
            dgvPedidos.DataSource = null;
            dgvPedidos.AutoGenerateColumns = false;
            dgvPedidos.Columns.Clear();

            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaPedido",
                HeaderText = "Fecha de Pedido",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreCliente",
                HeaderText = "Cliente",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DescripcionPublicacion",
                HeaderText = "Publicación",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                HeaderText = "Total",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            _pedidosOriginales = ControladoraPedidos.Instancia.ObtenerPedidos(_sesion).ToList();

            var viewModel = _pedidosOriginales.Select(p => new PedidoViewModel
            {
                FechaPedido = p.FechaPedido,
                NombreCliente = p.Cliente.NombreCompleto,
                DescripcionPublicacion = p.Publicacion.Descripcion,
                Estado = p.Estado,
                Total = p.Total
            }).ToList();

            dgvPedidos.Rows.Clear();

            for (int i = 0; i < viewModel.Count; i++)
            {
                var rowIndex = dgvPedidos.Rows.Add();
                dgvPedidos.Rows[rowIndex].SetValues(viewModel[i].FechaPedido, viewModel[i].NombreCliente, viewModel[i].DescripcionPublicacion, viewModel[i].Estado, viewModel[i].Total);
                dgvPedidos.Rows[rowIndex].Tag = _pedidosOriginales[i]; // Asignar el pedido original al Tag
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {
                var pedido = dgvPedidos.SelectedRows[0].Tag as Pedido;
                if (pedido != null)
                {
                    try
                    {
                        ControladoraPedidos.Instancia.ConfirmarPedido(pedido);
                        MessageBox.Show("Pedido confirmado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGrilla(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un pedido para confirmar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {
                var pedido = dgvPedidos.SelectedRows[0].Tag as Pedido;
                if (pedido != null)
                {
                    try
                    {
                        ControladoraPedidos.Instancia.CancelarPedido2(pedido);
                        MessageBox.Show("Pedido cancelado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGrilla(); // Refrescar la grilla
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un pedido para cancelar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {
                var pedido = dgvPedidos.SelectedRows[0].Tag as Pedido;
                if (pedido != null)
                {
                    try
                    {
                        ControladoraPedidos.Instancia.EnviarPedido(pedido);
                        MessageBox.Show("Pedido enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGrilla(); // Refrescar la grilla
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un pedido para enviar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
