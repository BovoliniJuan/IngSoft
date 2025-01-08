using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades.EntidadesVendedores
{
    public class Producto
    {
        private int idProducto;
        private string nombre;
        private string descripcion;
        private float precio;
        private int cantidad;
        private Vendedor vendedor;

        [Key]
        public int IdProducto {get { return idProducto;} set { idProducto = value; } }
        public string Nombre { get {  return nombre; } set {  nombre = value; } }
        public string Descripcion { get {  return descripcion; } set {  descripcion = value; } }
        public int Cantidad { get { return cantidad; }set { cantidad = value; } }
        public float Precio { get {  return precio; } set {  precio = value; } }
        public int VendedorIdPersona { get; set; }

        public Vendedor Vendedor { get {  return vendedor; } set {  vendedor = value; } }
        public Producto() { }




    }
}
