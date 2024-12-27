using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.EntidadesVendedores;

namespace Entidades
{
    public class Publicacion
    {
        private int idPublicacion;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private bool estado;
        private Producto producto;
        private Vendedor vendedor;

        [Key]
        public int IdPublicacion { get {  return idPublicacion; } set {  idPublicacion = value; } }
        public DateTime FechaInicio { get {  return fechaInicio; } set {  fechaInicio = value; } }
        public DateTime FechaFin { get {  return fechaFin; } set { fechaFin = value; } }
        public bool Estado { get { return estado; } set {  estado = value; } }
        public Producto Producto { get {  return producto; } set {  producto = value; } }
        public Vendedor Vendedor { get {  return vendedor; } set {  vendedor = value; } }
        public Publicacion() { }
        
        public void HabilitarPublicacion() { }
        public void AgregarProducto(Producto producto) {}
        public void EliminarProducto(Producto producto) { }
    }
}
