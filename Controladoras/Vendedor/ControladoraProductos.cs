using Modelo;
using Entidades;
using System.Collections.ObjectModel;
using Entidades.EntidadesVendedores;
using Entidades.Seguridad2;

namespace Controladoras.Vendedor
{
    public class ControladoraProductos
    {
        private static ControladoraProductos instancia;
        Context context;

        private ControladoraProductos()
        {
            context = new Context();
        }

        public static ControladoraProductos Instancia
        {

            get
            {
                if (instancia == null)
                    instancia = new ControladoraProductos();
                return instancia;
            }
        }
        public ReadOnlyCollection<Producto> RecuperarProductos()
        {
            try
            {
                return new ReadOnlyCollection<Producto>(Context.Instancia.Productos.ToList());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar productos: " + ex.Message);
            }
        }
        public ReadOnlyCollection<Producto> RecuperarProductosVendedor(Sesion sesion)
        {
            try
            {
                // Buscar el vendedor asociado al usuario de la sesión
                var buscarVendedor = Context.Instancia.Vendedores
                    .FirstOrDefault(v => v.Usuario.IdUsuario == sesion.UsuarioSesion.IdUsuario);

                if (buscarVendedor != null)
                {
                    // Filtrar los productos del vendedor
                    var productosVendedor = Context.Instancia.Productos
                        .Where(p => p.Vendedor.IdVendedor == buscarVendedor.IdVendedor)
                        .ToList();

                    // Retornar los productos como ReadOnlyCollection
                    return new ReadOnlyCollection<Producto>(productosVendedor);
                }

                throw new Exception("No se encontró un vendedor asociado al usuario de la sesión.");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar productos: " + ex.Message);
            }
        }

        public string AgregarProducto(Producto producto, Sesion sesion)
        {
            try
            {
                var listaProductos = Context.Instancia.Productos.ToList().AsReadOnly();
                var productoEncontrado = listaProductos.FirstOrDefault(x => x.IdProducto == producto.IdProducto);
                if (productoEncontrado == null)
                {
                    var listaVendedores = Context.Instancia.Vendedores.ToList().AsReadOnly();
                    var buscarVendedor = listaVendedores.FirstOrDefault(x => x.Usuario == sesion.UsuarioSesion);

                    if (buscarVendedor != null)
                    {
                        producto.Vendedor = buscarVendedor;
                        Context.Instancia.Productos.Add(producto);
                        Context.Instancia.SaveChanges();
                        return "El producto se agregó correctamente.";
                    }
                    

                }
                return "El producto no se ha podido agregar.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el producto: " + ex.Message);
            }
        }
       
        public string EliminarProducto(Producto producto)
        {
            try
            {
                var listaProductos = Context.Instancia.Productos.ToList().AsReadOnly();
                var productoEncontrado = listaProductos.FirstOrDefault(x => x.IdProducto == producto.IdProducto);
                if (productoEncontrado != null)
                {
                    Context.Instancia.Productos.Remove(producto);
                    Context.Instancia.SaveChanges();
                    return $"El producto se elimino correctamente";
                }
                return $"El producto no se pudo eliminar correctamente";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el producto: " + ex.Message);
            }
        }

       
        public string ModificarProducto(Producto producto)
        {
            try
            {
                var productoEncontrado = Context.Instancia.Productos.FirstOrDefault(x => x.IdProducto == producto.IdProducto);

                if (productoEncontrado != null)
                {
                    productoEncontrado.Nombre = producto.Nombre;
                    productoEncontrado.Descripcion = producto.Descripcion;
                    productoEncontrado.Cantidad = producto.Cantidad;
                    productoEncontrado.Precio = producto.Precio;

                    int cambios = Context.Instancia.SaveChanges();

                    return cambios > 0 ? "El producto se modificó correctamente" : "No se realizaron cambios en el producto";
                }

                return "No se encontró el producto a modificar";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el producto: " + ex.Message);
            }
        }

    }
}
