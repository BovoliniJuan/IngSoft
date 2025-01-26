namespace Vista.ModuloInicio
{
    partial class FormRecuperarClave
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
            panel2 = new Panel();
            btnCambiarContra = new Button();
            label4 = new Label();
            label3 = new Label();
            txtConfirmarContrasenia = new TextBox();
            txtNuevaContrasenia = new TextBox();
            panel1 = new Panel();
            btnValidarCodigo = new Button();
            txtCodigo = new TextBox();
            label2 = new Label();
            btnEnviarCodigo = new Button();
            label1 = new Label();
            txtEmail = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCambiarContra);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtConfirmarContrasenia);
            panel2.Controls.Add(txtNuevaContrasenia);
            panel2.Location = new Point(23, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 170);
            panel2.TabIndex = 0;
            // 
            // btnCambiarContra
            // 
            btnCambiarContra.Location = new Point(36, 131);
            btnCambiarContra.Name = "btnCambiarContra";
            btnCambiarContra.Size = new Size(75, 23);
            btnCambiarContra.TabIndex = 4;
            btnCambiarContra.Text = "Confirmar";
            btnCambiarContra.UseVisualStyleBackColor = true;
            btnCambiarContra.Click += btnCambiarContra_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 69);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 3;
            label4.Text = "Confirme su contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 8);
            label3.Name = "label3";
            label3.Size = new Size(156, 15);
            label3.TabIndex = 2;
            label3.Text = "Ingrese su nueva contraseña";
            // 
            // txtConfirmarContrasenia
            // 
            txtConfirmarContrasenia.Location = new Point(36, 87);
            txtConfirmarContrasenia.Name = "txtConfirmarContrasenia";
            txtConfirmarContrasenia.Size = new Size(156, 23);
            txtConfirmarContrasenia.TabIndex = 1;
            // 
            // txtNuevaContrasenia
            // 
            txtNuevaContrasenia.Location = new Point(36, 26);
            txtNuevaContrasenia.Name = "txtNuevaContrasenia";
            txtNuevaContrasenia.Size = new Size(156, 23);
            txtNuevaContrasenia.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(btnValidarCodigo);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnEnviarCodigo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtEmail);
            panel1.Location = new Point(23, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 170);
            panel1.TabIndex = 1;
            // 
            // btnValidarCodigo
            // 
            btnValidarCodigo.Location = new Point(37, 132);
            btnValidarCodigo.Name = "btnValidarCodigo";
            btnValidarCodigo.Size = new Size(99, 23);
            btnValidarCodigo.TabIndex = 5;
            btnValidarCodigo.Text = "Validar codigo";
            btnValidarCodigo.UseVisualStyleBackColor = true;
            btnValidarCodigo.Click += btnValidarCodigo_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(37, 103);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(209, 23);
            txtCodigo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 85);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingrese el codigo";
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.Location = new Point(38, 58);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(100, 23);
            btnEnviarCodigo.TabIndex = 2;
            btnEnviarCodigo.Text = "Enviar codigo";
            btnEnviarCodigo.UseVisualStyleBackColor = true;
            btnEnviarCodigo.Click += btnEnviarCodigo_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 11);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese su Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(38, 29);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(208, 23);
            txtEmail.TabIndex = 0;
            // 
            // FormRecuperarClave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(349, 231);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormRecuperarClave";
            Text = "Recuperacion de Clave";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private TextBox txtEmail;
        private Button btnEnviarCodigo;
        private Label label1;
        private Label label2;
        private TextBox txtCodigo;
        private Button btnValidarCodigo;
        private TextBox txtConfirmarContrasenia;
        private TextBox txtNuevaContrasenia;
        private Label label4;
        private Label label3;
        private Button btnCambiarContra;
    }
}