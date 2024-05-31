namespace GrupoE_Protitipos
{
    partial class FormOrdenDePreparacion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Orden = new Label();
            DetallesList = new ListView();
            IDProducto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Deposito = new ColumnHeader();
            Columna = new ColumnHeader();
            Fila = new ColumnHeader();
            FechaAlta = new ColumnHeader();
            DetalleOrden = new Label();
            IdProductoLabel = new Label();
            IdProductoBox = new TextBox();
            Fecha = new Label();
            FechaBox = new TextBox();
            IdClienteLabel = new Label();
            IdClienteBox = new TextBox();
            CantidadBox = new TextBox();
            CantidadLabel = new Label();
            ColumnaBox = new TextBox();
            ColumnaLabel = new Label();
            FilaBox = new TextBox();
            FilaLabel = new Label();
            AgregarBoton = new Button();
            EliminarBoton = new Button();
            ConfirmarBoton = new Button();
            SalirBoton = new Button();
            DepositoLabel = new Label();
            DepositoBox = new TextBox();
            IdOrdenBox = new TextBox();
            IdOrdenLabel = new Label();
            SuspendLayout();
            // 
            // Orden
            // 
            Orden.AutoSize = true;
            Orden.Location = new Point(12, 9);
            Orden.Name = "Orden";
            Orden.Size = new Size(133, 15);
            Orden.TabIndex = 0;
            Orden.Text = "Ordenes de preparacion";
            // 
            // DetallesList
            // 
            DetallesList.Columns.AddRange(new ColumnHeader[] { IDProducto, Cantidad, Deposito, Columna, Fila, FechaAlta });
            DetallesList.FullRowSelect = true;
            DetallesList.GridLines = true;
            DetallesList.Location = new Point(12, 210);
            DetallesList.Name = "DetallesList";
            DetallesList.Size = new Size(634, 216);
            DetallesList.TabIndex = 5;
            DetallesList.UseCompatibleStateImageBehavior = false;
            DetallesList.View = View.Details;
            DetallesList.SelectedIndexChanged += OrdenesList_SelectedIndexChanged;
            // 
            // IDProducto
            // 
            IDProducto.Text = "IDProducto";
            IDProducto.Width = 100;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 100;
            // 
            // Deposito
            // 
            Deposito.Text = "Deposito";
            Deposito.Width = 100;
            // 
            // Columna
            // 
            Columna.Text = "Columna";
            Columna.Width = 100;
            // 
            // Fila
            // 
            Fila.Text = "Fila";
            Fila.Width = 100;
            // 
            // FechaAlta
            // 
            FechaAlta.Text = "FechaAlta";
            FechaAlta.Width = 100;
            // 
            // DetalleOrden
            // 
            DetalleOrden.AutoSize = true;
            DetalleOrden.Location = new Point(12, 192);
            DetalleOrden.Name = "DetalleOrden";
            DetalleOrden.Size = new Size(43, 15);
            DetalleOrden.TabIndex = 6;
            DetalleOrden.Text = "Detalle";
            // 
            // IdProductoLabel
            // 
            IdProductoLabel.AutoSize = true;
            IdProductoLabel.Location = new Point(12, 87);
            IdProductoLabel.Name = "IdProductoLabel";
            IdProductoLabel.Size = new Size(69, 15);
            IdProductoLabel.TabIndex = 7;
            IdProductoLabel.Text = "Id Producto";
            // 
            // IdProductoBox
            // 
            IdProductoBox.Location = new Point(96, 79);
            IdProductoBox.MaxLength = 10;
            IdProductoBox.Name = "IdProductoBox";
            IdProductoBox.Size = new Size(223, 23);
            IdProductoBox.TabIndex = 8;
            // 
            // Fecha
            // 
            Fecha.AutoSize = true;
            Fecha.Location = new Point(443, 41);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(38, 15);
            Fecha.TabIndex = 9;
            Fecha.Text = "Fecha";
            // 
            // FechaBox
            // 
            FechaBox.Location = new Point(500, 33);
            FechaBox.MaxLength = 8;
            FechaBox.Name = "FechaBox";
            FechaBox.Size = new Size(113, 23);
            FechaBox.TabIndex = 10;
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(262, 36);
            IdClienteLabel.Name = "IdClienteLabel";
            IdClienteLabel.Size = new Size(57, 15);
            IdClienteLabel.TabIndex = 11;
            IdClienteLabel.Text = "Id Cliente";
            // 
            // IdClienteBox
            // 
            IdClienteBox.Location = new Point(325, 33);
            IdClienteBox.MaxLength = 10;
            IdClienteBox.Name = "IdClienteBox";
            IdClienteBox.Size = new Size(99, 23);
            IdClienteBox.TabIndex = 12;
            // 
            // CantidadBox
            // 
            CantidadBox.Location = new Point(441, 79);
            CantidadBox.MaxLength = 3;
            CantidadBox.Name = "CantidadBox";
            CantidadBox.Size = new Size(172, 23);
            CantidadBox.TabIndex = 14;
            // 
            // CantidadLabel
            // 
            CantidadLabel.AutoSize = true;
            CantidadLabel.Location = new Point(380, 87);
            CantidadLabel.Name = "CantidadLabel";
            CantidadLabel.Size = new Size(55, 15);
            CantidadLabel.TabIndex = 13;
            CantidadLabel.Text = "Cantidad";
            // 
            // ColumnaBox
            // 
            ColumnaBox.Location = new Point(325, 123);
            ColumnaBox.MaxLength = 2;
            ColumnaBox.Name = "ColumnaBox";
            ColumnaBox.Size = new Size(99, 23);
            ColumnaBox.TabIndex = 18;
            // 
            // ColumnaLabel
            // 
            ColumnaLabel.AutoSize = true;
            ColumnaLabel.Location = new Point(263, 131);
            ColumnaLabel.Name = "ColumnaLabel";
            ColumnaLabel.Size = new Size(56, 15);
            ColumnaLabel.TabIndex = 17;
            ColumnaLabel.Text = "Columna";
            // 
            // FilaBox
            // 
            FilaBox.Location = new Point(500, 123);
            FilaBox.MaxLength = 2;
            FilaBox.Name = "FilaBox";
            FilaBox.Size = new Size(113, 23);
            FilaBox.TabIndex = 20;
            // 
            // FilaLabel
            // 
            FilaLabel.AutoSize = true;
            FilaLabel.Location = new Point(456, 131);
            FilaLabel.Name = "FilaLabel";
            FilaLabel.Size = new Size(25, 15);
            FilaLabel.TabIndex = 19;
            FilaLabel.Text = "Fila";
            // 
            // AgregarBoton
            // 
            AgregarBoton.Location = new Point(517, 180);
            AgregarBoton.Name = "AgregarBoton";
            AgregarBoton.Size = new Size(129, 24);
            AgregarBoton.TabIndex = 21;
            AgregarBoton.Text = "Agregar";
            AgregarBoton.UseVisualStyleBackColor = true;
            AgregarBoton.Click += AgregarBoton_Click;
            // 
            // EliminarBoton
            // 
            EliminarBoton.Location = new Point(263, 437);
            EliminarBoton.Name = "EliminarBoton";
            EliminarBoton.Size = new Size(129, 24);
            EliminarBoton.TabIndex = 22;
            EliminarBoton.Text = "Eliminar";
            EliminarBoton.UseVisualStyleBackColor = true;
            EliminarBoton.Click += EliminarBoton_Click;
            // 
            // ConfirmarBoton
            // 
            ConfirmarBoton.Location = new Point(398, 437);
            ConfirmarBoton.Name = "ConfirmarBoton";
            ConfirmarBoton.Size = new Size(129, 24);
            ConfirmarBoton.TabIndex = 23;
            ConfirmarBoton.Text = "Confirmar";
            ConfirmarBoton.UseVisualStyleBackColor = true;
            ConfirmarBoton.Click += ConfirmarBoton_Click;
            // 
            // SalirBoton
            // 
            SalirBoton.Location = new Point(533, 437);
            SalirBoton.Name = "SalirBoton";
            SalirBoton.Size = new Size(129, 24);
            SalirBoton.TabIndex = 24;
            SalirBoton.Text = "Salir";
            SalirBoton.UseVisualStyleBackColor = true;
            SalirBoton.Click += SalirBoton_Click;
            // 
            // DepositoLabel
            // 
            DepositoLabel.AutoSize = true;
            DepositoLabel.Location = new Point(27, 131);
            DepositoLabel.Name = "DepositoLabel";
            DepositoLabel.Size = new Size(54, 15);
            DepositoLabel.TabIndex = 15;
            DepositoLabel.Text = "Deposito";
            // 
            // DepositoBox
            // 
            DepositoBox.Location = new Point(96, 123);
            DepositoBox.MaxLength = 10;
            DepositoBox.Name = "DepositoBox";
            DepositoBox.Size = new Size(149, 23);
            DepositoBox.TabIndex = 16;
            // 
            // IdOrdenBox
            // 
            IdOrdenBox.Location = new Point(96, 33);
            IdOrdenBox.MaxLength = 10;
            IdOrdenBox.Name = "IdOrdenBox";
            IdOrdenBox.Size = new Size(149, 23);
            IdOrdenBox.TabIndex = 26;
            // 
            // IdOrdenLabel
            // 
            IdOrdenLabel.AutoSize = true;
            IdOrdenLabel.Location = new Point(27, 41);
            IdOrdenLabel.Name = "IdOrdenLabel";
            IdOrdenLabel.Size = new Size(53, 15);
            IdOrdenLabel.TabIndex = 25;
            IdOrdenLabel.Text = "Id Orden";
            // 
            // FormOrdenDePreparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 473);
            Controls.Add(IdOrdenBox);
            Controls.Add(IdOrdenLabel);
            Controls.Add(SalirBoton);
            Controls.Add(ConfirmarBoton);
            Controls.Add(EliminarBoton);
            Controls.Add(AgregarBoton);
            Controls.Add(FilaBox);
            Controls.Add(FilaLabel);
            Controls.Add(ColumnaBox);
            Controls.Add(ColumnaLabel);
            Controls.Add(DepositoBox);
            Controls.Add(DepositoLabel);
            Controls.Add(CantidadBox);
            Controls.Add(CantidadLabel);
            Controls.Add(IdClienteBox);
            Controls.Add(IdClienteLabel);
            Controls.Add(FechaBox);
            Controls.Add(Fecha);
            Controls.Add(IdProductoBox);
            Controls.Add(IdProductoLabel);
            Controls.Add(DetalleOrden);
            Controls.Add(DetallesList);
            Controls.Add(Orden);
            Name = "FormOrdenDePreparacion";
            Text = "Ordenes";
            Load += Ordenes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Orden;
        private ListView DetallesList;
        private ColumnHeader IDProducto;
        private Label DetalleOrden;
        private ColumnHeader Cantidad;
        private ColumnHeader Deposito;
        private ColumnHeader Columna;
        private ColumnHeader Fila;
        private Label IdProductoLabel;
        private TextBox IdProductoBox;
        private Label Fecha;
        private TextBox FechaBox;
        private Label IdClienteLabel;
        private TextBox IdClienteBox;
        private TextBox CantidadBox;
        private Label CantidadLabel;
        private TextBox ColumnaBox;
        private Label ColumnaLabel;
        private TextBox FilaBox;
        private Label FilaLabel;
        private Button AgregarBoton;
        private Button EliminarBoton;
        private Button ConfirmarBoton;
        private Button SalirBoton;
        private ColumnHeader FechaAlta;
        private Label DepositoLabel;
        private TextBox DepositoBox;
        private TextBox IdOrdenBox;
        private Label IdOrdenLabel;
    }
}