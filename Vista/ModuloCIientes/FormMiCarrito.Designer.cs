namespace Vista.ModuloCIientes
{
    partial class FormMiCarrito
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
            btnVolver = new Button();
            btnEliminar = new Button();
            dgvCarrito = new DataGridView();
            btnComprar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(btnComprar);
            groupBox1.Controls.Add(btnVolver);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(dgvCarrito);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(335, 363);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(111, 57);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(6, 363);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(111, 57);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar Publicacion";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(6, 22);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowTemplate.Height = 25;
            dgvCarrito.Size = new Size(440, 335);
            dgvCarrito.TabIndex = 0;
            // 
            // btnComprar
            // 
            btnComprar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.Location = new Point(162, 363);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(111, 57);
            btnComprar.TabIndex = 3;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // FormMiCarrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(476, 450);
            Controls.Add(groupBox1);
            Name = "FormMiCarrito";
            Text = "Carrito De Compras";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnVolver;
        private Button btnEliminar;
        private DataGridView dgvCarrito;
        private Button btnComprar;
    }
}