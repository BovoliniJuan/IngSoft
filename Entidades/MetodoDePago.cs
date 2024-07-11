using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MetodoDePago
    {
        private int idMetodoDePago;
        private string descripcion;

        [Key]
        public int IdMetodoDePago { get {  return idMetodoDePago; } set {  idMetodoDePago = value; } }
        public string Descripcion { get {  return descripcion; } set {  descripcion = value; } }

        public MetodoDePago() { }
    }
}
