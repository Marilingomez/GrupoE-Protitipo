namespace GrupoE_Protitipos
{
    partial class FormOrdenDeSeleccion
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            buttonFinalizar = new Button();
            ordenesPreparar = new ListView();
            Id = new ColumnHeader();
            Cliente = new ColumnHeader();
            ordenesSeleccionar = new ListView();
            IdSeleccionado = new ColumnHeader();
            clienteSeleccionado = new ColumnHeader();
            listProductos = new ListView();
            Pasillo = new ColumnHeader();
            Fila = new ColumnHeader();
            Estante = new ColumnHeader();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            depositoLabel = new Label();
            depositoBox = new ComboBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            VolverBoton = new Button();
            PrioridadPreparar = new ColumnHeader();
            PrioridadSeleccionado = new ColumnHeader();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(161, 32, 89);
            label1.Location = new Point(15, 66);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 4;
            label1.Text = "Órdenes a preparar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(161, 32, 89);
            label2.Location = new Point(396, 66);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 5;
            label2.Text = "Órdenes a seleccionar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(161, 32, 89);
            label4.Location = new Point(14, 231);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 7;
            label4.Text = "Productos a seleccionar";
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.FromArgb(161, 32, 89);
            buttonAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregar.ForeColor = SystemColors.ButtonHighlight;
            buttonAgregar.Location = new Point(291, 118);
            buttonAgregar.Margin = new Padding(3, 2, 3, 2);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(99, 31);
            buttonAgregar.TabIndex = 16;
            buttonAgregar.Text = "→";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.FromArgb(161, 32, 89);
            buttonEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEliminar.ForeColor = SystemColors.ButtonHighlight;
            buttonEliminar.Location = new Point(291, 153);
            buttonEliminar.Margin = new Padding(3, 2, 3, 2);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(99, 31);
            buttonEliminar.TabIndex = 17;
            buttonEliminar.Text = "←";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.BackColor = Color.FromArgb(161, 32, 89);
            buttonFinalizar.ForeColor = SystemColors.ButtonHighlight;
            buttonFinalizar.Location = new Point(505, 380);
            buttonFinalizar.Margin = new Padding(3, 2, 3, 2);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(162, 27);
            buttonFinalizar.TabIndex = 18;
            buttonFinalizar.Text = "Finalizar y Guardar";
            buttonFinalizar.UseVisualStyleBackColor = false;
            buttonFinalizar.Click += buttonFinalizar_Click;
            // 
            // ordenesPreparar
            // 
            ordenesPreparar.Columns.AddRange(new ColumnHeader[] { Id, Cliente, PrioridadPreparar });
            ordenesPreparar.FullRowSelect = true;
            ordenesPreparar.Location = new Point(15, 87);
            ordenesPreparar.Name = "ordenesPreparar";
            ordenesPreparar.Size = new Size(271, 133);
            ordenesPreparar.TabIndex = 19;
            ordenesPreparar.UseCompatibleStateImageBehavior = false;
            ordenesPreparar.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 50;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 120;
            // 
            // ordenesSeleccionar
            // 
            ordenesSeleccionar.Columns.AddRange(new ColumnHeader[] { IdSeleccionado, clienteSeleccionado, PrioridadSeleccionado });
            ordenesSeleccionar.FullRowSelect = true;
            ordenesSeleccionar.Location = new Point(396, 84);
            ordenesSeleccionar.Name = "ordenesSeleccionar";
            ordenesSeleccionar.Size = new Size(271, 133);
            ordenesSeleccionar.TabIndex = 20;
            ordenesSeleccionar.UseCompatibleStateImageBehavior = false;
            ordenesSeleccionar.View = View.Details;
            // 
            // IdSeleccionado
            // 
            IdSeleccionado.Text = "Id";
            IdSeleccionado.Width = 50;
            // 
            // clienteSeleccionado
            // 
            clienteSeleccionado.Text = "Cliente seleccionado";
            clienteSeleccionado.Width = 120;
            // 
            // listProductos
            // 
            listProductos.Columns.AddRange(new ColumnHeader[] { Pasillo, Fila, Estante, Producto, Cantidad });
            listProductos.Location = new Point(14, 249);
            listProductos.Name = "listProductos";
            listProductos.Size = new Size(653, 112);
            listProductos.TabIndex = 21;
            listProductos.UseCompatibleStateImageBehavior = false;
            listProductos.View = View.Details;
            // 
            // Pasillo
            // 
            Pasillo.Text = "Pasillo";
            Pasillo.Width = 90;
            // 
            // Fila
            // 
            Fila.Text = "Fila";
            Fila.Width = 90;
            // 
            // Estante
            // 
            Estante.Text = "Estante";
            Estante.Width = 90;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 300;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 90;
            // 
            // depositoLabel
            // 
            depositoLabel.AutoSize = true;
            depositoLabel.Location = new Point(15, 42);
            depositoLabel.Name = "depositoLabel";
            depositoLabel.Size = new Size(54, 15);
            depositoLabel.TabIndex = 22;
            depositoLabel.Text = "Deposito";
            // 
            // depositoBox
            // 
            depositoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            depositoBox.FormattingEnabled = true;
            depositoBox.Location = new Point(74, 39);
            depositoBox.Name = "depositoBox";
            depositoBox.Size = new Size(179, 23);
            depositoBox.TabIndex = 23;
            depositoBox.SelectedIndexChanged += depositoBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(161, 32, 89);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 26);
            panel1.TabIndex = 33;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.GrupoE;
            pictureBox1.Location = new Point(-23, 4);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // VolverBoton
            // 
            VolverBoton.BackColor = Color.FromArgb(161, 32, 89);
            VolverBoton.ForeColor = SystemColors.ButtonHighlight;
            VolverBoton.Location = new Point(505, 411);
            VolverBoton.Margin = new Padding(3, 2, 3, 2);
            VolverBoton.Name = "VolverBoton";
            VolverBoton.Size = new Size(162, 27);
            VolverBoton.TabIndex = 34;
            VolverBoton.Text = "Volver al menu";
            VolverBoton.UseVisualStyleBackColor = false;
            VolverBoton.Click += VolverBoton_Click;
            // 
            // PrioridadPreparar
            // 
            PrioridadPreparar.Text = "Prioridad";
            PrioridadPreparar.Width = 100;
            // 
            // PrioridadSeleccionado
            // 
            PrioridadSeleccionado.Text = "Prioridad";
            PrioridadSeleccionado.Width = 100;
            // 
            // FormOrdenDeSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(700, 442);
            Controls.Add(VolverBoton);
            Controls.Add(panel1);
            Controls.Add(depositoBox);
            Controls.Add(depositoLabel);
            Controls.Add(listProductos);
            Controls.Add(ordenesSeleccionar);
            Controls.Add(ordenesPreparar);
            Controls.Add(buttonFinalizar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormOrdenDeSeleccion";
            Text = "Orden de Selección";
            Load += FormOrdenDeSeleccion_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label4;
        private Button buttonAgregar;
        private Button buttonEliminar;
        private Button buttonFinalizar;
        private ListView ordenesPreparar;
        private ColumnHeader Id;
        private ListView ordenesSeleccionar;
        private ColumnHeader Cliente;
        private ColumnHeader IdSeleccionado;
        private ColumnHeader clienteSeleccionado;
        private ListView listProductos;
        private ColumnHeader Pasillo;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private ColumnHeader Fila;
        private ColumnHeader Estante;
        private Label depositoLabel;
        private ComboBox depositoBox;
        private Panel panel1;
        private Button VolverBoton;
        private PictureBox pictureBox1;
        private ColumnHeader PrioridadPreparar;
        private ColumnHeader PrioridadSeleccionado;
    }
}