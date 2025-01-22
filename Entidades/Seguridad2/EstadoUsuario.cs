using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Seguridad
{
    public class EstadoUsuario
    {
        private int estadoUsuarioId;
        private string estadoUsuarioNombre;


        public int EstadoUsuarioId
        {
            get { return estadoUsuarioId; }
            set { estadoUsuarioId = value; }
        }

        public string EstadoUsuarioNombre
        {
            get { return estadoUsuarioNombre; }
            set { estadoUsuarioNombre = value; }
        }

        public override string ToString()
        {
            return $"{EstadoUsuarioNombre}";
        }
    }
}
