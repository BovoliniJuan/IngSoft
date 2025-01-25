namespace Vista
{
    partial class FormVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendedores));
            toolHome = new ToolStrip();
            toolProductos = new ToolStripSplitButton();
            toolMisProductos = new ToolStripMenuItem();
            toolAgregarProd = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolPublicaciones = new ToolStripSplitButton();
            toolMisPublicaciones = new ToolStripMenuItem();
            toolAgregarPub = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolPedidos = new ToolStripButton();
            toolStripSplitButton1 = new ToolStripSplitButton();
            toolMiPerfil = new ToolStripMenuItem();
            toolCerrarSesion = new ToolStripMenuItem();
            label1 = new Label();
            toolStripSeparator3 = new ToolStripSeparator();
            toolReportes = new ToolStripButton();
            toolHome.SuspendLayout();
            SuspendLayout();
            // 
            // toolHome
            // 
            toolHome.BackColor = Color.Gray;
            toolHome.Items.AddRange(new ToolStripItem[] { toolProductos, toolStripSeparator1, toolPublicaciones, toolStripSeparator2, toolPedidos, toolStripSplitButton1, toolStripSeparator3, toolReportes });
            toolHome.Location = new Point(0, 0);
            toolHome.Name = "toolHome";
            toolHome.Size = new Size(800, 28);
            toolHome.TabIndex = 0;
            toolHome.Text = "toolStrip1";
            // 
            // toolProductos
            // 
            toolProductos.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolProductos.DropDownItems.AddRange(new ToolStripItem[] { toolMisProductos, toolAgregarProd });
            toolProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolProductos.Image = (Image)resources.GetObject("toolProductos.Image");
            toolProductos.ImageTransparentColor = Color.Magenta;
            toolProductos.Name = "toolProductos";
            toolProductos.Size = new Size(103, 25);
            toolProductos.Text = "Productos";
            // 
            // toolMisProductos
            // 
            toolMisProductos.Name = "toolMisProductos";
            toolMisProductos.Size = new Size(222, 26);
            toolMisProductos.Text = "Mis Productos";
            toolMisProductos.Click += toolMisProductos_Click;
            // 
            // toolAgregarProd
            // 
            toolAgregarProd.Name = "toolAgregarProd";
            toolAgregarProd.Size = new Size(222, 26);
            toolAgregarProd.Text = "Agregar Productos";
            toolAgregarProd.Click += toolAgregarProd_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // toolPublicaciones
            // 
            toolPublicaciones.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolPublicaciones.DropDownItems.AddRange(new ToolStripItem[] { toolMisPublicaciones, toolAgregarPub });
            toolPublicaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolPublicaciones.Image = (Image)resources.GetObject("toolPublicaciones.Image");
            toolPublicaciones.ImageTransparentColor = Color.Magenta;
            toolPublicaciones.Name = "toolPublicaciones";
            toolPublicaciones.Size = new Size(132, 25);
            toolPublicaciones.Text = "Publicaciones";
            // 
            // toolMisPublicaciones
            // 
            toolMisPublicaciones.Name = "toolMisPublicaciones";
            toolMisPublicaciones.Size = new Size(235, 26);
            toolMisPublicaciones.Text = "Mis publicaciones";
            toolMisPublicaciones.Click += toolMisPublicaciones_Click;
            // 
            // toolAgregarPub
            // 
            toolAgregarPub.Name = "toolAgregarPub";
            toolAgregarPub.Size = new Size(235, 26);
            toolAgregarPub.Text = "Agregar Publicacion";
            toolAgregarPub.Click += toolAgregarPub_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // toolPedidos
            // 
            toolPedidos.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolPedidos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolPedidos.Image = (Image)resources.GetObject("toolPedidos.Image");
            toolPedidos.ImageTransparentColor = Color.Magenta;
            toolPedidos.Name = "toolPedidos";
            toolPedidos.Size = new Size(75, 25);
            toolPedidos.Text = "Pedidos";
            toolPedidos.Click += toolPedidos_Click;
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { toolMiPerfil, toolCerrarSesion });
            toolStripSplitButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(32, 25);
            toolStripSplitButton1.Text = "Perfil";
            // 
            // toolMiPerfil
            // 
            toolMiPerfil.Name = "toolMiPerfil";
            toolMiPerfil.Size = new Size(157, 22);
            toolMiPerfil.Text = "Mi Perfil";
            toolMiPerfil.Click += toolMiPerfil_Click;
            // 
            // toolCerrarSesion
            // 
            toolCerrarSesion.Name = "toolCerrarSesion";
            toolCerrarSesion.Size = new Size(157, 22);
            toolCerrarSesion.Text = "Cerrar Sesion";
            toolCerrarSesion.Click += toolCerrarSesion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(219, 207);
            label1.Name = "label1";
            label1.Size = new Size(337, 37);
            label1.TabIndex = 1;
            label1.Text = "AgroGestion Vendedores";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 28);
            // 
            // toolReportes
            // 
            toolReportes.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolReportes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolReportes.Image = (Image)resources.GetObject("toolReportes.Image");
            toolReportes.ImageTransparentColor = Color.Magenta;
            toolReportes.Name = "toolReportes";
            toolReportes.Size = new Size(81, 25);
            toolReportes.Text = "Reportes";
            toolReportes.Click += toolReportes_Click;
            // 
            // FormVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(toolHome);
            Name = "FormVendedores";
            Text = "Home Vendedores";
            toolHome.ResumeLayout(false);
            toolHome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolHome;
        private ToolStripSplitButton toolProductos;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSplitButton toolPublicaciones;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolPedidos;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem toolMisProductos;
        private ToolStripMenuItem toolMisPublicaciones;
        private ToolStripMenuItem toolAgregarPub;
        private ToolStripMenuItem toolMiPerfil;
        private ToolStripMenuItem toolCerrarSesion;
        private ToolStripMenuItem toolAgregarProd;
        private Label label1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolReportes;
    }
}