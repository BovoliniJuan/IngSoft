namespace Vista.ModuloSeguridad
{
    partial class FormAdministrador
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
            btnGrupos = new Button();
            btnUsuarios = new Button();
            btnAsignar = new Button();
            SuspendLayout();
            // 
            // btnGrupos
            // 
            btnGrupos.Location = new Point(67, 51);
            btnGrupos.Name = "btnGrupos";
            btnGrupos.Size = new Size(139, 23);
            btnGrupos.TabIndex = 0;
            btnGrupos.Text = "Grupos";
            btnGrupos.UseVisualStyleBackColor = true;
            btnGrupos.Click += btnGrupos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(67, 108);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(139, 23);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(67, 161);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(139, 23);
            btnAsignar.TabIndex = 2;
            btnAsignar.Text = "Asignacion Grupos";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 273);
            Controls.Add(btnAsignar);
            Controls.Add(btnUsuarios);
            Controls.Add(btnGrupos);
            Name = "FormAdministrador";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGrupos;
        private Button btnUsuarios;
        private Button btnAsignar;
    }
}