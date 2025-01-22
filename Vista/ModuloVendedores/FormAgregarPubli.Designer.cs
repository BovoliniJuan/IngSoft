namespace Vista.ModuloVendedores
{
    partial class FormAgregarPubli
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numCantidad = new NumericUpDown();
            cmbProducto = new ComboBox();
            dateFin = new DateTimePicker();
            dateInicio = new DateTimePicker();
            txtDescripcion = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnAceptar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numCantidad);
            groupBox1.Controls.Add(cmbProducto);
            groupBox1.Controls.Add(dateFin);
            groupBox1.Controls.Add(dateInicio);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 412);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(131, 290);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 35);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(16, 290);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(78, 35);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(9, 201);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 9;
            label5.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(9, 156);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 8;
            label4.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 110);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 7;
            label3.Text = "Fecha de Fin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 66);
            label2.Name = "label2";
            label2.Size = new Size(100, 17);
            label2.TabIndex = 6;
            label2.Text = "Fecha de Inicio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 5;
            label1.Text = "Descripcion";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(6, 225);
            numCantidad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(248, 23);
            numCantidad.TabIndex = 4;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(6, 175);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(248, 23);
            cmbProducto.TabIndex = 3;
            // 
            // dateFin
            // 
            dateFin.Location = new Point(6, 130);
            dateFin.Name = "dateFin";
            dateFin.Size = new Size(248, 23);
            dateFin.TabIndex = 2;
            // 
            // dateInicio
            // 
            dateInicio.Location = new Point(6, 86);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(248, 23);
            dateInicio.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(6, 37);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(248, 23);
            txtDescripcion.TabIndex = 0;
            // 
            // FormAgregarPubli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(284, 450);
            Controls.Add(groupBox1);
            Name = "FormAgregarPubli";
            Text = "Agregar Publicacion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbProducto;
        private DateTimePicker dateFin;
        private DateTimePicker dateInicio;
        private TextBox txtDescripcion;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numCantidad;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}