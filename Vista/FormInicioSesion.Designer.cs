
namespace Vista
{
    partial class FormInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciar = new Button();
            label1 = new Label();
            linkRegistro = new LinkLabel();
            label2 = new Label();
            txtboxUsuario = new TextBox();
            txtboxContra = new TextBox();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(78, 187);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(92, 29);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar Sesion";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 26);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // linkRegistro
            // 
            linkRegistro.AutoSize = true;
            linkRegistro.Location = new Point(97, 245);
            linkRegistro.Name = "linkRegistro";
            linkRegistro.Size = new Size(64, 15);
            linkRegistro.TabIndex = 3;
            linkRegistro.TabStop = true;
            linkRegistro.Text = "Registrarse";
            linkRegistro.LinkClicked += linkRegistro_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 105);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // txtboxUsuario
            // 
            txtboxUsuario.Location = new Point(78, 63);
            txtboxUsuario.Name = "txtboxUsuario";
            txtboxUsuario.Size = new Size(100, 23);
            txtboxUsuario.TabIndex = 5;
            // 
            // txtboxContra
            // 
            txtboxContra.Location = new Point(78, 136);
            txtboxContra.Name = "txtboxContra";
            txtboxContra.Size = new Size(100, 23);
            txtboxContra.TabIndex = 6;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 300);
            Controls.Add(txtboxContra);
            Controls.Add(txtboxUsuario);
            Controls.Add(label2);
            Controls.Add(linkRegistro);
            Controls.Add(label1);
            Controls.Add(btnIniciar);
            Name = "InicioSesion";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnIniciar;
        private Label label1;
        private LinkLabel linkRegistro;
        private Label label2;
        private TextBox txtboxUsuario;
        private TextBox txtboxContra;
    }
}
