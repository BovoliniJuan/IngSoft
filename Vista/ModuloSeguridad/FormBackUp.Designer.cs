namespace Vista.ModuloSeguridad
{
    partial class FormBackUp
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
            btnCerrar = new Button();
            label2 = new Label();
            txtDirectorio = new TextBox();
            lblFecha = new Label();
            label1 = new Label();
            btnRestaurar = new Button();
            btnCrear = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(btnCerrar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDirectorio);
            groupBox1.Controls.Add(lblFecha);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnRestaurar);
            groupBox1.Controls.Add(btnCrear);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(561, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.Location = new Point(451, 369);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(87, 51);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 238);
            label2.Name = "label2";
            label2.Size = new Size(223, 21);
            label2.TabIndex = 5;
            label2.Text = "BackUp para la restauracion";
            // 
            // txtDirectorio
            // 
            txtDirectorio.Location = new Point(6, 270);
            txtDirectorio.Name = "txtDirectorio";
            txtDirectorio.Size = new Size(391, 23);
            txtDirectorio.TabIndex = 4;
            txtDirectorio.Click += txtDirectorio_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.Location = new Point(283, 40);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 21);
            lblFecha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(271, 21);
            label1.TabIndex = 2;
            label1.Text = "El ultimo Back Up fue realizado el:";
            // 
            // btnRestaurar
            // 
            btnRestaurar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestaurar.Location = new Point(202, 129);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(143, 57);
            btnRestaurar.TabIndex = 1;
            btnRestaurar.Text = "Restaurar Base de datos";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrear.Location = new Point(16, 129);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(143, 57);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear BackUp";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // FormBackUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormBackUp";
            Text = "FormBackUp";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRestaurar;
        private Button btnCrear;
        private Label label1;
        private Label lblFecha;
        private Label label2;
        private TextBox txtDirectorio;
        private Button btnCerrar;
    }
}