using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.EntidadesClientes;
using Entidades.EntidadesVendedores;

namespace Entidades.EntidadesVenta
{
    public class Pedido
    {
        private int idPedido;
        private DateTime fechaPedido;
        private DateTime fechaEntrega;
        private Cliente cliente;
        private CarritoDeCompra carrito;
        private EstadoPedido estadoPedido;
        private float total;
        private Vendedor vendedor;
        private Pago pago;

        [Key]
        public int IdPedido { get { return idPedido; } set { idPedido = value; } }
        public DateTime FechaPedido { get { return fechaPedido; } set { fechaPedido = value; } }
        public DateTime FechaEntrega { get { return fechaEntrega; } set { fechaEntrega = value; } }
        public int ClienteIdPersona { get; set; }

        public Cliente Cliente { get { return cliente; } set { cliente = value; } }
        public int CarritoDeCompraIdCarritoDeCompras { get; set; }

        public CarritoDeCompra CarritoDeCompra { get { return carrito; } set { carrito = value; } }
        public int EstadoPedidoIdEstadoPedido { get; set; }

        public EstadoPedido EstadoPedido { get { return estadoPedido; } set { estadoPedido = value; } }
        public float Total { get { return total; } set { total = value; } }
        public int VendedorIdPersona { get; set; }
        public Vendedor Vendedor { get { return vendedor; } set { vendedor = value; } }
        public Pago Pago { get { return pago; } set { pago = value; } }

        public Pedido() { }
        public void ConfirmarPedido() { }
        public void CancelarPedido() { }
        public void AgregarPago(Pago pago) { }


    }
}
