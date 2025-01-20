namespace Vista.ModuloCIientes
{
    partial class FormCompra
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
            label2 = new Label();
            label1 = new Label();
            txtReferencia = new TextBox();
            cmbMetodoPago = new ComboBox();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtReferencia);
            groupBox1.Controls.Add(cmbMetodoPago);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnConfirmar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 221);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(182, 17);
            label2.TabIndex = 5;
            label2.Text = "Referencia de la Transaccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 15);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 4;
            label1.Text = "Metodo de Pago";
            // 
            // txtReferencia
            // 
            txtReferencia.Location = new Point(28, 94);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(121, 23);
            txtReferencia.TabIndex = 3;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(28, 36);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(121, 23);
            cmbMetodoPago.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(105, 156);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 38);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.Location = new Point(12, 156);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(78, 38);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FormCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(223, 244);
            Controls.Add(groupBox1);
            Name = "FormCompra";
            Text = "Confirmar Compra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnConfirmar;
        private TextBox txtReferencia;
        private ComboBox cmbMetodoPago;
        private Label label2;
        private Label label1;
    }
}