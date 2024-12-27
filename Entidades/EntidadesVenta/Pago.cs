using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.EntidadesClientes;

namespace Entidades.EntidadesVenta
{
    public class Pago
    {
        private int idPago;
        private DateTime fechaPago;
        private float monto;
        private MetodoDePago metodoDePago;
        private bool estadoPago;
        private Pedido pedido;
        private Cliente cliente;
        private int referenciaTransaccion;

        [Key]
        public int IdPago { get { return idPago; } set { idPago = value; } }
        public DateTime FechaPago { get { return fechaPago; } set { fechaPago = value; } }
        public float Monto { get { return monto; } set { monto = value; } }
        public MetodoDePago MetodoDePago { get { return metodoDePago; } set { metodoDePago = value; } }
        public bool EstadoPago { get { return estadoPago; } set { estadoPago = value; } }
        public Pedido Pedido { get { return pedido; } set { pedido = value; } }
        public Cliente Cliente { get { return cliente; } set { cliente = value; } }
        public int ReferenciaTransaccion { get { return referenciaTransaccion; } set { referenciaTransaccion = value; } }

        public Pago() { }

    }
}
