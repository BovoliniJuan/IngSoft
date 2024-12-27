using Controladoras;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.ModuloInicio
{
    public partial class FormRecuperarClave : Form
    {
        private readonly ControladoraSeguridad _controladoraSeguridad;

        private FormInicioSesion formInicioSesion;
        public FormRecuperarClave(FormInicioSesion formInicioSesion)
        {
            InitializeComponent();
            this.formInicioSesion = formInicioSesion;
            _controladoraSeguridad = new ControladoraSeguridad(Context.Instancia);
        }
    }
}
