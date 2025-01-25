namespace Vista.ModuloVendedores
{
    partial class FormReportes
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
            btnExportar = new Button();
            cmbTipoReporte = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvReportes = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(btnVolver);
            groupBox1.Controls.Add(btnExportar);
            groupBox1.Controls.Add(cmbTipoReporte);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 385);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(782, 95);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reportes";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(690, 55);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 34);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(196, 38);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(88, 51);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "Exportar a PDF";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Items.AddRange(new object[] { "Productos mas vendidos", "Productos menos vendidos", "Productos mas rentables" });
            cmbTipoReporte.Location = new Point(6, 49);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(162, 29);
            cmbTipoReporte.TabIndex = 1;
            cmbTipoReporte.SelectedIndexChanged += cmbTipoReporte_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 0;
            label1.Text = "Reportes a elegir";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gray;
            groupBox2.Controls.Add(dgvReportes);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(782, 358);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dgvReportes
            // 
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(6, 13);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.RowTemplate.Height = 25;
            dgvReportes.Size = new Size(770, 339);
            dgvReportes.TabIndex = 0;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(805, 496);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormReportes";
            Text = "Reportes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnVolver;
        private Button btnExportar;
        private ComboBox cmbTipoReporte;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvReportes;
    }
}