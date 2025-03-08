namespace Vista.ModuloSeguridad
{
    partial class FormAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrador));
            toolStrip1 = new ToolStrip();
            toolUsuarios = new ToolStripSplitButton();
            toolGrupos = new ToolStripMenuItem();
            toolUsuariosTotales = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolCrearGrupos = new ToolStripSplitButton();
            toolAgregarGrupos = new ToolStripMenuItem();
            toolGestionarGrupos = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolPerfil = new ToolStripSplitButton();
            toolCerrarSesion = new ToolStripMenuItem();
            toolBackUp = new ToolStripButton();
            label1 = new Label();
            toolStripSeparator3 = new ToolStripSeparator();
            toolAuditorias = new ToolStripSplitButton();
            toolAudSesion = new ToolStripMenuItem();
            toolAudProductos = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(64, 64, 64);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolUsuarios, toolStripSeparator1, toolCrearGrupos, toolStripSeparator2, toolPerfil, toolBackUp, toolStripSeparator3, toolAuditorias });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(445, 28);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolUsuarios
            // 
            toolUsuarios.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolUsuarios.DropDownItems.AddRange(new ToolStripItem[] { toolGrupos, toolUsuariosTotales });
            toolUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolUsuarios.Image = (Image)resources.GetObject("toolUsuarios.Image");
            toolUsuarios.ImageTransparentColor = Color.Magenta;
            toolUsuarios.Name = "toolUsuarios";
            toolUsuarios.Size = new Size(92, 25);
            toolUsuarios.Text = "Usuarios";
            // 
            // toolGrupos
            // 
            toolGrupos.Name = "toolGrupos";
            toolGrupos.Size = new Size(196, 26);
            toolGrupos.Text = "Asignar Grupos";
            toolGrupos.Click += toolGrupos_Click;
            // 
            // toolUsuariosTotales
            // 
            toolUsuariosTotales.Name = "toolUsuariosTotales";
            toolUsuariosTotales.Size = new Size(196, 26);
            toolUsuariosTotales.Text = "Ver Usuarios";
            toolUsuariosTotales.Click += toolUsuariosTotales_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // toolCrearGrupos
            // 
            toolCrearGrupos.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolCrearGrupos.DropDownItems.AddRange(new ToolStripItem[] { toolAgregarGrupos, toolGestionarGrupos });
            toolCrearGrupos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolCrearGrupos.Image = (Image)resources.GetObject("toolCrearGrupos.Image");
            toolCrearGrupos.ImageTransparentColor = Color.Magenta;
            toolCrearGrupos.Name = "toolCrearGrupos";
            toolCrearGrupos.Size = new Size(80, 25);
            toolCrearGrupos.Text = "Grupos";
            // 
            // toolAgregarGrupos
            // 
            toolAgregarGrupos.Name = "toolAgregarGrupos";
            toolAgregarGrupos.Size = new Size(198, 26);
            toolAgregarGrupos.Text = "Agregar grupos";
            toolAgregarGrupos.Click += toolAgregarGrupos_Click;
            // 
            // toolGestionarGrupos
            // 
            toolGestionarGrupos.Name = "toolGestionarGrupos";
            toolGestionarGrupos.Size = new Size(198, 26);
            toolGestionarGrupos.Text = "Gestion grupos";
            toolGestionarGrupos.Click += toolGestionarGrupos_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // toolPerfil
            // 
            toolPerfil.Alignment = ToolStripItemAlignment.Right;
            toolPerfil.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolPerfil.DropDownItems.AddRange(new ToolStripItem[] { toolCerrarSesion });
            toolPerfil.Image = (Image)resources.GetObject("toolPerfil.Image");
            toolPerfil.ImageTransparentColor = Color.Magenta;
            toolPerfil.Name = "toolPerfil";
            toolPerfil.Size = new Size(32, 25);
            toolPerfil.Text = "toolStripSplitButton1";
            toolPerfil.ToolTipText = "Perfil";
            // 
            // toolCerrarSesion
            // 
            toolCerrarSesion.Name = "toolCerrarSesion";
            toolCerrarSesion.Size = new Size(143, 22);
            toolCerrarSesion.Text = "Cerrar Sesion";
            toolCerrarSesion.Click += toolCerrarSesion_Click;
            // 
            // toolBackUp
            // 
            toolBackUp.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolBackUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolBackUp.Image = (Image)resources.GetObject("toolBackUp.Image");
            toolBackUp.ImageTransparentColor = Color.Magenta;
            toolBackUp.Name = "toolBackUp";
            toolBackUp.Size = new Size(79, 25);
            toolBackUp.Text = "BackUps";
            toolBackUp.Click += toolBackUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(60, 141);
            label1.Name = "label1";
            label1.Size = new Size(259, 25);
            label1.TabIndex = 4;
            label1.Text = "AgroGestion Administrador";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 28);
            // 
            // toolAuditorias
            // 
            toolAuditorias.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolAuditorias.DropDownItems.AddRange(new ToolStripItem[] { toolAudSesion, toolAudProductos });
            toolAuditorias.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolAuditorias.Image = (Image)resources.GetObject("toolAuditorias.Image");
            toolAuditorias.ImageTransparentColor = Color.Magenta;
            toolAuditorias.Name = "toolAuditorias";
            toolAuditorias.Size = new Size(105, 25);
            toolAuditorias.Text = "Auditorias";
            // 
            // toolAudSesion
            // 
            toolAudSesion.Name = "toolAudSesion";
            toolAudSesion.Size = new Size(180, 26);
            toolAudSesion.Text = "Sesiones";
            toolAudSesion.Click += toolAudSesion_Click;
            // 
            // toolAudProductos
            // 
            toolAudProductos.Name = "toolAudProductos";
            toolAudProductos.Size = new Size(180, 26);
            toolAudProductos.Text = "Productos";
            toolAudProductos.Click += toolAudProductos_Click;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(445, 301);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "FormAdministrador";
            Text = "Adminstrador";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolUsuarios;
        private ToolStripMenuItem toolGrupos;
        private ToolStripMenuItem toolUsuariosTotales;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSplitButton toolCrearGrupos;
        private ToolStripSplitButton toolPerfil;
        private Label label1;
        private ToolStripMenuItem toolCerrarSesion;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolAgregarGrupos;
        private ToolStripMenuItem toolGestionarGrupos;
        private ToolStripButton toolBackUp;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSplitButton toolAuditorias;
        private ToolStripMenuItem toolAudSesion;
        private ToolStripMenuItem toolAudProductos;
    }
}