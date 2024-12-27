using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Seguridad2
{
    public  class EstadoGrupo
    {
        private int estadoGrupoId;
        private string estadoGrupoNombre;


        [Key]
        public int EstadoGrupoId
        {
            get { return estadoGrupoId; }
            set { estadoGrupoId = value; }
        }

        public string EstadoGrupoNombre
        {
            get { return estadoGrupoNombre; }
            set { estadoGrupoNombre = value; }
        }


        public override string ToString()
        {
            return $"{EstadoGrupoNombre}";
        }
    }
}
