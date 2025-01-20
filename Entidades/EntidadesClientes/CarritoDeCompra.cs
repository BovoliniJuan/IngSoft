using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.EntidadesVendedores;

namespace Entidades.EntidadesClientes
{
    public class CarritoDeCompra
    {
        private int idCarritoDeCompra;
        private DateTime fechaCreacion;
        private Cliente cliente;
        private float total;
        private bool estado;
        private List<Publicacion> publicaciones;

        [Key]
        public int IdCarritoDeCompras { get { return idCarritoDeCompra; } set { idCarritoDeCompra = value; } }
        public DateTime FechaCreacion { get { return fechaCreacion; } set { fechaCreacion = value; } }
        public Cliente Cliente { get { return cliente; } set { cliente = value; } }
        public float Total { get { return total; } set { total = value; } }
        public bool Estado { get { return estado; } set { estado = value; } }
        public ICollection<Publicacion> Publicaciones { get; set; } = new List<Publicacion>();

        public CarritoDeCompra() { }


    }
}
