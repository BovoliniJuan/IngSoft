namespace Vista.ModuloSeguridad
{
    partial class FormCrearGrupos
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
            TreeNode treeNode1 = new TreeNode("Acceso a Administrador");
            TreeNode treeNode2 = new TreeNode("Administrador", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Acceso a Vendedor");
            TreeNode treeNode4 = new TreeNode("Vendedor", new TreeNode[] { treeNode3 });
            TreeNode treeNode5 = new TreeNode("Acceso a Cliente");
            TreeNode treeNode6 = new TreeNode("Cliente", new TreeNode[] { treeNode5 });
            tabGrupos = new TabControl();
            tabDatos = new TabPage();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbEstado = new ComboBox();
            txtNombre = new TextBox();
            tabAcciones = new TabPage();
            btnCancelar = new Button();
            btnGuardar = new Button();
            treeAcciones = new TreeView();
            txtCodigo = new TextBox();
            tabGrupos.SuspendLayout();
            tabDatos.SuspendLayout();
            tabAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tabGrupos
            // 
            tabGrupos.Controls.Add(tabDatos);
            tabGrupos.Controls.Add(tabAcciones);
            tabGrupos.Location = new Point(12, 3);
            tabGrupos.Name = "tabGrupos";
            tabGrupos.SelectedIndex = 0;
            tabGrupos.Size = new Size(582, 373);
            tabGrupos.TabIndex = 0;
            // 
            // tabDatos
            // 
            tabDatos.BackColor = Color.Gray;
            tabDatos.Controls.Add(txtCodigo);
            tabDatos.Controls.Add(label3);
            tabDatos.Controls.Add(label2);
            tabDatos.Controls.Add(label1);
            tabDatos.Controls.Add(cmbEstado);
            tabDatos.Controls.Add(txtNombre);
            tabDatos.Location = new Point(4, 24);
            tabDatos.Name = "tabDatos";
            tabDatos.Padding = new Padding(3);
            tabDatos.Size = new Size(574, 345);
            tabDatos.TabIndex = 0;
            tabDatos.Text = "Datos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 71);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 5;
            label3.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 136);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 3;
            label2.Text = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 15);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(33, 160);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(124, 23);
            cmbEstado.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(251, 23);
            txtNombre.TabIndex = 0;
            // 
            // tabAcciones
            // 
            tabAcciones.Controls.Add(btnCancelar);
            tabAcciones.Controls.Add(btnGuardar);
            tabAcciones.Controls.Add(treeAcciones);
            tabAcciones.Location = new Point(4, 24);
            tabAcciones.Name = "tabAcciones";
            tabAcciones.Padding = new Padding(3);
            tabAcciones.Size = new Size(574, 345);
            tabAcciones.TabIndex = 1;
            tabAcciones.Text = "Acciones";
            tabAcciones.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(195, 283);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(54, 283);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // treeAcciones
            // 
            treeAcciones.CheckBoxes = true;
            treeAcciones.Location = new Point(6, 6);
            treeAcciones.Name = "treeAcciones";
            treeNode1.Name = "nAcsAdmin";
            treeNode1.Text = "Acceso a Administrador";
            treeNode2.Name = "nAdmin";
            treeNode2.Text = "Administrador";
            treeNode2.ToolTipText = "Administrador";
            treeNode3.Name = "nAcsVendedor";
            treeNode3.Text = "Acceso a Vendedor";
            treeNode4.Name = "nVendedor";
            treeNode4.Text = "Vendedor";
            treeNode5.Name = "nAcsCliente";
            treeNode5.Text = "Acceso a Cliente";
            treeNode6.Name = "nCliente";
            treeNode6.Text = "Cliente";
            treeAcciones.Nodes.AddRange(new TreeNode[] { treeNode2, treeNode4, treeNode6 });
            treeAcciones.Size = new Size(441, 234);
            treeAcciones.TabIndex = 0;
            treeAcciones.AfterCheck += treeAcciones_AfterCheck;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(33, 95);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(124, 23);
            txtCodigo.TabIndex = 6;
            // 
            // FormCrearGrupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(601, 385);
            Controls.Add(tabGrupos);
            Name = "FormCrearGrupos";
            Text = "AgregarGrupos";
            tabGrupos.ResumeLayout(false);
            tabDatos.ResumeLayout(false);
            tabDatos.PerformLayout();
            tabAcciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabGrupos;
        private TabPage tabDatos;
        private TextBox txtNombre;
        private TabPage tabAcciones;
        private ComboBox cmbEstado;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnGuardar;
        private TreeView treeAcciones;
        private Label label3;
        private TextBox txtCodigo;
    }
}