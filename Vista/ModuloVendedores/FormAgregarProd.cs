using Controladoras.Seguridad;
using Controladoras.Vendedor;
using Entidades;
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
    public partial class FormAgregarProd : Form
    {
        private Sesion? _sesion;
        private Producto? producto;
        private bool modificar = false;

        public FormAgregarProd(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
        }
        public FormAgregarProd(Producto productoSeleccionado, Sesion sesion)
        {
            InitializeComponent();
            this.producto = productoSeleccionado;
            modificar = true;
            txtNombre.Text = producto.Nombre;
            txtDescripcion.Text = producto.Descripcion;
            numCantidad.Value = producto.Cantidad;
            txtPrecio.Text = producto.Precio.ToString();
            _sesion = sesion;
        }


        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) // Validar los datos del formulario
                return;

            var nombre = txtNombre.Text;
            var descripcion = txtDescripcion.Text;
            var cantidad = (int)numCantidad.Value;
            var precio = float.Parse(txtPrecio.Text);

            Producto producto = new Producto
            {
                Nombre = nombre,
                Descripcion = descripcion,
                Cantidad = cantidad,
                Precio = precio
            };

            string resultado;
            if (modificar)
            {
                producto.IdProducto = this.producto.IdProducto;
                resultado = ControladoraProductos.Instancia.ModificarProducto(producto,_sesion);
            }
            else
            {
                if (_sesion == null) // Verificar si la sesión es válida
                {
                    MessageBox.Show("Sesión no válida. No se puede agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                resultado = ControladoraProductos.Instancia.AgregarProducto(producto, _sesion);
            }

            MessageBox.Show(resultado, "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if ((int)numCantidad.Value == 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!float.TryParse(txtPrecio.Text, out float precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
