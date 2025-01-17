namespace Vista.ModuloVendedores
{
    partial class FormMisPublicaciones
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
            dgvPublicaciones = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnPausar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPublicaciones).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(dgvPublicaciones);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dgvPublicaciones
            // 
            dgvPublicaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPublicaciones.Location = new Point(6, 11);
            dgvPublicaciones.Name = "dgvPublicaciones";
            dgvPublicaciones.RowTemplate.Height = 25;
            dgvPublicaciones.Size = new Size(491, 409);
            dgvPublicaciones.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gray;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(536, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(252, 159);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtros";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Gray;
            groupBox3.Controls.Add(btnPausar);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(btnModificar);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(536, 199);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(252, 233);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Controles";
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(6, 28);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 32);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(6, 94);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 32);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnPausar
            // 
            btnPausar.Location = new Point(6, 162);
            btnPausar.Name = "btnPausar";
            btnPausar.Size = new Size(90, 32);
            btnPausar.TabIndex = 2;
            btnPausar.Text = "Pausar";
            btnPausar.UseVisualStyleBackColor = true;
            btnPausar.Click += btnPausar_Click;
            // 
            // FormMisPublicaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMisPublicaciones";
            Text = "FormPublicaciones";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPublicaciones).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvPublicaciones;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnPausar;
        private Button btnEliminar;
        private Button btnModificar;
    }
}