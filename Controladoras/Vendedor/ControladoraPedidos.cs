using Controladoras.Cliente;
using Controladoras.Mensajeria;
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
        public ReadOnlyCollection<Pedido> ObtenerPedidosClientes(Sesion sesion)
        {
            try
            {
                var listaClientes = Context.Instancia.Clientes.ToList().AsReadOnly();
                var buscarCliente = listaClientes.FirstOrDefault(x => x.Usuario != null && x.Usuario.IdUsuario == sesion.UsuarioSesion.IdUsuario);

                if (buscarCliente != null)
                {
                    var pedidosCliente = Context.Instancia.Pedidos
                        .Include(p => p.Vendedor)
                        .Include(p => p.Cliente) 
                        .Include(p => p.Publicacion) 
                        .Where(p => p.Cliente != null && p.Cliente.IdCliente == buscarCliente.IdCliente)
                        .ToList();

                    return new ReadOnlyCollection<Pedido>(pedidosCliente);
                }
                throw new Exception("No se encontró un vendedor asociado al usuario de la sesión.");

            }
            catch (Exception ex)
            {

                throw new Exception("Error al recuperar pedidos: " + ex.Message);

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
                        .Include(p=> p.Vendedor)
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
        public void CancelarPedido2(Pedido pedido)
        {
            try
            {
                if (pedido.EstadoPedido == null)
                {
                    pedido.EstadoPedido = pedido.AsignarEstado(pedido.Estado);
                }

                pedido.CancelarPedido();

                var publicacion = Context.Instancia.Publicaciones
                    .FirstOrDefault(p => p.IdPublicacion == pedido.Publicacion.IdPublicacion); 

                if (publicacion != null)
                {
                    publicacion.Estado = true;
                    publicacion.Vendido = false;
                    Context.Instancia.Publicaciones.Update(publicacion);
                }

                // Actualizar el pedido
                Context.Instancia.Pedidos.Update(pedido);

                // Guardar cambios
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

                // Guardar cambios en la base de datos
                Context.Instancia.Pedidos.Update(pedido);
                Context.Instancia.SaveChanges();

                // Enviar notificación al cliente
                if (pedido.Cliente != null && !string.IsNullOrEmpty(pedido.Cliente.Usuario.Email))
                {
                    var email = pedido.Cliente.Usuario.Email;
                    var nombreCliente = pedido.Cliente.NombreCompleto;
                    var mensaje = $@"
                    <div style='font-family: Arial, sans-serif; color: #333;'>
                    <h2 style='color: #2e7d32;'>Pedido Enviado</h2>
                    <p>Hola <b>{nombreCliente}</b>,</p>
                    <p>Nos complace informarte que tu pedido:</p>
                    <p style='font-size: 18px; font-weight: bold; color: #2e7d32;'>{pedido.Publicacion.Descripcion}</p>
                    <p>ha sido enviado con éxito.</p>
                    <p>Gracias por elegir nuestros servicios.</p>
                    <p style='color: #2e7d32;'>Equipo AgroGestion</p>
                    </div>";

                    ControladoraMails.Instancia.EnviarCorreo(email, "Notificación de Envío de Pedido", mensaje, true);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al enviar el pedido: " + ex.Message);
            }
        }

        public void RecibirPedido(Pedido pedido)
        {
            try
            {
                if (pedido.EstadoPedido == null)
                {
                    pedido.EstadoPedido = pedido.AsignarEstado(pedido.Estado);
                }

                pedido.RecibirPedido();
                pedido.FechaEntrega = DateTime.Now;

                Context.Instancia.Pedidos.Update(pedido);
                Context.Instancia.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recibir el pedido: " + ex.Message);
            }
        }
        public ReadOnlyCollection<Pedido> FiltrarPedidossPorNombre(string nombrePedido)
        {
            try
            {
                var pedidosFiltrados = Context.Instancia.Pedidos
                    .Where(p => p.Publicacion.Descripcion.Contains(nombrePedido) )
                    .ToList();

                return new ReadOnlyCollection<Pedido>(pedidosFiltrados.AsReadOnly());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar publicaciones: " + ex.Message);
            }
        }

    }

}
