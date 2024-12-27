using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Seguridad2
{
    public class Formulario
    {
        public int formularioId;
        public string nombreFormulario;
        public Modulo modulo;
        public List<Accion> accionesPosibles;



        public int FormularioId
        {
            get { return formularioId; }
            set { formularioId = value; }
        }

        public string NombreFormulario
        {
            get { return nombreFormulario; }
            set { nombreFormulario = value; }
        }

        public Modulo Modulo
        {
            get { return modulo; }
            set { modulo = value; }
        }

        public List<Accion> AccionesPosibles
        {
            get { return accionesPosibles; }
            set { accionesPosibles = value; }
        }

        public Formulario()
        {
            accionesPosibles = new List<Accion>();
        }
    }
}
