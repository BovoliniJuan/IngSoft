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
            chkMayorPrec = new CheckBox();
            chkMenorPrec = new CheckBox();
            chkMayorCant = new CheckBox();
            chkMenorCant = new CheckBox();
            chkMayorAnt = new CheckBox();
            chkMenorAnt = new CheckBox();
            groupBox3 = new GroupBox();
            btnSalir = new Button();
            btnPausar = new Button();
            btnEliminar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPublicaciones).BeginInit();
            groupBox2.SuspendLayout();
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
            groupBox2.Controls.Add(chkMayorPrec);
            groupBox2.Controls.Add(chkMenorPrec);
            groupBox2.Controls.Add(chkMayorCant);
            groupBox2.Controls.Add(chkMenorCant);
            groupBox2.Controls.Add(chkMayorAnt);
            groupBox2.Controls.Add(chkMenorAnt);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(521, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(296, 159);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtros";
            // 
            // chkMayorPrec
            // 
            chkMayorPrec.AutoSize = true;
            chkMayorPrec.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            chkMayorPrec.Location = new Point(179, 59);
            chkMayorPrec.Name = "chkMayorPrec";
            chkMayorPrec.Size = new Size(120, 24);
            chkMayorPrec.TabIndex = 5;
            chkMayorPrec.Text = "Mayor Precio";
            chkMayorPrec.UseVisualStyleBackColor = true;
            chkMayorPrec.CheckedChanged += chkMayorPrec_CheckedChanged;
            // 
            // chkMenorPrec
            // 
            chkMenorPrec.AutoSize = true;
            chkMenorPrec.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            chkMenorPrec.Location = new Point(179, 28);
            chkMenorPrec.Name = "chkMenorPrec";
            chkMenorPrec.Size = new Size(121, 24);
            chkMenorPrec.TabIndex = 4;
            chkMenorPrec.Text = "Menor Precio";
            chkMenorPrec.UseVisualStyleBackColor = true;
            chkMenorPrec.CheckedChanged += chkMenorPrec_CheckedChanged;
            // 
            // chkMayorCant
            // 
            chkMayorCant.AutoSize = true;
            chkMayorCant.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            chkMayorCant.Location = new Point(6, 121);
            chkMayorCant.Name = "chkMayorCant";
            chkMayorCant.Size = new Size(139, 24);
            chkMayorCant.TabIndex = 3;
            chkMayorCant.Text = "Mayor Cantidad";
            chkMayorCant.UseVisualStyleBackColor = true;
            chkMayorCant.CheckedChanged += chkMayorCant_CheckedChanged;
            // 
            // chkMenorCant
            // 
            chkMenorCant.AutoSize = true;
            chkMenorCant.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            chkMenorCant.Location = new Point(6, 90);
            chkMenorCant.Name = "chkMenorCant";
            chkMenorCant.Size = new Size(140, 24);
            chkMenorCant.TabIndex = 2;
            chkMenorCant.Text = "Menor Cantidad";
            chkMenorCant.UseVisualStyleBackColor = true;
            chkMenorCant.CheckedChanged += chkMenorCant_CheckedChanged;
            // 
            // chkMayorAnt
            // 
            chkMayorAnt.AutoSize = true;
            chkMayorAnt.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            chkMayorAnt.Location = new Point(6, 59);
            chkMayorAnt.Name = "chkMayorAnt";
            chkMayorAnt.Size = new Size(159, 24);
            chkMayorAnt.TabIndex = 1;
            chkMayorAnt.Text = "Mayor Antiguedad";
            chkMayorAnt.UseVisualStyleBackColor = true;
            chkMayorAnt.CheckedChanged += chkMayorAnt_CheckedChanged;
            // 
            // chkMenorAnt
            // 
            chkMenorAnt.AutoSize = true;
            chkMenorAnt.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            chkMenorAnt.Location = new Point(6, 28);
            chkMenorAnt.Name = "chkMenorAnt";
            chkMenorAnt.Size = new Size(160, 24);
            chkMenorAnt.TabIndex = 0;
            chkMenorAnt.Text = "Menor Antiguedad";
            chkMenorAnt.UseVisualStyleBackColor = true;
            chkMenorAnt.CheckedChanged += chkMenorAnt_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Gray;
            groupBox3.Controls.Add(btnSalir);
            groupBox3.Controls.Add(btnPausar);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(521, 190);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(296, 248);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Controles";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(6, 175);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 52);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnPausar
            // 
            btnPausar.Location = new Point(6, 102);
            btnPausar.Name = "btnPausar";
            btnPausar.Size = new Size(90, 52);
            btnPausar.TabIndex = 2;
            btnPausar.Text = "Cambiar estado";
            btnPausar.UseVisualStyleBackColor = true;
            btnPausar.Click += btnPausar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(6, 28);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 52);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormMisPublicaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(819, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMisPublicaciones";
            Text = "Mis Publicaciones";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPublicaciones).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Button btnSalir;
        private CheckBox chkMayorPrec;
        private CheckBox chkMenorPrec;
        private CheckBox chkMayorCant;
        private CheckBox chkMenorCant;
        private CheckBox chkMayorAnt;
        private CheckBox chkMenorAnt;
    }
}