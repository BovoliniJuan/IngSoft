using Entidades.Seguridad2;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo:Componente
    {
        private int idGrupo;
        private string nombreGrupo;
        private EstadoGrupo estadoGrupo;
        private List<Componente> componentes;

     
        public int IdGrupo {get { return idGrupo;} set { idGrupo = value; } }
        public string NombreGrupo { get { return nombreGrupo; }set {nombreGrupo = value; } }

        public EstadoGrupo EstadoGrupo
        {
            get { return estadoGrupo; }
            set { estadoGrupo = value; }
        }




        public List<Componente> Componentes
        {
            get { return componentes; }
            set { componentes = value; }
        }

        public List<Accion> Acciones
        {
            get
            {
                var acciones = new List<Accion>();
                foreach (var componente in Componentes)
                {
                    if (componente is Accion accion)
                    {
                        acciones.Add(accion);
                    }
                    else if (componente is Grupo grupo)
                    {
                        acciones.AddRange(grupo.Acciones);
                    }
                }
                return acciones;
            }
        }

        public Grupo()
        {
            componentes = new List<Componente>();
            Usuarios = new List<Usuario>();
            Grupos = new List<Grupo>();
        }


        public override void Agregar(Componente componente)
        {
            componentes.Add(componente);
        }

        public override void Eliminar(Componente componente)
        {
            componentes.Remove(componente);
        }

        public override List<Componente> RecuperarHijos()
        {
            return componentes.ToList();
        }


        public override string ToString()
        {
            return $"{Nombre}";
        }


    }
}
