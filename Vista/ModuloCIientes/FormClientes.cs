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

namespace Vista
{
    public partial class FormClientes : Form
    {
        public FormClientes(Sesion sesion)
        {
            InitializeComponent();
        }

        private void toolPublicaciones_Click(object sender, EventArgs e)
        {

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
    }
}
