using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        private int idGrupo;
        private string nombreGrupo;
        private Permisos permisos;

        [Key]
        public int IdGrupo {get { return idGrupo;} set { idGrupo = value; } }
        public string NombreGrupo { get { return nombreGrupo; }set {nombreGrupo = value; } }
        public Permisos Permisos { get { return permisos; } set { permisos = value; } }

        public Grupo() { }

        public void AgregarPermisos() { }
    }
}
