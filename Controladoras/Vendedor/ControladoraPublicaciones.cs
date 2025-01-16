using Entidades.EntidadesVendedores;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladoras.Vendedor
{
    public class ControladoraPublicaciones
    {

        private static ControladoraPublicaciones instancia;
        Context context;

        private ControladoraPublicaciones()
        {
            context = new Context();
        }

        public static ControladoraPublicaciones Instancia
        {

            get
            {
                if (instancia == null)
                    instancia = new ControladoraPublicaciones();
                return instancia;
            }
        }
        public ReadOnlyCollection<Publicacion> RecuperarPublicaciones()
        {
            try
            {
                return new ReadOnlyCollection<Publicacion>(context.Publicaciones.ToList().AsReadOnly());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar productos: " + ex.Message);
            }
        }
        public ReadOnlyCollection<Publicacion> FiltrarPublicacionesPorNombre(string nombreProducto)
        {
            try
            {
                var publicacionesFiltradas = context.Publicaciones
                    .Where(p => p.Producto.Nombre.Contains(nombreProducto))
                    .ToList();

                return new ReadOnlyCollection<Publicacion>(publicacionesFiltradas.AsReadOnly());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar publicaciones: " + ex.Message);
            }
        }


    }
}
