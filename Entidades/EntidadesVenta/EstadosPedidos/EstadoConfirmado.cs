using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesVenta.EstadosPedidos
{
    public class EstadoConfirmado: IPedidoState
    {
        public void Confirmar(Pedido pedido)
        {
            throw new InvalidOperationException("El pedido ya ha sido confirmado.");

        }
        public void Enviar(Pedido pedido)
        {
            pedido.CambiarEstado(new EstadoEnProceso());
        }
        public void Cancelar(Pedido pedido)
        {
            throw new InvalidOperationException("El pedido ya ha sido confirmado.");

        }
    }
}
