using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.EntidadesClientes;
using Entidades.EntidadesVendedores;
using Entidades.EntidadesVenta.EstadosPedidos;

namespace Entidades.EntidadesVenta
{
    public class Pedido
    {
        private int idPedido;
        private DateTime fechaPedido;
        private DateTime fechaEntrega;
        private Cliente cliente;
        private IPedidoState estadoPedido;
        private string estado;
        private float total;
        private Publicacion publicacion;
        private Vendedor vendedor;

        private Pago pago;

        [Key]
        public int IdPedido { get { return idPedido; } set { idPedido = value; } }
        public DateTime FechaPedido { get { return fechaPedido; } set { fechaPedido = value; } }
        public DateTime FechaEntrega { get { return fechaEntrega; } set { fechaEntrega = value; } }
        public int idCliente { get; set; }

        public Cliente Cliente { get { return cliente; } set { cliente = value; } }
        public Publicacion Publicacion { get { return publicacion; } set { publicacion = value; } }
        [NotMapped]
        public IPedidoState EstadoPedido { get { return estadoPedido; } set { estadoPedido = value; Estado = ObtenerNombreEstado(estadoPedido); } }
        public string Estado { get { return estado; } set { estado = value; estadoPedido = AsignarEstado(estado);  } }

        public float Total { get { return total; } set { total = value; } }
        public int idVendedor { get; set; }

        public Vendedor Vendedor { get { return vendedor; } set { vendedor = value; } }
        public Pago Pago { get { return pago; } set { pago = value; } }

        public Pedido() { }
        public void ConfirmarPedido() 
        {
            EstadoPedido.Confirmar(this);
        }
        public void CancelarPedido() 
        {
            EstadoPedido.Cancelar(this);
        }
        public void EnviarPedido()
        {
            EstadoPedido.Enviar(this);
        }
        public void RecibirPedido()
        {
            EstadoPedido.Recibido(this);
        }
        public void CambiarEstado(IPedidoState nuevoEstado)
        {
            EstadoPedido = nuevoEstado;
        }
        public string ObtenerNombreEstado(IPedidoState estado)
        {
            if (estado is EstadoEntregado)
                return "Entregado";
            else if (estado is EstadoPendiente)
                return "Pendiente";
            else if (estado is EstadoCancelado)
                return "Cancelado";
            else if (estado is EstadoEnProceso)
                return "En Proceso";
            else if (estado is EstadoConfirmado)
                return "Confirmado";
            else
                return "Desconocido";
        }
        public IPedidoState AsignarEstado(string estado)
        {
            Console.WriteLine($"Intentando asignar el estado: {estado}");

            switch (estado)
            {
                case "Confirmado":
                    return new EstadoConfirmado();
                case "Pendiente":
                    return new EstadoPendiente();
                case "Cancelado":
                    return new EstadoCancelado();
                case "En Proceso":
                    return new EstadoEnProceso();
                case "Entregado":
                    return new EstadoEntregado();
                default:
                    throw new InvalidOperationException($"Estado desconocido: {estado}");
            }
        }



    }
}
