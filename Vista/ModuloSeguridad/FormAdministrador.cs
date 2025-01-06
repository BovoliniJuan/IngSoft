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

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            FormCrearGrupos formCrearGrupos = new FormCrearGrupos();
            formCrearGrupos.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuariosTotales formUsuariosTotales = new FormUsuariosTotales();
            formUsuariosTotales.Show();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            FormGrupos formGrupos = new FormGrupos();
            formGrupos.Show();
        }
    }
}
