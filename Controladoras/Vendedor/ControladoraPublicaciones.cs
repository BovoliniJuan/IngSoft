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
                var publicacionesActivas = Context.Instancia.Publicaciones.Where(p => p.Estado == true).ToList();
                return new ReadOnlyCollection<Publicacion>(publicacionesActivas.AsReadOnly());
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
                    .Where(p => p.Producto.Nombre.Contains(nombreProducto) && p.Estado == true)
                    .ToList();

                return new ReadOnlyCollection<Publicacion>(publicacionesFiltradas.AsReadOnly());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar publicaciones: " + ex.Message);
            }
        }
        public bool GuardarPublicacion(Publicacion publicacion)
        {
            try
            {
                if (publicacion == null)
                {
                    throw new ArgumentNullException(nameof(publicacion), "La publicación no puede ser nula.");
                }

                Context.Instancia.Publicaciones.Add(publicacion); 
                Context.Instancia.SaveChanges(); 

                return true; 
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar la publicación: " + ex.Message);
            }
        }
        public int EliminarPublicacion(int idPublicacion)
        {
            try
            {
                // Buscar la publicación en el contexto
                var publicacion = Context.Instancia.Publicaciones.FirstOrDefault(p => p.IdPublicacion == idPublicacion);
                if (publicacion == null) throw new Exception("Publicación no encontrada.");

                // Obtener la cantidad de productos asociados a la publicación antes de eliminarla
                int cantidadDevuelta = publicacion.Cantidad;

                // Eliminar la publicación
                Context.Instancia.Publicaciones.Remove(publicacion);
                Context.Instancia.SaveChanges();

                // Devolver la cantidad de productos para actualizarlos en el stock
                return cantidadDevuelta;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la publicación: " + ex.Message);
            }
        }


        public bool ActualizarPublicacion(Publicacion publicacion)
        {
            try
            {
                var publicacionExistente = Context.Instancia.Publicaciones.FirstOrDefault(p => p.IdPublicacion == publicacion.IdPublicacion);
                if (publicacionExistente == null) throw new Exception("Publicación no encontrada.");

                // Actualizar propiedades
                publicacionExistente.Estado = publicacion.Estado;
                Context.Instancia.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la publicación: " + ex.Message);
            }
        }


    }
}
