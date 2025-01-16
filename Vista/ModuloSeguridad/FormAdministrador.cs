using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.ModuloInicio;

namespace Vista.ModuloSeguridad
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }



        private void toolGrupos_Click(object sender, EventArgs e)
        {
            FormGrupos formGrupos = new FormGrupos();
            formGrupos.ShowDialog();
        }

        private void toolUsuariosTotales_Click(object sender, EventArgs e)
        {
            FormUsuariosTotales formUsuariosTotales = new FormUsuariosTotales();
            formUsuariosTotales.ShowDialog();
        }

        private void toolCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicioSesion formInicioSesion = new FormInicioSesion();
            formInicioSesion.Show();
        }

     
    }
}
