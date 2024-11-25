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
        private PermisoGrupo permisos;

        [Key]
        public int IdGrupo {get { return idGrupo;} set { idGrupo = value; } }
        public string NombreGrupo { get { return nombreGrupo; }set {nombreGrupo = value; } }
        public PermisoGrupo Permisos { get; set; } = new PermisoGrupo();

        public Grupo() { }

        //public void AgregarPermisos() { }
    }
}
