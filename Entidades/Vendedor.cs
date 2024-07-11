using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor : Usuario
    {
        public Vendedor() { }
        private int idVendedor;
        private string nombreEmpresa;
        private int telefonoEmpresa;

        [Key]
        public int IdVendedor {  get { return idVendedor; } set { idVendedor = value; } }
        public string NombreEmpresa { get {  return nombreEmpresa; } set {  nombreEmpresa = value; }}
        public int TelefonoEmpresa { get { return telefonoEmpresa; } private set {  telefonoEmpresa = value;} }

    }
}
