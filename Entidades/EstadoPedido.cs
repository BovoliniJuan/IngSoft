using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstadoPedido
    {
        private int idEstadoPedido;
        private string descripcion;

        [Key]
        public int IdEstadoPedido { get {  return idEstadoPedido; } set {  idEstadoPedido = value; }}
        public string Descripcion { get {  return descripcion; } set {  descripcion = value; } }

        public EstadoPedido() { }

    }
}
