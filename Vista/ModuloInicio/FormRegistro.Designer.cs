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
            label8 = new Label();
            label7 = new Label();
            txtNombreEmpresa = new TextBox();
            pnlClientes = new Panel();
            label6 = new Label();
            chkVendedor = new CheckBox();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTelPerso = new TextBox();
            txtTelEmpresa = new TextBox();
            txtDni = new TextBox();
            pnlVendedores.SuspendLayout();
            pnlClientes.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(64, 68);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(195, 23);
            txtNombreUsuario.TabIndex = 0;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(64, 117);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(195, 23);
            txtContra.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(64, 171);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 23);
            txtEmail.TabIndex = 2;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(64, 38);
            label.Name = "label";
            label.Size = new Size(110, 15);
            label.TabIndex = 3;
            label.Text = "Nombre de Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 99);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 4;
            label1.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 153);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(99, 461);
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
            pnlVendedores.Location = new Point(39, 343);
            pnlVendedores.Name = "pnlVendedores";
            pnlVendedores.Size = new Size(291, 101);
            pnlVendedores.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 52);
            label8.Name = "label8";
            label8.Size = new Size(128, 15);
            label8.TabIndex = 3;
            label8.Text = "Telefono de la Empresa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 10);
            label7.Name = "label7";
            label7.Size = new Size(127, 15);
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
            pnlClientes.Controls.Add(txtTelPerso);
            pnlClientes.Controls.Add(label6);
            pnlClientes.Location = new Point(39, 354);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(282, 48);
            pnlClientes.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 4);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 1;
            label6.Text = "Telefono";
            // 
            // chkVendedor
            // 
            chkVendedor.AutoSize = true;
            chkVendedor.Location = new Point(204, 37);
            chkVendedor.Name = "chkVendedor";
            chkVendedor.Size = new Size(76, 19);
            chkVendedor.TabIndex = 9;
            chkVendedor.Text = "Vendedor";
            chkVendedor.UseVisualStyleBackColor = true;
            chkVendedor.CheckedChanged += chkVendedor_CheckedChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(64, 220);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 23);
            txtNombre.TabIndex = 10;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(64, 267);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(195, 23);
            txtDireccion.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 200);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 13;
            label3.Text = "Nombre y Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 246);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 14;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 296);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 15;
            label5.Text = "DNI";
            // 
            // txtTelPerso
            // 
            txtTelPerso.Location = new Point(24, 22);
            txtTelPerso.Name = "txtTelPerso";
            txtTelPerso.Size = new Size(196, 23);
            txtTelPerso.TabIndex = 2;
            // 
            // txtTelEmpresa
            // 
            txtTelEmpresa.Location = new Point(24, 70);
            txtTelEmpresa.Name = "txtTelEmpresa";
            txtTelEmpresa.Size = new Size(195, 23);
            txtTelEmpresa.TabIndex = 4;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(63, 314);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(195, 23);
            txtDni.TabIndex = 16;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 512);
            Controls.Add(txtDni);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(chkVendedor);
            Controls.Add(pnlClientes);
            Controls.Add(pnlVendedores);
            Controls.Add(btnRegistrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label);
            Controls.Add(txtEmail);
            Controls.Add(txtContra);
            Controls.Add(txtNombreUsuario);
            Name = "FormRegistro";
            Text = "FormRegistro";
            pnlVendedores.ResumeLayout(false);
            pnlVendedores.PerformLayout();
            pnlClientes.ResumeLayout(false);
            pnlClientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtTelPerso;
        private TextBox txtTelEmpresa;
        private TextBox txtDni;
    }
}