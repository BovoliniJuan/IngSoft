using Controladoras.Seguridad;
using Controladoras.Vendedor;
using Entidades;
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

namespace Vista.ModuloCIientes
{
    public partial class FormMisPedidos : Form
    {
        Sesion? _sesion;
        private List<Pedido> _pedidosOriginales;

        public FormMisPedidos(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
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
                DataPropertyName = "FechaEntrega",
                HeaderText = "Fecha de Entrega",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvPedidos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreEmpresa",
                HeaderText = "Vendedor",
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

            _pedidosOriginales = ControladoraPedidos.Instancia.ObtenerPedidosClientes(_sesion).ToList();

            var viewModel = _pedidosOriginales.Select(p => new Entidades.EntidadesClientes.PedidoViewModel2
            {
                FechaPedido = p.FechaPedido,
                FechaEntrega = p.FechaEntrega,
                NombreEmpresa = p.Vendedor.NombreEmpresa,
                DescripcionPublicacion = p.Publicacion.Descripcion,
                Estado = p.Estado,
                Total = p.Total
            }).ToList();

            dgvPedidos.Rows.Clear();

            for (int i = 0; i < viewModel.Count; i++)
            {
                var rowIndex = dgvPedidos.Rows.Add();
                dgvPedidos.Rows[rowIndex].SetValues(viewModel[i].FechaPedido, viewModel[i].FechaEntrega, viewModel[i].NombreEmpresa, viewModel[i].DescripcionPublicacion, viewModel[i].Estado, viewModel[i].Total);
                dgvPedidos.Rows[rowIndex].Tag = _pedidosOriginales[i];
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {
                var pedido = dgvPedidos.SelectedRows[0].Tag as Pedido;
                if (pedido != null)
                {
                    try
                    {
                        ControladoraPedidos.Instancia.RecibirPedido(pedido);
                        MessageBox.Show("Gracias por confirmar que recibio el pedido.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarGrilla();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un pedido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AplicarFiltros()
        {
            var estadosSeleccionados = new List<string>();

            if (chkCancelado.Checked)
                estadosSeleccionados.Add("Cancelado");
            if (chkConfirmado.Checked)
                estadosSeleccionados.Add("Confirmado");
            if (chkEntregado.Checked)
                estadosSeleccionados.Add("Entregado");
            if (chkEnviado.Checked)
                estadosSeleccionados.Add("Enviado");
            if (chkPendiente.Checked)
                estadosSeleccionados.Add("Pendiente");

            List<Pedido> pedidosFiltrados;

            if (estadosSeleccionados.Count == 0)
            {
                pedidosFiltrados = _pedidosOriginales;
            }
            else
            {
                pedidosFiltrados = _pedidosOriginales
                    .Where(p => estadosSeleccionados.Contains(p.Estado))
                    .ToList();
            }

            var viewModel = pedidosFiltrados.Select(p => new Entidades.EntidadesClientes.PedidoViewModel2
            {
                FechaPedido = p.FechaPedido,
                FechaEntrega = p.FechaEntrega,
                NombreEmpresa = p.Vendedor.NombreEmpresa,
                DescripcionPublicacion = p.Publicacion.Descripcion,
                Estado = p.Estado,
                Total = p.Total
            }).ToList();

            dgvPedidos.Rows.Clear();

            for (int i = 0; i < viewModel.Count; i++)
            {
                var rowIndex = dgvPedidos.Rows.Add();
                dgvPedidos.Rows[rowIndex].SetValues(viewModel[i].FechaPedido, viewModel[i].FechaEntrega, viewModel[i].NombreEmpresa, viewModel[i].DescripcionPublicacion, viewModel[i].Estado, viewModel[i].Total);
                dgvPedidos.Rows[rowIndex].Tag = pedidosFiltrados[i];
            }
        }


        private void chkCancelado_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void chkConfirmado_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void chkEnviado_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void chkEntregado_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void chkPendiente_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }
    }
}
