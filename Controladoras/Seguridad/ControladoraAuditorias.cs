using Entidades;
using Entidades.Seguridad2;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladoras.Seguridad
{
    public class ControladoraAuditorias
    {
        private static ControladoraAuditorias instancia;


        public static ControladoraAuditorias Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraAuditorias();
                }
                return instancia;
            }
        }

        public ControladoraAuditorias() { }

       

        public ReadOnlyCollection<AuditoriaSesion> RecuperarAuditoriasSesiones()
        {
            try
            {
                return Context.Instancia.AuditoriasSesiones.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public ReadOnlyCollection<AuditoriaProducto> RecuperarAuditoriasProductos()
        {
            try
            {
                return Context.Instancia.AuditoriasProductos.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

