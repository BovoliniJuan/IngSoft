using Controladoras.Seguridad;
using Entidades;
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
using Vista.ModuloInicio;

namespace Vista.ModuloSeguridad
{
    public partial class FormAdministrador : Form
    {
        Sesion? _sesion;
        public FormAdministrador(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
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
            RegistrarAuditoriaSesion(_sesion.UsuarioSesion.IdUsuario, "Logout");
            FormInicioSesion formInicioSesion = new FormInicioSesion();
            formInicioSesion.Show();
        }

        private void toolAgregarGrupos_Click(object sender, EventArgs e)
        {
            FormCrearGrupos formCrear = new FormCrearGrupos();
            formCrear.ShowDialog();
        }

        private void toolGestionarGrupos_Click(object sender, EventArgs e)
        {
            FormGestionarGrupos formGestionarGrupos = new FormGestionarGrupos();
            formGestionarGrupos.ShowDialog();
        }
        private void RegistrarAuditoriaSesion(int usuarioId, string tipoMovimiento)
        {
            AuditoriaSesion auditoria = new AuditoriaSesion
            {
                UsuarioId = usuarioId,
                FechaMovimiento = DateTime.Now,
                TipoMovimiento = tipoMovimiento
            };

            // Aquí agregas la lógica para insertar la auditoría en la base de datos
            ControladoraInicioSesion.Instancia.Registrar(auditoria);
        }

        private void toolBackUp_Click(object sender, EventArgs e)
        {
            FormBackUp formBackUp = new FormBackUp();
            formBackUp.ShowDialog();
        }
    }
}
