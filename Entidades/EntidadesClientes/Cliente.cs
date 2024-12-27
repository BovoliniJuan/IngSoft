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
        private string nombreCompleto;
        private int telefono;
        private List<Pago> pagos;
        [Key]
        public int IdCliente { get { return idCliente; } set { } }
        public string NombreCompleto { get { return nombreCompleto; } set { nombreCompleto = value; } }
        public int Telefono { get { return telefono; } }
        public ICollection<Pago> Pagos { get; set; } = new List<Pago>();

        public void VerCarrito() { }
        public void RealizarPedido() { }
        public void AgregarPago() { }
    }
}
