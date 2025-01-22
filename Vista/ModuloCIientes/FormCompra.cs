using Controladoras.Cliente;
using Entidades.EntidadesVenta.EstadosPedidos;
using Entidades.EntidadesVenta;
using Entidades.Seguridad2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladoras.Seguridad;
using Entidades;
using Controladoras.Vendedor;
using Entidades.EntidadesClientes;

namespace Vista.ModuloCIientes
{
    public partial class FormCompra : Form
    {
        Sesion? _sesion;
        public FormCompra(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
            LlenarCmbox();
        }
        private void LlenarCmbox()
        {
            try
            {
                // Recuperar los productos del vendedor
                var metodos = ControladoraCarrito.Instancia.RecuperarMetodosPago();

               

                // Asignar los productos al combo box
                cmbMetodoPago.DataSource = metodos;
                cmbMetodoPago.DisplayMember = "Descripcion"; // Nombre del producto que se muestra en el combo box
                cmbMetodoPago.ValueMember = "IdMetodoDePago"; // ID del producto como valor interno del combo box
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al llenar el combo box: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var cliente = ControladoraCarrito.Instancia.ObtenerClientePorUsuario(_sesion.UsuarioSesion);

            if (cliente != null)
            {
                var carrito = ControladoraCarrito.Instancia.ObtenerCarritoActivo(cliente);

                if (carrito != null && carrito.Publicaciones != null && carrito.Publicaciones.Any())
                {
                    try
                    {
                        foreach (var publicacion in carrito.Publicaciones)
                        {

                            var referencia = int.Parse(txtReferencia.Text.Trim());

                            // Crear el objeto de pago
                            var pago = new Pago
                            {
                                FechaPago = DateTime.Now,
                                Monto = publicacion.Precio,
                                MetodoDePago = (MetodoDePago)cmbMetodoPago.SelectedItem,
                                EstadoPago = true,
                                Cliente = cliente,
                                ReferenciaTransaccion = referencia
                            };
                            var vendedor = ControladoraCarrito.Instancia.ObtenerVendedorPorId(publicacion.idVendedor);
                            if (vendedor == null)
                            {
                                throw new Exception("Vendedor no encontrado.");
                            }

                            var pedido = new Pedido
                            {
                                FechaPedido = DateTime.Now,
                                Cliente = cliente,
                                Publicacion = publicacion,
                                Total = publicacion.Precio,
                                Vendedor = vendedor,  // Asegurando que Vendedor sea un objeto válido
                                EstadoPedido = new EstadoPendiente(),
                                Pago = pago
                            };

                            pedido.Estado = "Pendiente";

                            // Marcar la publicación como no activa
                            publicacion.Estado = false;
                            publicacion.Vendido = true;

                            // Agregar el pedido a la controladora
                            ControladoraCarrito.Instancia.AgregarPedido(pedido,pago);
                        }

                        // Marcar el carrito como inactivo
                        carrito.Estado = false;
                        ControladoraCarrito.Instancia.ActualizarCarrito(carrito);

                        MessageBox.Show("La compra se ha confirmado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CrearCarrito();                      
                        // Cerrar el formulario
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al confirmar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El carrito está vacío o no tiene publicaciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se encontró el cliente asociado a esta sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CrearCarrito()
        {
            if (_sesion != null && _sesion.UsuarioSesion != null)
            {
                try
                {
                    var cliente = ControladoraCarrito.Instancia.ObtenerClientePorUsuario(_sesion.UsuarioSesion);

                    if (cliente != null)
                    {
                        var carritoExistente = ControladoraCarrito.Instancia.ObtenerCarritoActivo(cliente);

                        if (carritoExistente == null)
                        {
                            var nuevoCarrito = new CarritoDeCompra
                            {
                                Cliente = cliente,
                                FechaCreacion = DateTime.Now,
                                Total = 0,
                                Estado = true
                            };

                            ControladoraCarrito.Instancia.AgregarCarrito(nuevoCarrito);
                        }
                    }
                }
                catch
                {
                }
            }
        }
    }
}
