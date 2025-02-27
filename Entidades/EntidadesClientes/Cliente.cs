using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.EntidadesVenta;

namespace Entidades.EntidadesClientes
{
    public class Cliente : Persona
    {
        public Cliente() { }

        private int idCliente;
        private long telefono;
        private List<Pago> pagos;

        [Key]
        public int IdCliente { get { return idCliente; } set { idCliente = value ; } }
        public long Telefono { get { return telefono; } set { telefono = value ; } }
        public ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    }
}
