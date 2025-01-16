namespace Vista
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            toolStrip1 = new ToolStrip();
            toolPerfil = new ToolStripSplitButton();
            toolMiPerfil = new ToolStripMenuItem();
            toolCerrarSesion = new ToolStripMenuItem();
            toolCarrito = new ToolStripButton();
            toolPublicaciones = new ToolStripButton();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(64, 64, 64);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolPerfil, toolCarrito, toolPublicaciones });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolPerfil
            // 
            toolPerfil.Alignment = ToolStripItemAlignment.Right;
            toolPerfil.BackColor = Color.Lime;
            toolPerfil.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolPerfil.DropDownItems.AddRange(new ToolStripItem[] { toolMiPerfil, toolCerrarSesion });
            toolPerfil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolPerfil.Image = (Image)resources.GetObject("toolPerfil.Image");
            toolPerfil.ImageTransparentColor = Color.Magenta;
            toolPerfil.Name = "toolPerfil";
            toolPerfil.Size = new Size(32, 25);
            toolPerfil.Text = "toolStripSplitButton1";
            // 
            // toolMiPerfil
            // 
            toolMiPerfil.Name = "toolMiPerfil";
            toolMiPerfil.Size = new Size(174, 26);
            toolMiPerfil.Text = "Mi perfil";
            toolMiPerfil.Click += toolMiPerfil_Click;
            // 
            // toolCerrarSesion
            // 
            toolCerrarSesion.Name = "toolCerrarSesion";
            toolCerrarSesion.Size = new Size(174, 26);
            toolCerrarSesion.Text = "Cerrar Sesion";
            toolCerrarSesion.Click += toolCerrarSesion_Click;
            // 
            // toolCarrito
            // 
            toolCarrito.Alignment = ToolStripItemAlignment.Right;
            toolCarrito.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolCarrito.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolCarrito.Image = (Image)resources.GetObject("toolCarrito.Image");
            toolCarrito.ImageTransparentColor = Color.Magenta;
            toolCarrito.Name = "toolCarrito";
            toolCarrito.Size = new Size(23, 25);
            toolCarrito.Text = "toolStripButton1";
            // 
            // toolPublicaciones
            // 
            toolPublicaciones.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolPublicaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolPublicaciones.Image = (Image)resources.GetObject("toolPublicaciones.Image");
            toolPublicaciones.ImageTransparentColor = Color.Magenta;
            toolPublicaciones.Name = "toolPublicaciones";
            toolPublicaciones.Size = new Size(120, 25);
            toolPublicaciones.Text = "Publicaciones";
            toolPublicaciones.Click += toolPublicaciones_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(242, 193);
            label1.Name = "label1";
            label1.Size = new Size(288, 37);
            label1.TabIndex = 2;
            label1.Text = "AgroGestion Clientes";
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "FormClientes";
            Text = "Home Clientes";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolPerfil;
        private ToolStripMenuItem toolMiPerfil;
        private ToolStripMenuItem toolCerrarSesion;
        private ToolStripButton toolCarrito;
        private ToolStripButton toolPublicaciones;
        private Label label1;
    }
}