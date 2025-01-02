
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
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            linkOlvidarContra = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(66, 171);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(92, 29);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Aceptar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 34);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // linkRegistro
            // 
            linkRegistro.AutoSize = true;
            linkRegistro.Location = new Point(66, 235);
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
            label2.Location = new Point(17, 87);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // txtboxUsuario
            // 
            txtboxUsuario.Location = new Point(161, 34);
            txtboxUsuario.Name = "txtboxUsuario";
            txtboxUsuario.Size = new Size(214, 23);
            txtboxUsuario.TabIndex = 5;
            // 
            // txtboxContra
            // 
            txtboxContra.Location = new Point(161, 87);
            txtboxContra.Name = "txtboxContra";
            txtboxContra.Size = new Size(214, 23);
            txtboxContra.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(linkOlvidarContra);
            groupBox1.Controls.Add(txtboxContra);
            groupBox1.Controls.Add(btnIniciar);
            groupBox1.Controls.Add(txtboxUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(linkRegistro);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 276);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(225, 171);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 29);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // linkOlvidarContra
            // 
            linkOlvidarContra.AutoSize = true;
            linkOlvidarContra.Location = new Point(161, 137);
            linkOlvidarContra.Name = "linkOlvidarContra";
            linkOlvidarContra.Size = new Size(119, 15);
            linkOlvidarContra.TabIndex = 7;
            linkOlvidarContra.TabStop = true;
            linkOlvidarContra.Text = "Olvide mi contraseña";
            linkOlvidarContra.LinkClicked += linkOlvidarContra_LinkClicked;
            // 
            // FormInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 300);
            Controls.Add(groupBox1);
            Name = "FormInicioSesion";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private Button btnIniciar;
        private Label label1;
        private LinkLabel linkRegistro;
        private Label label2;
        private TextBox txtboxUsuario;
        private TextBox txtboxContra;
        private GroupBox groupBox1;
        private LinkLabel linkOlvidarContra;
        private Button btnCancelar;
    }
}
