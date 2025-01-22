using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesVenta.EstadosPedidos
{
    public  class EstadoCancelado: IPedidoState
    {
        public void Confirmar(Pedido pedido)
        {
            throw new InvalidOperationException("No puedes confirmar un pedido cancelado.");

        }
        public void Enviar (Pedido pedido)
        {
            throw new InvalidOperationException("No puedes enviar un pedido cancelado.");

        }
        public void Cancelar (Pedido pedido)
        {
            throw new InvalidOperationException("El pedido ya ha sido cancelado.");

        }
        public void Recibido(Pedido pedido)
        {
            throw new InvalidOperationException("El pedido fue canelado");
        }
    }
}
