using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesVendedores
{
    public class PedidoViewModel
    {
        public DateTime FechaPedido { get; set; }
        public string NombreCliente { get; set; }
        public string DescripcionPublicacion { get; set; }
        public string Estado { get; set; }
        public float Total { get; set; }
    }

}
