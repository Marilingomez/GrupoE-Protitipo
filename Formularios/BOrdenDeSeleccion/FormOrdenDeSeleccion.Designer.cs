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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 4;
            label1.Text = "Órdenes a preparar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 43);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 5;
            label2.Text = "Órdenes a seleccionar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 200);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 7;
            label4.Text = "Productos a seleccionar";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregar.Location = new Point(289, 95);
            buttonAgregar.Margin = new Padding(3, 2, 3, 2);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(99, 31);
            buttonAgregar.TabIndex = 16;
            buttonAgregar.Text = "→";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(289, 130);
            buttonEliminar.Margin = new Padding(3, 2, 3, 2);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(99, 31);
            buttonEliminar.TabIndex = 17;
            buttonEliminar.Text = "←";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Location = new Point(503, 335);
            buttonFinalizar.Margin = new Padding(3, 2, 3, 2);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(149, 20);
            buttonFinalizar.TabIndex = 18;
            buttonFinalizar.Text = "Finalizar y Guardar";
            buttonFinalizar.UseVisualStyleBackColor = true;
            buttonFinalizar.Click += buttonFinalizar_Click;
            // 
            // ordenesPreparar
            // 
            ordenesPreparar.Columns.AddRange(new ColumnHeader[] { Id, Cliente });
            ordenesPreparar.FullRowSelect = true;
            ordenesPreparar.Location = new Point(12, 64);
            ordenesPreparar.Name = "ordenesPreparar";
            ordenesPreparar.Size = new Size(271, 133);
            ordenesPreparar.TabIndex = 19;
            ordenesPreparar.UseCompatibleStateImageBehavior = false;
            ordenesPreparar.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            // 
            // ordenesSeleccionar
            // 
            ordenesSeleccionar.Columns.AddRange(new ColumnHeader[] { IdSeleccionado, clienteSeleccionado });
            ordenesSeleccionar.FullRowSelect = true;
            ordenesSeleccionar.Location = new Point(394, 61);
            ordenesSeleccionar.Name = "ordenesSeleccionar";
            ordenesSeleccionar.Size = new Size(271, 133);
            ordenesSeleccionar.TabIndex = 20;
            ordenesSeleccionar.UseCompatibleStateImageBehavior = false;
            ordenesSeleccionar.View = View.Details;
            // 
            // IdSeleccionado
            // 
            IdSeleccionado.Text = "Id";
            // 
            // clienteSeleccionado
            // 
            clienteSeleccionado.Text = "Cliente seleccionado";
            // 
            // listProductos
            // 
            listProductos.Columns.AddRange(new ColumnHeader[] { Pasillo, Fila, Estante, Producto, Cantidad });
            listProductos.Location = new Point(12, 218);
            listProductos.Name = "listProductos";
            listProductos.Size = new Size(653, 112);
            listProductos.TabIndex = 21;
            listProductos.UseCompatibleStateImageBehavior = false;
            listProductos.View = View.Details;
            // 
            // Pasillo
            // 
            Pasillo.Text = "Pasillo";
            // 
            // Fila
            // 
            Fila.Text = "Fila";
            // 
            // Estante
            // 
            Estante.Text = "Estante";
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            // 
            // depositoLabel
            // 
            depositoLabel.AutoSize = true;
            depositoLabel.Location = new Point(12, 19);
            depositoLabel.Name = "depositoLabel";
            depositoLabel.Size = new Size(54, 15);
            depositoLabel.TabIndex = 22;
            depositoLabel.Text = "Deposito";
            // 
            // depositoBox
            // 
            depositoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            depositoBox.FormattingEnabled = true;
            depositoBox.Location = new Point(72, 16);
            depositoBox.Name = "depositoBox";
            depositoBox.Size = new Size(179, 23);
            depositoBox.TabIndex = 23;
            depositoBox.SelectedIndexChanged += depositoBox_SelectedIndexChanged;
            // 
            // FormOrdenDeSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 388);
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
    }
}