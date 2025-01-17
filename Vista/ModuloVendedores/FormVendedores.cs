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
using Vista.ModuloVendedores;

namespace Vista
{
    public partial class FormVendedores : Form
    {
        private Sesion? _sesion;
        public FormVendedores(Entidades.Seguridad2.Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
        }

        private void toolMisProductos_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos(_sesion);
            formProductos.ShowDialog();
        }

        private void toolMisPublicaciones_Click(object sender, EventArgs e)
        {
            FormMisPublicaciones formPublicacions = new FormMisPublicaciones(_sesion);   
            formPublicacions.ShowDialog();
        }

        private void toolAgregarPub_Click(object sender, EventArgs e)
        {
            FormAgregarPubli formAgregarPubli = new FormAgregarPubli();
            formAgregarPubli.ShowDialog();
        }

        private void toolPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.ShowDialog();
        }

        private void toolMiPerfil_Click(object sender, EventArgs e)
        {

        }

        private void toolCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicioSesion formInicioSesion = new FormInicioSesion();
            formInicioSesion.Show();
        }

        private void toolAgregarProd_Click(object sender, EventArgs e)
        {
            FormAgregarProd formAgregarProd = new FormAgregarProd(_sesion);
            formAgregarProd.ShowDialog();
        }
    }
}
