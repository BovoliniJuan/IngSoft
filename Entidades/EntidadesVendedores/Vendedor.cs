using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesVendedores
{
    public class Vendedor : Persona
    {
        //private int idVendedor;
        private string nombreEmpresa;
        private long telefonoEmpresa;
        private List<Producto> productos;

        //public int IdVendedor {  get { return idVendedor; } set { idVendedor = value; } }
        public string NombreEmpresa { get {  return nombreEmpresa; } set {  nombreEmpresa = value; }}
        public long TelefonoEmpresa { get { return telefonoEmpresa; }  set {  telefonoEmpresa = value;} }
        public List<Producto> Productos { get {  return productos; } set {  productos = value; } }
        
        public Vendedor() { }
        public void AgregarProductos() {}
    }
}
