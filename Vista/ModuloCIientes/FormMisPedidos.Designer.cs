namespace Vista.ModuloCIientes
{
    partial class FormMisPedidos
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
            chkPendiente = new CheckBox();
            chkEntregado = new CheckBox();
            chkEnviado = new CheckBox();
            chkConfirmado = new CheckBox();
            chkCancelado = new CheckBox();
            groupBox3 = new GroupBox();
            btnSalir = new Button();
            btnRecibir = new Button();
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
            groupBox1.Size = new Size(438, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(6, 10);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowTemplate.Height = 25;
            dgvPedidos.Size = new Size(426, 410);
            dgvPedidos.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gray;
            groupBox2.Controls.Add(chkPendiente);
            groupBox2.Controls.Add(chkEntregado);
            groupBox2.Controls.Add(chkEnviado);
            groupBox2.Controls.Add(chkConfirmado);
            groupBox2.Controls.Add(chkCancelado);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(483, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 184);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtros";
            // 
            // chkPendiente
            // 
            chkPendiente.AutoSize = true;
            chkPendiente.Location = new Point(6, 152);
            chkPendiente.Name = "chkPendiente";
            chkPendiente.Size = new Size(97, 25);
            chkPendiente.TabIndex = 4;
            chkPendiente.Text = "Pediente";
            chkPendiente.UseVisualStyleBackColor = true;
            chkPendiente.CheckedChanged += chkPendiente_CheckedChanged;
            // 
            // chkEntregado
            // 
            chkEntregado.AutoSize = true;
            chkEntregado.Location = new Point(6, 121);
            chkEntregado.Name = "chkEntregado";
            chkEntregado.Size = new Size(108, 25);
            chkEntregado.TabIndex = 3;
            chkEntregado.Text = "Entregado";
            chkEntregado.UseVisualStyleBackColor = true;
            chkEntregado.CheckedChanged += chkEntregado_CheckedChanged;
            // 
            // chkEnviado
            // 
            chkEnviado.AutoSize = true;
            chkEnviado.Location = new Point(6, 90);
            chkEnviado.Name = "chkEnviado";
            chkEnviado.Size = new Size(91, 25);
            chkEnviado.TabIndex = 2;
            chkEnviado.Text = "Enviado";
            chkEnviado.UseVisualStyleBackColor = true;
            chkEnviado.CheckedChanged += chkEnviado_CheckedChanged;
            // 
            // chkConfirmado
            // 
            chkConfirmado.AutoSize = true;
            chkConfirmado.Location = new Point(6, 59);
            chkConfirmado.Name = "chkConfirmado";
            chkConfirmado.Size = new Size(120, 25);
            chkConfirmado.TabIndex = 1;
            chkConfirmado.Text = "Confirmado";
            chkConfirmado.UseVisualStyleBackColor = true;
            chkConfirmado.CheckedChanged += chkConfirmado_CheckedChanged;
            // 
            // chkCancelado
            // 
            chkCancelado.AutoSize = true;
            chkCancelado.Location = new Point(6, 28);
            chkCancelado.Name = "chkCancelado";
            chkCancelado.Size = new Size(109, 25);
            chkCancelado.TabIndex = 0;
            chkCancelado.Text = "Cancelado";
            chkCancelado.UseVisualStyleBackColor = true;
            chkCancelado.CheckedChanged += chkCancelado_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Gray;
            groupBox3.Controls.Add(btnSalir);
            groupBox3.Controls.Add(btnRecibir);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(483, 237);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(305, 201);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Controles";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(214, 161);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(85, 34);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRecibir
            // 
            btnRecibir.Location = new Point(6, 28);
            btnRecibir.Name = "btnRecibir";
            btnRecibir.Size = new Size(94, 57);
            btnRecibir.TabIndex = 0;
            btnRecibir.Text = "Recibi mi pedido";
            btnRecibir.UseVisualStyleBackColor = true;
            btnRecibir.Click += btnRecibir_Click;
            // 
            // FormMisPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMisPedidos";
            Text = "Mis Pedidos";
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
        private Button btnSalir;
        private Button btnRecibir;
        private CheckBox chkPendiente;
        private CheckBox chkEntregado;
        private CheckBox chkEnviado;
        private CheckBox chkConfirmado;
        private CheckBox chkCancelado;
    }
}