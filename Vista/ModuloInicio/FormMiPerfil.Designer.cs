namespace Vista.ModuloInicio
{
    partial class FormMiPerfil
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
            groupBox1 = new GroupBox();
            btnCambiarContra = new Button();
            btnCerrar = new Button();
            dgvMiPerfil = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMiPerfil).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(btnCambiarContra);
            groupBox1.Controls.Add(btnCerrar);
            groupBox1.Controls.Add(dgvMiPerfil);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnCambiarContra
            // 
            btnCambiarContra.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCambiarContra.Location = new Point(99, 191);
            btnCambiarContra.Name = "btnCambiarContra";
            btnCambiarContra.Size = new Size(110, 44);
            btnCambiarContra.TabIndex = 2;
            btnCambiarContra.Text = "Cambiar Contraseña";
            btnCambiarContra.UseVisualStyleBackColor = true;
            btnCambiarContra.Click += btnCambiarContra_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.Location = new Point(6, 191);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(77, 44);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dgvMiPerfil
            // 
            dgvMiPerfil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMiPerfil.Location = new Point(6, 13);
            dgvMiPerfil.Name = "dgvMiPerfil";
            dgvMiPerfil.RowTemplate.Height = 25;
            dgvMiPerfil.Size = new Size(399, 150);
            dgvMiPerfil.TabIndex = 0;
            // 
            // FormMiPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormMiPerfil";
            Text = "Mi Perfil";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMiPerfil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCerrar;
        private DataGridView dgvMiPerfil;
        private Button btnCambiarContra;
    }
}