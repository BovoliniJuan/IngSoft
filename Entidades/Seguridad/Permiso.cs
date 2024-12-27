using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;

namespace Entidades
{
    public class Permiso : PermisoComponent
    {
        private readonly bool acceso;

        public Permiso(string nombre, bool acceso)
        {
            Nombre = nombre;
            this.acceso = acceso;
        }

        public override bool TieneAcceso()
        {
            return acceso;
        }
    }

}
