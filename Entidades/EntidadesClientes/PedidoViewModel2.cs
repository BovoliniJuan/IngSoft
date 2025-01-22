using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesClientes
{
    public class PedidoViewModel2
    {
        public DateTime FechaPedido { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string NombreEmpresa { get; set; }
        public string DescripcionPublicacion { get; set; }
        public string Estado { get; set; }
        public float Total { get; set; }
    }
}
