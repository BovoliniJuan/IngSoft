﻿namespace Vista.ModuloSeguridad
{
    partial class FormAudSesiones
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
            dgvAuditoria = new DataGridView();
            btnVolver = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(btnVolver);
            groupBox1.Controls.Add(dgvAuditoria);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(767, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dgvAuditoria
            // 
            dgvAuditoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditoria.Location = new Point(6, 22);
            dgvAuditoria.Name = "dgvAuditoria";
            dgvAuditoria.RowTemplate.Height = 25;
            dgvAuditoria.Size = new Size(755, 330);
            dgvAuditoria.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(674, 375);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(87, 45);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormAudSesiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormAudSesiones";
            Text = "Auditoria de Sesiones";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnVolver;
        private DataGridView dgvAuditoria;
    }
}