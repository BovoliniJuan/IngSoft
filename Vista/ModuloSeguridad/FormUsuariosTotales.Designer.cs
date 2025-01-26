namespace Vista.ModuloSeguridad
{
    partial class FormUsuariosTotales
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
            dgvUsuarios = new DataGridView();
            groupBox1 = new GroupBox();
            chkClientes = new CheckBox();
            chkVendedores = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 12);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(560, 342);
            dgvUsuarios.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(chkClientes);
            groupBox1.Controls.Add(chkVendedores);
            groupBox1.Location = new Point(578, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(167, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // chkClientes
            // 
            chkClientes.AutoSize = true;
            chkClientes.Location = new Point(6, 47);
            chkClientes.Name = "chkClientes";
            chkClientes.Size = new Size(68, 19);
            chkClientes.TabIndex = 1;
            chkClientes.Text = "Clientes";
            chkClientes.UseVisualStyleBackColor = true;
            chkClientes.CheckedChanged += chkClientes_CheckedChanged;
            // 
            // chkVendedores
            // 
            chkVendedores.AutoSize = true;
            chkVendedores.Location = new Point(6, 22);
            chkVendedores.Name = "chkVendedores";
            chkVendedores.Size = new Size(87, 19);
            chkVendedores.TabIndex = 0;
            chkVendedores.Text = "Vendedores";
            chkVendedores.UseVisualStyleBackColor = true;
            chkVendedores.CheckedChanged += chkVendedores_CheckedChanged;
            // 
            // FormUsuariosTotales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(757, 379);
            Controls.Add(groupBox1);
            Controls.Add(dgvUsuarios);
            Name = "FormUsuariosTotales";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuarios;
        private GroupBox groupBox1;
        private CheckBox chkClientes;
        private CheckBox chkVendedores;
    }
}