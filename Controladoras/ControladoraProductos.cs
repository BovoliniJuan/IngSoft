using Modelo;
using Entidades;
using System.Collections.ObjectModel;

namespace Controladoras
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
        public ReadOnlyCollection<Entidades.Producto> RecuperarProductos()
        {
            try
            {
                return new ReadOnlyCollection<Producto>(context.Productos.ToList());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar productos: " + ex.Message);
            }
        }

        public string AgregarProducto(Producto producto)
        {
            try
            {
                var listaProductos = context.Productos.ToList().AsReadOnly();
                var productoEncontrado = listaProductos.FirstOrDefault(x => x.IdProducto == producto.IdProducto);
                if (productoEncontrado == null)
                {
                    context.Productos.Add(producto);
                    context.SaveChanges();
                    return "La venta se agregó correctamente.";

                }
                return "La venta no se ha podido agregar.";
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
                var listaProductos = context.Productos.ToList().AsReadOnly();
                var productoEncontrado = listaProductos.FirstOrDefault(x => x.IdProducto == producto.IdProducto);
                if (productoEncontrado != null)
                {
                    context.Productos.Remove(producto);
                    context.SaveChanges();
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
                var listaProductos = context.Productos.ToList().AsReadOnly();
                var productoEncontrado = listaProductos.FirstOrDefault(x => x.IdProducto == producto.IdProducto);

                if (productoEncontrado != null)
                {
                    context.Productos.Update(producto);
                    int insertados = context.SaveChanges();

                    return $"El producto se modifico correctamente";
                }
                return $"El producto no se ha podido modificar";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el producto: " + ex.Message);
            }

        }
    }
}
