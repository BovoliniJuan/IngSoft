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
            label1 = new Label();
            txtBuscador = new TextBox();
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
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtBuscador);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(483, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 184);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 1;
            label1.Text = "Buscador";
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(6, 55);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(205, 29);
            txtBuscador.TabIndex = 0;
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
        private Label label1;
        private TextBox txtBuscador;
        private GroupBox groupBox3;
        private Button btnSalir;
        private Button btnRecibir;
    }
}