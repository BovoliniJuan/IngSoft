using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;

namespace Entidades
{
    public class PermisoGrupo : PermisoComponent
    {
        private readonly List<PermisoComponent> permisos = new List<PermisoComponent>();

        public override bool TieneAcceso()
        {
            // Un grupo tiene acceso si al menos uno de sus permisos lo tiene
            return permisos.Any(p => p.TieneAcceso());
        }

        public override void Agregar(PermisoComponent permiso)
        {
            permisos.Add(permiso);
        }

        public override void Eliminar(PermisoComponent permiso)
        {
            permisos.Remove(permiso);
        }

        public override PermisoComponent Obtener(int index)
        {
            return permisos.ElementAtOrDefault(index);
        }
    }

}
