namespace Vista.ModuloVendedores
{
    partial class FormProductos
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
            groupBox2 = new GroupBox();
            dgvProductos = new DataGridView();
            chkMenorPrecio = new CheckBox();
            chkMayorPrecio = new CheckBox();
            chkMayorCantidad = new CheckBox();
            chkMenorCantidad = new CheckBox();
            groupBox3 = new GroupBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(dgvProductos);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(474, 388);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gray;
            groupBox2.Controls.Add(chkMenorCantidad);
            groupBox2.Controls.Add(chkMayorCantidad);
            groupBox2.Controls.Add(chkMayorPrecio);
            groupBox2.Controls.Add(chkMenorPrecio);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(480, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 96);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtros";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(6, 11);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(462, 371);
            dgvProductos.TabIndex = 0;
            // 
            // chkMenorPrecio
            // 
            chkMenorPrecio.AutoSize = true;
            chkMenorPrecio.Location = new Point(6, 28);
            chkMenorPrecio.Name = "chkMenorPrecio";
            chkMenorPrecio.Size = new Size(131, 25);
            chkMenorPrecio.TabIndex = 0;
            chkMenorPrecio.Text = "Menor Precio";
            chkMenorPrecio.UseVisualStyleBackColor = true;
            // 
            // chkMayorPrecio
            // 
            chkMayorPrecio.AutoSize = true;
            chkMayorPrecio.Location = new Point(6, 59);
            chkMayorPrecio.Name = "chkMayorPrecio";
            chkMayorPrecio.Size = new Size(130, 25);
            chkMayorPrecio.TabIndex = 1;
            chkMayorPrecio.Text = "Mayor Precio";
            chkMayorPrecio.UseVisualStyleBackColor = true;
            // 
            // chkMayorCantidad
            // 
            chkMayorCantidad.AutoSize = true;
            chkMayorCantidad.Location = new Point(152, 59);
            chkMayorCantidad.Name = "chkMayorCantidad";
            chkMayorCantidad.Size = new Size(151, 25);
            chkMayorCantidad.TabIndex = 2;
            chkMayorCantidad.Text = "Mayor Cantidad";
            chkMayorCantidad.UseVisualStyleBackColor = true;
            // 
            // chkMenorCantidad
            // 
            chkMenorCantidad.AutoSize = true;
            chkMenorCantidad.Location = new Point(152, 28);
            chkMenorCantidad.Name = "chkMenorCantidad";
            chkMenorCantidad.Size = new Size(152, 25);
            chkMenorCantidad.TabIndex = 3;
            chkMenorCantidad.Text = "Menor Cantidad";
            chkMenorCantidad.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Gray;
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(btnModificar);
            groupBox3.Location = new Point(480, 103);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(308, 179);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(17, 22);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 46);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(17, 84);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 46);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormProductos";
            Text = "FormProductos";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvProductos;
        private GroupBox groupBox2;
        private CheckBox chkMayorCantidad;
        private CheckBox chkMayorPrecio;
        private CheckBox chkMenorPrecio;
        private CheckBox chkMenorCantidad;
        private GroupBox groupBox3;
        private Button btnEliminar;
        private Button btnModificar;
    }
}