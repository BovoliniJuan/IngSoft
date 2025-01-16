using Controladoras.Administrador;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.ModuloSeguridad
{
    public partial class FormUsuariosTotales : Form
    {

        public FormUsuariosTotales()
        {
            InitializeComponent();
            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
            // Cargar todos los usuarios inicialmente
            var usuarios = ControladoraAdministrador.Instancia.ObtenerTodosLosUsuarios();
            dgvUsuarios.DataSource = usuarios.Select(u => new
            {
                u.IdUsuario,
                u.NombreUsuario,
                u.Email,
                TieneGrupo = u.Componentes.OfType<Grupo>().Any()? "Sí" : "No"
            }).ToList();
        }

        private void chkVendedores_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void chkClientes_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }
       

        private void AplicarFiltros()
        {
            // Obtener todos los usuarios
            var usuarios = ControladoraAdministrador.Instancia.ObtenerTodosLosUsuarios();

            // Filtrar usuarios según los CheckBoxes
            if (chkVendedores.Checked && !chkClientes.Checked)
            {
                usuarios = usuarios.Where(u =>
                    u.Componentes.OfType<Grupo>().Any(g => g.IdGrupo == 3)
                ).ToList();
               
            }
            else if (!chkVendedores.Checked && chkClientes.Checked)
            {
                usuarios = usuarios.Where(u =>
                    u.Componentes.OfType<Grupo>().Any(g => g.IdGrupo == 2)
                ).ToList();
              
            }
            else if (chkVendedores.Checked && chkClientes.Checked)
            {
                usuarios = usuarios.Where(u =>
                    u.Componentes.OfType<Grupo>().Any(g => g.IdGrupo == 3 || g.IdGrupo == 2)
                ).ToList();
            }

            // Actualizar el DataGridView
            dgvUsuarios.DataSource = usuarios.Select(u => new
            {
                u.IdUsuario,
                u.NombreUsuario,
                u.Email,
                TieneGrupo = u.Componentes.OfType<Grupo>().Any() ? "Sí" : "No"
            }).ToList();
        }
    }
}
