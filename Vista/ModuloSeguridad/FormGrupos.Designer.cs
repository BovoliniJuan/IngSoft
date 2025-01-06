namespace Vista
{
    partial class FormGrupos
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
            dgvUsuarios = new DataGridView();
            cmbGrupos = new ComboBox();
            btnAsignarGrupo = new Button();
            groupBox1 = new GroupBox();
            chkConGrupo = new CheckBox();
            chkSinGrupo = new CheckBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 12);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(405, 357);
            dgvUsuarios.TabIndex = 0;
            // 
            // cmbGrupos
            // 
            cmbGrupos.FormattingEnabled = true;
            cmbGrupos.Location = new Point(6, 22);
            cmbGrupos.Name = "cmbGrupos";
            cmbGrupos.Size = new Size(188, 23);
            cmbGrupos.TabIndex = 1;
            // 
            // btnAsignarGrupo
            // 
            btnAsignarGrupo.Location = new Point(6, 60);
            btnAsignarGrupo.Name = "btnAsignarGrupo";
            btnAsignarGrupo.Size = new Size(114, 23);
            btnAsignarGrupo.TabIndex = 4;
            btnAsignarGrupo.Text = "Asignar grupo";
            btnAsignarGrupo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkConGrupo);
            groupBox1.Controls.Add(chkSinGrupo);
            groupBox1.Location = new Point(423, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 81);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // chkConGrupo
            // 
            chkConGrupo.AutoSize = true;
            chkConGrupo.Location = new Point(8, 45);
            chkConGrupo.Name = "chkConGrupo";
            chkConGrupo.Size = new Size(84, 19);
            chkConGrupo.TabIndex = 7;
            chkConGrupo.Text = "Con Grupo";
            chkConGrupo.UseVisualStyleBackColor = true;
            chkConGrupo.CheckedChanged += chkConGrupo_CheckedChanged;
            // 
            // chkSinGrupo
            // 
            chkSinGrupo.AutoSize = true;
            chkSinGrupo.Location = new Point(8, 20);
            chkSinGrupo.Name = "chkSinGrupo";
            chkSinGrupo.Size = new Size(78, 19);
            chkSinGrupo.TabIndex = 6;
            chkSinGrupo.Text = "Sin Grupo";
            chkSinGrupo.UseVisualStyleBackColor = true;
            chkSinGrupo.CheckedChanged += chkSinGrupo_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbGrupos);
            groupBox2.Controls.Add(btnAsignarGrupo);
            groupBox2.Location = new Point(423, 99);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Grupos";
            // 
            // FormGrupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 384);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvUsuarios);
            Name = "FormGrupos";
            Text = "FormGrupos";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuarios;
        private ComboBox cmbGrupos;
        private Button btnAsignarGrupo;
        private GroupBox groupBox1;
        private CheckBox chkConGrupo;
        private CheckBox chkSinGrupo;
        private GroupBox groupBox2;
    }
}