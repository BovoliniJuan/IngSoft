namespace Vista.ModuloCIientes
{
    partial class FormPublicaciones
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
            groupPubli = new GroupBox();
            dgvPublicaciones = new DataGridView();
            groupBusqueda = new GroupBox();
            btnBuscar = new Button();
            label1 = new Label();
            txtBuscador = new TextBox();
            groupBox1 = new GroupBox();
            chkMayorA = new CheckBox();
            chkMenorA = new CheckBox();
            chkMayorP = new CheckBox();
            chkMenorP = new CheckBox();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            dgvCarrito = new DataGridView();
            btnAgregar = new Button();
            groupPubli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPublicaciones).BeginInit();
            groupBusqueda.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // groupPubli
            // 
            groupPubli.Controls.Add(dgvPublicaciones);
            groupPubli.Location = new Point(0, -1);
            groupPubli.Name = "groupPubli";
            groupPubli.Size = new Size(485, 439);
            groupPubli.TabIndex = 0;
            groupPubli.TabStop = false;
            // 
            // dgvPublicaciones
            // 
            dgvPublicaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPublicaciones.Location = new Point(6, 13);
            dgvPublicaciones.Name = "dgvPublicaciones";
            dgvPublicaciones.RowTemplate.Height = 25;
            dgvPublicaciones.Size = new Size(473, 420);
            dgvPublicaciones.TabIndex = 0;
            // 
            // groupBusqueda
            // 
            groupBusqueda.BackColor = Color.Gray;
            groupBusqueda.Controls.Add(btnBuscar);
            groupBusqueda.Controls.Add(label1);
            groupBusqueda.Controls.Add(txtBuscador);
            groupBusqueda.Location = new Point(491, -1);
            groupBusqueda.Name = "groupBusqueda";
            groupBusqueda.Size = new Size(305, 128);
            groupBusqueda.TabIndex = 1;
            groupBusqueda.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(6, 69);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 36);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(105, 16);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 1;
            label1.Text = "Buscador";
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(6, 40);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(280, 23);
            txtBuscador.TabIndex = 0;
            txtBuscador.TextChanged += TxtBuscar_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(chkMayorA);
            groupBox1.Controls.Add(chkMenorA);
            groupBox1.Controls.Add(chkMayorP);
            groupBox1.Controls.Add(chkMenorP);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(491, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 131);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // chkMayorA
            // 
            chkMayorA.AutoSize = true;
            chkMayorA.Location = new Point(143, 26);
            chkMayorA.Name = "chkMayorA";
            chkMayorA.Size = new Size(162, 25);
            chkMayorA.TabIndex = 3;
            chkMayorA.Text = "Mayor Atiguedad";
            chkMayorA.UseVisualStyleBackColor = true;
            // 
            // chkMenorA
            // 
            chkMenorA.AutoSize = true;
            chkMenorA.Location = new Point(6, 89);
            chkMenorA.Name = "chkMenorA";
            chkMenorA.Size = new Size(173, 25);
            chkMenorA.TabIndex = 2;
            chkMenorA.Text = "Menor Antiguedad";
            chkMenorA.UseVisualStyleBackColor = true;
            // 
            // chkMayorP
            // 
            chkMayorP.AutoSize = true;
            chkMayorP.Location = new Point(6, 58);
            chkMayorP.Name = "chkMayorP";
            chkMayorP.Size = new Size(130, 25);
            chkMayorP.TabIndex = 1;
            chkMayorP.Text = "Mayor Precio";
            chkMayorP.UseVisualStyleBackColor = true;
            // 
            // chkMenorP
            // 
            chkMenorP.AutoSize = true;
            chkMenorP.Location = new Point(6, 26);
            chkMenorP.Name = "chkMenorP";
            chkMenorP.Size = new Size(131, 25);
            chkMenorP.TabIndex = 0;
            chkMenorP.Text = "Menor Precio";
            chkMenorP.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gray;
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(dgvCarrito);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(495, 276);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(301, 162);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Carrito de Compras";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(164, 126);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 30);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar del Carro";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(6, 18);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowTemplate.Height = 25;
            dgvCarrito.Size = new Size(289, 102);
            dgvCarrito.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(6, 126);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(152, 30);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Publicacion";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormPublicaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBusqueda);
            Controls.Add(groupPubli);
            Name = "FormPublicaciones";
            Text = "Publicaciones";
            groupPubli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPublicaciones).EndInit();
            groupBusqueda.ResumeLayout(false);
            groupBusqueda.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupPubli;
        private DataGridView dgvPublicaciones;
        private GroupBox groupBusqueda;
        private Label label1;
        private TextBox txtBuscador;
        private Button btnBuscar;
        private GroupBox groupBox1;
        private CheckBox chkMayorA;
        private CheckBox chkMenorA;
        private CheckBox chkMayorP;
        private CheckBox chkMenorP;
        private GroupBox groupBox2;
        private Button btnEliminar;
        private DataGridView dgvCarrito;
        private Button btnAgregar;
    }
}