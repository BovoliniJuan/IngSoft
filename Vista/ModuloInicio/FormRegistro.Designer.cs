namespace Vista
{
    partial class FormRegistro
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
            txtNombreUsuario = new TextBox();
            txtContra = new TextBox();
            txtEmail = new TextBox();
            label = new Label();
            label1 = new Label();
            label2 = new Label();
            btnRegistrar = new Button();
            pnlVendedores = new Panel();
            txtTelEmpresa = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtNombreEmpresa = new TextBox();
            pnlClientes = new Panel();
            numTelefP = new NumericUpDown();
            label6 = new Label();
            chkVendedor = new CheckBox();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numDNI = new NumericUpDown();
            groupBox1 = new GroupBox();
            pnlVendedores.SuspendLayout();
            pnlClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTelefP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDNI).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(32, 47);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(195, 23);
            txtNombreUsuario.TabIndex = 0;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(32, 96);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(195, 23);
            txtContra.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(32, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 23);
            txtEmail.TabIndex = 2;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(32, 17);
            label.Name = "label";
            label.Size = new Size(128, 17);
            label.TabIndex = 3;
            label.Text = "Nombre de Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 78);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 4;
            label1.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 132);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(96, 437);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // pnlVendedores
            // 
            pnlVendedores.Controls.Add(txtTelEmpresa);
            pnlVendedores.Controls.Add(label8);
            pnlVendedores.Controls.Add(label7);
            pnlVendedores.Controls.Add(txtNombreEmpresa);
            pnlVendedores.Location = new Point(12, 325);
            pnlVendedores.Name = "pnlVendedores";
            pnlVendedores.Size = new Size(254, 108);
            pnlVendedores.TabIndex = 7;
            // 
            // txtTelEmpresa
            // 
            txtTelEmpresa.Location = new Point(24, 70);
            txtTelEmpresa.Name = "txtTelEmpresa";
            txtTelEmpresa.Size = new Size(195, 23);
            txtTelEmpresa.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(30, 52);
            label8.Name = "label8";
            label8.Size = new Size(152, 17);
            label8.TabIndex = 3;
            label8.Text = "Telefono de la Empresa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(27, 10);
            label7.Name = "label7";
            label7.Size = new Size(148, 17);
            label7.TabIndex = 2;
            label7.Text = "Nombre de la Empresa";
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.Location = new Point(27, 28);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.Size = new Size(196, 23);
            txtNombreEmpresa.TabIndex = 0;
            // 
            // pnlClientes
            // 
            pnlClientes.Controls.Add(numTelefP);
            pnlClientes.Controls.Add(label6);
            pnlClientes.Location = new Point(12, 325);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(254, 48);
            pnlClientes.TabIndex = 8;
            // 
            // numTelefP
            // 
            numTelefP.Location = new Point(24, 22);
            numTelefP.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numTelefP.Name = "numTelefP";
            numTelefP.Size = new Size(196, 23);
            numTelefP.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 4);
            label6.Name = "label6";
            label6.Size = new Size(62, 17);
            label6.TabIndex = 1;
            label6.Text = "Telefono";
            // 
            // chkVendedor
            // 
            chkVendedor.AutoSize = true;
            chkVendedor.Location = new Point(172, 16);
            chkVendedor.Name = "chkVendedor";
            chkVendedor.Size = new Size(76, 19);
            chkVendedor.TabIndex = 9;
            chkVendedor.Text = "Vendedor";
            chkVendedor.UseVisualStyleBackColor = true;
            chkVendedor.CheckedChanged += chkVendedor_CheckedChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(32, 199);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 23);
            txtNombre.TabIndex = 10;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(32, 246);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(195, 23);
            txtDireccion.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 179);
            label3.Name = "label3";
            label3.Size = new Size(125, 17);
            label3.TabIndex = 13;
            label3.Text = "Nombre y Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 225);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 14;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(32, 275);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 15;
            label5.Text = "DNI";
            // 
            // numDNI
            // 
            numDNI.Location = new Point(33, 293);
            numDNI.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numDNI.Name = "numDNI";
            numDNI.Size = new Size(194, 23);
            numDNI.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(txtNombreUsuario);
            groupBox1.Controls.Add(pnlClientes);
            groupBox1.Controls.Add(numDNI);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(pnlVendedores);
            groupBox1.Controls.Add(txtContra);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(chkVendedor);
            groupBox1.Location = new Point(2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 475);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(302, 484);
            Controls.Add(groupBox1);
            Name = "FormRegistro";
            Text = "Registro";
            pnlVendedores.ResumeLayout(false);
            pnlVendedores.PerformLayout();
            pnlClientes.ResumeLayout(false);
            pnlClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTelefP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDNI).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombreUsuario;
        private TextBox txtContra;
        private TextBox txtEmail;
        private Label label;
        private Label label1;
        private Label label2;
        private Button btnRegistrar;
        private Panel pnlVendedores;
        private Panel pnlClientes;
        private CheckBox chkVendedor;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private TextBox txtNombreEmpresa;
        private TextBox txtTelEmpresa;
        private NumericUpDown numTelefP;
        private NumericUpDown numDNI;
        private GroupBox groupBox1;
    }
}