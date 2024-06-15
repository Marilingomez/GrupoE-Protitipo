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
            DescripcionProducto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            DetalleOrden = new Label();
            IdProductoLabel = new Label();
            Fecha = new Label();
            FechaBox = new TextBox();
            IdClienteLabel = new Label();
            CantidadBox = new TextBox();
            CantidadLabel = new Label();
            AgregarBoton = new Button();
            EliminarBoton = new Button();
            ConfirmarBoton = new Button();
            SalirBoton = new Button();
            DepositoLabel = new Label();
            IdOrdenBox = new TextBox();
            IdOrdenLabel = new Label();
            DepositoBox = new ComboBox();
            ClienteBox = new ComboBox();
            productoBox = new ComboBox();
            transportistaLabel = new Label();
            transportistaBox = new ComboBox();
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
            DetallesList.Columns.AddRange(new ColumnHeader[] { IDProducto, DescripcionProducto, Cantidad });
            DetallesList.FullRowSelect = true;
            DetallesList.GridLines = true;
            DetallesList.Location = new Point(12, 210);
            DetallesList.MultiSelect = false;
            DetallesList.Name = "DetallesList";
            DetallesList.Size = new Size(634, 216);
            DetallesList.TabIndex = 5;
            DetallesList.UseCompatibleStateImageBehavior = false;
            DetallesList.View = View.Details;
            // 
            // IDProducto
            // 
            IDProducto.Text = "IDProducto";
            IDProducto.Width = 100;
            // 
            // DescripcionProducto
            // 
            DescripcionProducto.Text = "Descripción del producto";
            DescripcionProducto.Width = 100;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 100;
            // 
            // DetalleOrden
            // 
            DetalleOrden.AutoSize = true;
            DetalleOrden.Location = new Point(12, 192);
            DetalleOrden.Name = "DetalleOrden";
            DetalleOrden.Size = new Size(116, 15);
            DetalleOrden.TabIndex = 6;
            DetalleOrden.Text = "Detalle de productos";
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
            FechaBox.Enabled = false;
            FechaBox.Location = new Point(500, 33);
            FechaBox.MaxLength = 8;
            FechaBox.Name = "FechaBox";
            FechaBox.Size = new Size(113, 23);
            FechaBox.TabIndex = 10;
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(263, 36);
            IdClienteLabel.Name = "IdClienteLabel";
            IdClienteLabel.Size = new Size(44, 15);
            IdClienteLabel.TabIndex = 11;
            IdClienteLabel.Text = "Cliente";
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
            // IdOrdenBox
            // 
            IdOrdenBox.Enabled = false;
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
            // DepositoBox
            // 
            DepositoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DepositoBox.FormattingEnabled = true;
            DepositoBox.Location = new Point(96, 128);
            DepositoBox.Name = "DepositoBox";
            DepositoBox.Size = new Size(121, 23);
            DepositoBox.TabIndex = 27;
            // 
            // ClienteBox
            // 
            ClienteBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClienteBox.FormattingEnabled = true;
            ClienteBox.Location = new Point(316, 33);
            ClienteBox.Name = "ClienteBox";
            ClienteBox.Size = new Size(121, 23);
            ClienteBox.TabIndex = 28;
            // 
            // productoBox
            // 
            productoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productoBox.FormattingEnabled = true;
            productoBox.Location = new Point(96, 84);
            productoBox.Name = "productoBox";
            productoBox.Size = new Size(211, 23);
            productoBox.TabIndex = 29;
            // 
            // transportistaLabel
            // 
            transportistaLabel.AutoSize = true;
            transportistaLabel.Location = new Point(263, 131);
            transportistaLabel.Name = "transportistaLabel";
            transportistaLabel.Size = new Size(74, 15);
            transportistaLabel.TabIndex = 30;
            transportistaLabel.Text = "Transportista";
            // 
            // transportistaBox
            // 
            transportistaBox.DropDownStyle = ComboBoxStyle.DropDownList;
            transportistaBox.FormattingEnabled = true;
            transportistaBox.Location = new Point(360, 128);
            transportistaBox.Name = "transportistaBox";
            transportistaBox.Size = new Size(121, 23);
            transportistaBox.TabIndex = 31;
            // 
            // FormOrdenDePreparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 473);
            Controls.Add(transportistaBox);
            Controls.Add(transportistaLabel);
            Controls.Add(productoBox);
            Controls.Add(ClienteBox);
            Controls.Add(DepositoBox);
            Controls.Add(IdOrdenBox);
            Controls.Add(IdOrdenLabel);
            Controls.Add(SalirBoton);
            Controls.Add(ConfirmarBoton);
            Controls.Add(EliminarBoton);
            Controls.Add(AgregarBoton);
            Controls.Add(DepositoLabel);
            Controls.Add(CantidadBox);
            Controls.Add(CantidadLabel);
            Controls.Add(IdClienteLabel);
            Controls.Add(FechaBox);
            Controls.Add(Fecha);
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
        private Label IdProductoLabel;
        private Label Fecha;
        private TextBox FechaBox;
        private Label IdClienteLabel;
        private TextBox CantidadBox;
        private Label CantidadLabel;
        private Button AgregarBoton;
        private Button EliminarBoton;
        private Button ConfirmarBoton;
        private Button SalirBoton;
        private Label DepositoLabel;
        private TextBox IdOrdenBox;
        private Label IdOrdenLabel;
        private ColumnHeader DescripcionProducto;
        private ComboBox DepositoBox;
        private ComboBox ClienteBox;
        private ComboBox productoBox;
        private Label transportistaLabel;
        private ComboBox transportistaBox;
    }
}