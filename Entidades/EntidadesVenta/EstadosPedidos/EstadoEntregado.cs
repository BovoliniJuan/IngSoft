using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesVenta.EstadosPedidos
{
    public class EstadoEntregado: IPedidoState
    {
        public void Confirmar(Pedido pedido)
        {
            throw new InvalidOperationException("No puedes confirmar un pedido entregado.");

        }
        public void Enviar(Pedido pedido)
        {
            throw new InvalidOperationException("No puedes enviar un pedido entregado.");

        }
        public void Cancelar(Pedido pedido)
        {
            throw new InvalidOperationException("No puedes cancelar un pedido entregado.");

        }
        public void Recibido(Pedido pedido)
        {
            throw new InvalidOperationException("El pedido ya fue recibido");
        }
    }
}
