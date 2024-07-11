using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Usuario
    {
        public Cliente() { }
        
        private int idCliente;
        private string nombreCompleto;
        private int telefono;

        [Key]
        public int IdCliente {  get { return idCliente; } set { } }
        public string NombreCompleto { get {  return nombreCompleto; } set {  nombreCompleto = value; } }
        public int Telefono { get { return telefono; } }

        public void VerCarrito() { }
        public void RealizarPedido() { }

    }
}
