using Entidades;
using Entidades.EntidadesClientes;
using Entidades.EntidadesVenta;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladoras.Cliente
{
    public class ControladoraCarrito
    {
        private static ControladoraCarrito instancia;

        private ControladoraCarrito()
        {
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
        public ReadOnlyCollection<MetodoDePago> RecuperarMetodosPago()
        {
            try
            {
                return new ReadOnlyCollection<MetodoDePago>(Context.Instancia.MetodoDePagos.ToList());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar metodos de pago: " + ex.Message);
            }
        }
        public Entidades.EntidadesClientes.Cliente ObtenerClientePorUsuario(Usuario usuario)
        {
            try
            {
                return Context.Instancia.Clientes.FirstOrDefault(c => c.Usuario.IdUsuario == usuario.IdUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el cliente: " + ex.Message);
            }
        }
        public CarritoDeCompra ObtenerCarritoPorCliente(Entidades.EntidadesClientes.Cliente cliente)
        {
            try
            {
                return Context.Instancia.CarritoDeCompras.FirstOrDefault(c => c.Cliente.IdCliente == cliente.IdCliente && c.Estado == true);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el carrito: " + ex.Message);
            }
        }
        public CarritoDeCompra ObtenerCarritoActivo(Entidades.EntidadesClientes.Cliente cliente)
        {
            try
            {
                return Context.Instancia.CarritoDeCompras
                    .FirstOrDefault(c => c.Cliente.IdCliente == cliente.IdCliente && c.Estado == true);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el carrito activo: " + ex.Message);
            }
        }
        public Entidades.EntidadesVendedores.Vendedor ObtenerVendedorPorId(int idVendedor)
        {
            try
            {
                var vendedor = Context.Instancia.Vendedores.FirstOrDefault(v => v.IdVendedor == idVendedor);
                if (vendedor == null)
                {
                    throw new Exception($"No se encontró un vendedor con el Id {idVendedor}");
                }
                return vendedor;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el vendedor por Id: {ex.Message}");
            }
        }
        public ReadOnlyCollection<CarritoDeCompra> RecuperarCarrito()
        {
            try
            {
                return new ReadOnlyCollection<CarritoDeCompra>(Context.Instancia.CarritoDeCompras.ToList());
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
                var listaCarritos = Context.Instancia.CarritoDeCompras.ToList().AsReadOnly();
                var carritoEncontrado = listaCarritos.FirstOrDefault(x => x.IdCarritoDeCompras == carritoDeCompra.IdCarritoDeCompras);
                if (carritoEncontrado == null)
                {
                    Context.Instancia.CarritoDeCompras.Add(carritoDeCompra);
                    Context.Instancia.SaveChanges();

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
                var listaCarritos = Context.Instancia.CarritoDeCompras.ToList().AsReadOnly();
                var carritoEncontrado = listaCarritos.FirstOrDefault(x => x.IdCarritoDeCompras == carritoDeCompra.IdCarritoDeCompras);
                if (carritoEncontrado != null)
                {
                    Context.Instancia.CarritoDeCompras.Remove(carritoDeCompra);
                    Context.Instancia.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el carrito: " + ex.Message);
            }
        }

        public string ActualizarCarrito(CarritoDeCompra carritoDeCompra)
        {
            try
            {
                var listaCarritos = Context.Instancia.CarritoDeCompras.ToList().AsReadOnly();
                var carritoEncontrado = listaCarritos.FirstOrDefault(x => x.IdCarritoDeCompras == carritoDeCompra.IdCarritoDeCompras);

                if (carritoEncontrado != null)
                {
                    Context.Instancia.CarritoDeCompras.Update(carritoDeCompra);
                    int insertados = Context.Instancia.SaveChanges();

                    return $"El carrito se actualizo correctamente";
                }
                return $"El carrito no se ha podido actualizar";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizo el carrito: " + ex.Message);
            }

        }
        public void AgregarPedido(Pedido pedido, Pago pago)
        {
            try
            {                
               Context.Instancia.Pedidos.Add(pedido);
               Context.Instancia.Pagos.Add(pago);
               Context.Instancia.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el pedido: " + ex.Message);
            }
        }

    }
}
