using Controladoras.Vendedor;
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

        public FormAgregarProd(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var nombre = txtNombre.Text;
            var descripcion = txtDescripcion.Text;
            var cantidad = (int)numCantidad.Value;
            var precio = float.Parse(txtPrecio.Text);
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("La descripcion es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cantidad == 0)
            {
                MessageBox.Show("La cantidad  es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (precio <= 0)
            {
                MessageBox.Show("El precio es obligatorio y debe ser mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Producto producto = new Producto();
            producto.Nombre = nombre;
            producto.Descripcion = descripcion;
            producto.Cantidad = cantidad;
            producto.Precio = precio;
            var resultado = ControladoraProductos.Instancia.AgregarProducto(producto, _sesion);
            MessageBox.Show(resultado, "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
