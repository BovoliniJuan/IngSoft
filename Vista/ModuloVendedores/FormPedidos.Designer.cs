namespace Vista.ModuloVendedores
{
    partial class FormPedidos
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
            dgvPedidos = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnSalir = new Button();
            btnEnviar = new Button();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            chkPendiente = new CheckBox();
            chkConfirmado = new CheckBox();
            chkEnviado = new CheckBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(dgvPedidos);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 381);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(0, 9);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowTemplate.Height = 25;
            dgvPedidos.Size = new Size(475, 366);
            dgvPedidos.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gray;
            groupBox2.Controls.Add(chkEnviado);
            groupBox2.Controls.Add(chkConfirmado);
            groupBox2.Controls.Add(chkPendiente);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(504, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 140);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtros";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Gray;
            groupBox3.Controls.Add(btnSalir);
            groupBox3.Controls.Add(btnEnviar);
            groupBox3.Controls.Add(btnCancelar);
            groupBox3.Controls.Add(btnConfirmar);
            groupBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(504, 173);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(284, 220);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Controles";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(203, 181);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 33);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(6, 162);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(108, 52);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar pedido";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(6, 95);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 52);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar pedido";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(6, 26);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(108, 52);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar pedido";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // chkPendiente
            // 
            chkPendiente.AutoSize = true;
            chkPendiente.Location = new Point(11, 26);
            chkPendiente.Name = "chkPendiente";
            chkPendiente.Size = new Size(98, 24);
            chkPendiente.TabIndex = 0;
            chkPendiente.Text = "Pendiente";
            chkPendiente.UseVisualStyleBackColor = true;
            chkPendiente.CheckedChanged += chkPendiente_CheckedChanged;
            // 
            // chkConfirmado
            // 
            chkConfirmado.AutoSize = true;
            chkConfirmado.Location = new Point(11, 56);
            chkConfirmado.Name = "chkConfirmado";
            chkConfirmado.Size = new Size(111, 24);
            chkConfirmado.TabIndex = 1;
            chkConfirmado.Text = "Confirmado";
            chkConfirmado.UseVisualStyleBackColor = true;
            chkConfirmado.CheckedChanged += chkConfirmado_CheckedChanged;
            // 
            // chkEnviado
            // 
            chkEnviado.AutoSize = true;
            chkEnviado.Location = new Point(11, 86);
            chkEnviado.Name = "chkEnviado";
            chkEnviado.Size = new Size(83, 24);
            chkEnviado.TabIndex = 2;
            chkEnviado.Text = "Enviado";
            chkEnviado.UseVisualStyleBackColor = true;
            chkEnviado.CheckedChanged += chkEnviado_CheckedChanged;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 399);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormPedidos";
            Text = "FormPedidos";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvPedidos;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnEnviar;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Button btnSalir;
        private CheckBox chkEnviado;
        private CheckBox chkConfirmado;
        private CheckBox chkPendiente;
    }
}