﻿using Controladoras.Seguridad;
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
            FormAgregarPubli formAgregarPubli = new FormAgregarPubli(_sesion);
            formAgregarPubli.ShowDialog();
        }

        private void toolPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos(_sesion);
            formPedidos.ShowDialog();
        }

        private void toolMiPerfil_Click(object sender, EventArgs e)
        {
            FormMiPerfil formMiPerfil = new FormMiPerfil(_sesion);
            formMiPerfil.ShowDialog();
        }

        private void toolCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistrarAuditoriaSesion(_sesion.UsuarioSesion.IdUsuario, "Logout", _sesion.UsuarioSesion.NombreUsuario);
            FormInicioSesion formInicioSesion = new FormInicioSesion();
            formInicioSesion.Show();
        }

        private void toolAgregarProd_Click(object sender, EventArgs e)
        {
            FormAgregarProd formAgregarProd = new FormAgregarProd(_sesion);
            formAgregarProd.ShowDialog();
        }

        private void toolReportes_Click(object sender, EventArgs e)
        {
            FormReportes formReportes = new FormReportes(_sesion);
            formReportes.ShowDialog();
        }
        private void RegistrarAuditoriaSesion(int usuarioId, string tipoMovimiento, string nombreUsuario)
        {
            AuditoriaSesion auditoria = new AuditoriaSesion
            {
                UsuarioId = usuarioId,
                NombreUsuario = nombreUsuario,
                FechaMovimiento = DateTime.Now,
                TipoMovimiento = tipoMovimiento
            };
            ControladoraInicioSesion.Instancia.Registrar(auditoria);
        }
    }
}
