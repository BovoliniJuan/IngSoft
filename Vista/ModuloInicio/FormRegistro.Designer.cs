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
            btnRegistrar.Location = new Point(67, 220);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 291);
            Controls.Add(btnRegistrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label);
            Controls.Add(txtEmail);
            Controls.Add(txtContra);
            Controls.Add(txtNombreUsuario);
            Name = "FormRegistro";
            Text = "FormRegistro";
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
    }
}