using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesVenta.EstadosPedidos
{
    public class EstadoEnProceso: IPedidoState
    {
        public void Confirmar(Pedido pedido)
        {
            throw new InvalidOperationException("No puedes confirmar un pedido enviado.");

        }
        public void Enviar(Pedido pedido)
        {
            throw new InvalidOperationException("El pedido ya fue enviado.");

        }
        public void Cancelar(Pedido pedido)
        {
            throw new InvalidOperationException("No puedes cancelar un pedido enviado.");

        }
    }
}
