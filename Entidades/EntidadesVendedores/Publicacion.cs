using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.EntidadesVenta;

namespace Entidades.EntidadesVendedores
{
    public class Publicacion
    {
        private int idPublicacion;
        private string descripcion;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private bool estado;
        private Producto producto;
        private Vendedor vendedor;
        private int cantidad;
        private float precio;
        public bool vendido;


        [Key]
        public int IdPublicacion { get {  return idPublicacion; } set {  idPublicacion = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public DateTime FechaInicio { get {  return fechaInicio; } set {  fechaInicio = value; } }
        public DateTime FechaFin { get {  return fechaFin; } set { fechaFin = value; } }
        public bool Estado { get { return estado; } set {  estado = value; } }
        public int IdProducto { get; set; }
        public Producto Producto { get {  return producto; } set {  producto = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public float Precio { get { return precio; } set { precio = value; } }
        public int idVendedor { get; set; }
        public Vendedor Vendedor { get {  return vendedor; } set {  vendedor = value; } }
        
        public bool Vendido { get { return vendido; } set { vendido = value; } }
        public Publicacion() { }
        
      
    }
}
