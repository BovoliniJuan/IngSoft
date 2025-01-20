using Controladoras.Vendedor;
using Entidades.EntidadesClientes;
using Entidades.EntidadesVendedores;
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

namespace Vista.ModuloVendedores
{
    public partial class FormAgregarPubli : Form
    {
        Sesion? _sesion;
        public FormAgregarPubli(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
            LlenarCombox();
        }
     
        private void LlenarCombox()
        {
            try
            {
                // Recuperar los productos del vendedor
                var productosVendedor = ControladoraProductos.Instancia.RecuperarProductosVendedor(_sesion);

                if (productosVendedor == null || !productosVendedor.Any())
                {
                    MessageBox.Show("El vendedor no tiene productos disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Asignar los productos al combo box
                cmbProducto.DataSource = productosVendedor;
                cmbProducto.DisplayMember = "Nombre"; // Nombre del producto que se muestra en el combo box
                cmbProducto.ValueMember = "IdProducto"; // ID del producto como valor interno del combo box
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al llenar el combo box: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {            
                try
                {
                    // Validar campos obligatorios
                    if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                    {
                        MessageBox.Show("Debe ingresar una descripción para la publicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (cmbProducto.SelectedItem == null)
                    {
                        MessageBox.Show("Debe seleccionar un producto para la publicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (dateInicio.Value >= dateFin.Value)
                    {
                        MessageBox.Show("La fecha de inicio debe ser anterior a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var descripcion = txtDescripcion.Text.Trim();
                    DateTime fechaInicio = dateInicio.Value;
                    DateTime fechaFin = dateFin.Value;
                    var producto = cmbProducto.SelectedItem as Producto;
                    var cantidad = (int)numCantidad.Value;

                    if (producto.Cantidad < cantidad)
                    {
                        MessageBox.Show($"La cantidad solicitada ({cantidad}) excede el stock disponible del producto ({producto.Cantidad}).",
                                        "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var precio = producto.Precio * cantidad;

                    var nuevaPublicacion = new Publicacion
                    {
                        Descripcion = descripcion,
                        FechaInicio = fechaInicio,
                        FechaFin = fechaFin,
                        Producto = producto,
                        Cantidad = cantidad,
                        Precio = precio,
                        Estado = true, // habilitar la publicación
                        Vendedor = producto.Vendedor, 
                        IdProducto = producto.IdProducto,
                        Vendido = false 
                    };

                    var resultado = ControladoraPublicaciones.Instancia.GuardarPublicacion(nuevaPublicacion);

                    // Reducir el stock del producto
                    producto.Cantidad -= cantidad;
                    ControladoraProductos.Instancia.ActualizarProducto(producto);

                    if (resultado)
                    {
                        MessageBox.Show("Publicación creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Error al crear la publicación. Inténtelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
