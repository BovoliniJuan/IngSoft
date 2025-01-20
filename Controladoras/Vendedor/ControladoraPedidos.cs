using Controladoras.Cliente;
using Entidades.EntidadesVendedores;
using Entidades.EntidadesVenta;
using Entidades.Seguridad2;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladoras.Vendedor
{
    public class ControladoraPedidos
    {
        private static ControladoraPedidos instancia;
        private List<Pedido> pedidos;

        private ControladoraPedidos()
        {
            pedidos = new List<Pedido>(); // Simula datos
        }

        public static ControladoraPedidos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraPedidos();
                }
                return instancia;
            }
        }

        public ReadOnlyCollection<Pedido> ObtenerPedidos(Sesion sesion)
        {
            try
            {
                var listaVendedores = Context.Instancia.Vendedores.ToList().AsReadOnly();
                var buscarVendedor = listaVendedores.FirstOrDefault(x => x.Usuario != null && x.Usuario.IdUsuario == sesion.UsuarioSesion.IdUsuario);
                
                if (buscarVendedor != null)
                {
                    var pedidosVendedor = Context.Instancia.Pedidos
                        .Include(p => p.Cliente) // Cargar cliente relacionado
                        .Include(p => p.Publicacion) // Cargar publicación relacionada
                        .Where(p => p.Vendedor != null && p.Vendedor.IdVendedor == buscarVendedor.IdVendedor)
                        .ToList();

                    return new ReadOnlyCollection<Pedido>(pedidosVendedor);
                }
                throw new Exception("No se encontró un vendedor asociado al usuario de la sesión.");

            }
            catch (Exception ex)
            {

                throw new Exception("Error al recuperar pedidos: " + ex.Message);
                
            }
        }
        public void ConfirmarPedido(Pedido pedido)
        {
            try
            {
                if (pedido.EstadoPedido == null)
                {
                    pedido.EstadoPedido = pedido.AsignarEstado(pedido.Estado);
                }

                pedido.ConfirmarPedido();

                Context.Instancia.Pedidos.Update(pedido);
                Context.Instancia.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al confirmar el pedido: " + ex.Message);
            }
        }

        public void CancelarPedido(Pedido pedido)
        {
            try
            {
                if (pedido.EstadoPedido == null)
                {
                    pedido.EstadoPedido = pedido.AsignarEstado(pedido.Estado);
                }

                pedido.CancelarPedido();

                Context.Instancia.Pedidos.Update(pedido);
                Context.Instancia.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cancelar el pedido: " + ex.Message);
            }
        }

        public void EnviarPedido(Pedido pedido)
        {
            try
            {
                if (pedido.EstadoPedido == null)
                {
                    pedido.EstadoPedido = pedido.AsignarEstado(pedido.Estado);
                }

                pedido.EnviarPedido();

                Context.Instancia.Pedidos.Update(pedido);
                Context.Instancia.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al enviar el pedido: " + ex.Message);
            }
        }
    }

}
