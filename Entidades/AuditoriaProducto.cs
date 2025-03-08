using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AuditoriaProducto
    {
        private int auditoriaId;
        private int productoId;
        private DateTime fecha_auditoria;
        private int usuarioId;
        private string tipoMovimiento;
        private string nombre_Producto;
        private string descripcion_Producto;
        private int cantidad_Producto;
        private string nombre_Usuario;

        [Key]
        public int AuditoriaId {  get { return auditoriaId; } set { auditoriaId = value; }}
        public int ProductoId { get { return productoId; } set {  productoId = value; } } 
        public int UsuarioId { get { return usuarioId; } set { usuarioId = value; } }
        public string NombreUsuario { get { return nombre_Usuario; }set { nombre_Usuario = value; } }
        public string NombreProducto { get { return nombre_Producto; } set { nombre_Producto = value; } }
        public string DescripcionProducto { get { return descripcion_Producto; } set {  descripcion_Producto = value; }}
        public int CantidadProducto { get { return cantidad_Producto; } set {  cantidad_Producto = value;} }
        public DateTime Fecha_Auditoria { get { return fecha_auditoria; } set { fecha_auditoria = value; } }
        public string TipoMovimiento { get { return tipoMovimiento; } set { tipoMovimiento = value; } }


    }
}
