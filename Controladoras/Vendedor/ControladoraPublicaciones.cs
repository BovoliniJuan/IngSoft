using Entidades.EntidadesVendedores;
using Entidades.Seguridad2;
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

        private ControladoraPublicaciones()
        {
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
        public ReadOnlyCollection<Publicacion> RecuperarPublicacionesVendedor(Sesion sesion)
        {
            try
            {
                var listaVendedores = Context.Instancia.Vendedores.ToList().AsReadOnly();
                var buscarVendedor = listaVendedores.FirstOrDefault(x => x.Usuario != null && x.Usuario.IdUsuario == sesion.UsuarioSesion.IdUsuario);

                if (buscarVendedor != null)
                {
                    var productosVendedor = Context.Instancia.Publicaciones
                        .Where(p => p.Vendedor != null && p.Vendedor.IdVendedor == buscarVendedor.IdVendedor)
                        .ToList();

                    return new ReadOnlyCollection<Publicacion>(productosVendedor);
                }

                throw new Exception("No se encontró un vendedor asociado al usuario de la sesión.");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar publicaciones: " + ex.Message);
            }
        }

        public ReadOnlyCollection<Publicacion> RecuperarPublicaciones()
        {
            try
            {
                return new ReadOnlyCollection<Publicacion>(Context.Instancia.Publicaciones.ToList().AsReadOnly());
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
                var publicacionesFiltradas = Context.Instancia.Publicaciones
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
