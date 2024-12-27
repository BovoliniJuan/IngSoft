using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class PermisoComponent
    {
        private int id;
        private string nombre;
        [Key]
        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }

        public abstract bool TieneAcceso();

        public virtual void Agregar(PermisoComponent permiso) { }
        public virtual void Eliminar(PermisoComponent permiso) { }
        public virtual PermisoComponent Obtener(int index) => null;
    }
}
