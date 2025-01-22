using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesVenta
{
    public interface IPedidoState
    {
        void Confirmar(Pedido pedido);
        void Enviar(Pedido pedido);
        void Cancelar(Pedido pedido);
        void Recibido (Pedido pedido);
    }
}
