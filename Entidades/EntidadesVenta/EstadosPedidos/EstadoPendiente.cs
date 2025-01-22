using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesVenta.EstadosPedidos
{
    public class EstadoPendiente: IPedidoState
    {
        public void Confirmar(Pedido pedido)
        { 
           pedido.CambiarEstado(new EstadoConfirmado());            
        }

        public void Enviar(Pedido pedido)
        {
            throw new InvalidOperationException("No puedes enviar un pedido sin antes confirmarlo.");

        }
        public void Cancelar(Pedido pedido)
        {
            pedido.CambiarEstado(new EstadoCancelado());
        }
        public void Recibido(Pedido pedido)
        {
            throw new InvalidOperationException("El pedido todavia no fue confirmado");
        }
    }
}
