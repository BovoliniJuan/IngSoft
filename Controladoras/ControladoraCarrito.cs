using Entidades.EntidadesClientes;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladoras
{
    public class ControladoraCarrito
    {
        private static ControladoraCarrito instancia;
        Context context;

        private ControladoraCarrito()
        {
            context = new Context();
        }

        public static ControladoraCarrito Instancia
        {

            get
            {
                if (instancia == null)
                    instancia = new ControladoraCarrito();
                return instancia;
            }
        }
        public ReadOnlyCollection<CarritoDeCompra> RecuperarCarrito()
        {
            try
            {
                return new ReadOnlyCollection<CarritoDeCompra>(context.CarritoDeCompras.ToList());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar productos: " + ex.Message);
            }
        }

        public void AgregarCarrito(CarritoDeCompra carritoDeCompra)
        {
            try
            {
                var listaCarritos = context.CarritoDeCompras.ToList().AsReadOnly();
                var carritoEncontrado = listaCarritos.FirstOrDefault(x => x.IdCarritoDeCompras == carritoDeCompra.IdCarritoDeCompras);
                if (carritoEncontrado == null)
                {
                    context.CarritoDeCompras.Add(carritoDeCompra);
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el carrito: " + ex.Message);
            }
        }

        public void EliminarCarrito(CarritoDeCompra carritoDeCompra)
        {
            try
            {
                var listaCarritos = context.CarritoDeCompras.ToList().AsReadOnly();
                var carritoEncontrado = listaCarritos.FirstOrDefault(x => x.IdCarritoDeCompras == carritoDeCompra.IdCarritoDeCompras);
                if (carritoEncontrado != null)
                {
                    context.CarritoDeCompras.Remove(carritoDeCompra);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el carrito: " + ex.Message);
            }
        }

        public string AgregarProductoCarrito(CarritoDeCompra carritoDeCompra)
        {
            try
            {
                var listaCarritos = context.CarritoDeCompras.ToList().AsReadOnly();
                var carritoEncontrado = listaCarritos.FirstOrDefault(x => x.IdCarritoDeCompras == carritoDeCompra.IdCarritoDeCompras);

                if (carritoEncontrado != null)
                {
                    context.CarritoDeCompras.Update(carritoDeCompra);
                    int insertados = context.SaveChanges();

                    return $"El producto se agrego correctamente";
                }
                return $"El producto no se ha podido agregar";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el producto: " + ex.Message);
            }

        }
    }
}
