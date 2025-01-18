using Controladoras.Cliente;
using Entidades.EntidadesClientes;
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
using Vista.ModuloCIientes;
using Vista.ModuloInicio;

namespace Vista
{
    public partial class FormClientes : Form
    {
        Sesion? _sesion;
        public FormClientes(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
            CrearCarrito();
        }

        private void toolPublicaciones_Click(object sender, EventArgs e)
        {
            FormPublicaciones formPublicaciones = new FormPublicaciones(_sesion);
            formPublicaciones.ShowDialog();
        }

        private void toolMiPerfil_Click(object sender, EventArgs e)
        {
            FormMiPerfil formMiPerfil = new FormMiPerfil(_sesion);
            formMiPerfil.ShowDialog();
        }

        private void toolCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicioSesion formInicioSesion = new FormInicioSesion();
            formInicioSesion.Show();
        }

        private void toolCarrito_Click(object sender, EventArgs e)
        {
            FormMiCarrito formMiCarrito = new FormMiCarrito(_sesion);
            formMiCarrito.ShowDialog();
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
