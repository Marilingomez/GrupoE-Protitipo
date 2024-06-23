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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenDePreparacion));
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Orden
            // 
            Orden.AutoSize = true;
            Orden.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Orden.ForeColor = Color.FromArgb(161, 32, 89);
            Orden.Location = new Point(10, 39);
            Orden.Name = "Orden";
            Orden.Size = new Size(133, 15);
            Orden.TabIndex = 0;
            Orden.Text = "Ordenes de preparación";
            // 
            // DetallesList
            // 
            DetallesList.Columns.AddRange(new ColumnHeader[] { IDProducto, DescripcionProducto, Cantidad });
            DetallesList.FullRowSelect = true;
            DetallesList.Location = new Point(10, 240);
            DetallesList.MultiSelect = false;
            DetallesList.Name = "DetallesList";
            DetallesList.Size = new Size(634, 216);
            DetallesList.TabIndex = 5;
            DetallesList.UseCompatibleStateImageBehavior = false;
            DetallesList.View = View.Details;
            DetallesList.SelectedIndexChanged += DetallesList_SelectedIndexChanged;
            // 
            // IDProducto
            // 
            IDProducto.Text = "IDProducto";
            IDProducto.Width = 150;
            // 
            // DescripcionProducto
            // 
            DescripcionProducto.Text = "Descripción del producto";
            DescripcionProducto.Width = 350;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 150;
            // 
            // DetalleOrden
            // 
            DetalleOrden.AutoSize = true;
            DetalleOrden.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DetalleOrden.ForeColor = Color.FromArgb(161, 32, 89);
            DetalleOrden.Location = new Point(10, 222);
            DetalleOrden.Name = "DetalleOrden";
            DetalleOrden.Size = new Size(117, 15);
            DetalleOrden.TabIndex = 6;
            DetalleOrden.Text = "Detalle de productos";
            // 
            // IdProductoLabel
            // 
            IdProductoLabel.AutoSize = true;
            IdProductoLabel.Location = new Point(10, 117);
            IdProductoLabel.Name = "IdProductoLabel";
            IdProductoLabel.Size = new Size(56, 15);
            IdProductoLabel.TabIndex = 7;
            IdProductoLabel.Text = "Producto";
            // 
            // Fecha
            // 
            Fecha.AutoSize = true;
            Fecha.Location = new Point(474, 71);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(38, 15);
            Fecha.TabIndex = 9;
            Fecha.Text = "Fecha";
            // 
            // FechaBox
            // 
            FechaBox.Enabled = false;
            FechaBox.Location = new Point(521, 69);
            FechaBox.MaxLength = 8;
            FechaBox.Name = "FechaBox";
            FechaBox.Size = new Size(113, 23);
            FechaBox.TabIndex = 10;
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(240, 74);
            IdClienteLabel.Name = "IdClienteLabel";
            IdClienteLabel.Size = new Size(44, 15);
            IdClienteLabel.TabIndex = 11;
            IdClienteLabel.Text = "Cliente";
            // 
            // CantidadBox
            // 
            CantidadBox.Location = new Point(328, 117);
            CantidadBox.MaxLength = 3;
            CantidadBox.Name = "CantidadBox";
            CantidadBox.Size = new Size(121, 23);
            CantidadBox.TabIndex = 14;
            // 
            // CantidadLabel
            // 
            CantidadLabel.AutoSize = true;
            CantidadLabel.Location = new Point(240, 122);
            CantidadLabel.Name = "CantidadLabel";
            CantidadLabel.Size = new Size(55, 15);
            CantidadLabel.TabIndex = 13;
            CantidadLabel.Text = "Cantidad";
            CantidadLabel.Click += CantidadLabel_Click;
            // 
            // AgregarBoton
            // 
            AgregarBoton.BackColor = Color.FromArgb(161, 32, 89);
            AgregarBoton.ForeColor = SystemColors.ButtonHighlight;
            AgregarBoton.Location = new Point(515, 210);
            AgregarBoton.Name = "AgregarBoton";
            AgregarBoton.Size = new Size(129, 24);
            AgregarBoton.TabIndex = 21;
            AgregarBoton.Text = "Agregar";
            AgregarBoton.UseVisualStyleBackColor = false;
            AgregarBoton.Click += AgregarBoton_Click;
            // 
            // EliminarBoton
            // 
            EliminarBoton.BackColor = Color.FromArgb(161, 32, 89);
            EliminarBoton.ForeColor = SystemColors.ButtonHighlight;
            EliminarBoton.Location = new Point(375, 461);
            EliminarBoton.Name = "EliminarBoton";
            EliminarBoton.Size = new Size(129, 24);
            EliminarBoton.TabIndex = 22;
            EliminarBoton.Text = "Eliminar";
            EliminarBoton.UseVisualStyleBackColor = false;
            EliminarBoton.Click += EliminarBoton_Click;
            // 
            // ConfirmarBoton
            // 
            ConfirmarBoton.BackColor = Color.FromArgb(161, 32, 89);
            ConfirmarBoton.ForeColor = SystemColors.ButtonHighlight;
            ConfirmarBoton.Location = new Point(525, 461);
            ConfirmarBoton.Name = "ConfirmarBoton";
            ConfirmarBoton.Size = new Size(119, 24);
            ConfirmarBoton.TabIndex = 23;
            ConfirmarBoton.Text = "Confirmar";
            ConfirmarBoton.UseVisualStyleBackColor = false;
            ConfirmarBoton.Click += ConfirmarBoton_Click;
            // 
            // SalirBoton
            // 
            SalirBoton.BackColor = Color.FromArgb(161, 32, 89);
            SalirBoton.ForeColor = SystemColors.ButtonHighlight;
            SalirBoton.Location = new Point(525, 491);
            SalirBoton.Name = "SalirBoton";
            SalirBoton.Size = new Size(119, 24);
            SalirBoton.TabIndex = 24;
            SalirBoton.Text = "Volver al menu";
            SalirBoton.UseVisualStyleBackColor = false;
            SalirBoton.Click += SalirBoton_Click;
            // 
            // DepositoLabel
            // 
            DepositoLabel.AutoSize = true;
            DepositoLabel.Location = new Point(10, 161);
            DepositoLabel.Name = "DepositoLabel";
            DepositoLabel.Size = new Size(54, 15);
            DepositoLabel.TabIndex = 15;
            DepositoLabel.Text = "Deposito";
            // 
            // IdOrdenBox
            // 
            IdOrdenBox.Enabled = false;
            IdOrdenBox.Location = new Point(94, 69);
            IdOrdenBox.MaxLength = 10;
            IdOrdenBox.Name = "IdOrdenBox";
            IdOrdenBox.Size = new Size(134, 23);
            IdOrdenBox.TabIndex = 26;
            // 
            // IdOrdenLabel
            // 
            IdOrdenLabel.AutoSize = true;
            IdOrdenLabel.Location = new Point(10, 77);
            IdOrdenLabel.Name = "IdOrdenLabel";
            IdOrdenLabel.Size = new Size(53, 15);
            IdOrdenLabel.TabIndex = 25;
            IdOrdenLabel.Text = "Id Orden";
            // 
            // DepositoBox
            // 
            DepositoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DepositoBox.FormattingEnabled = true;
            DepositoBox.Location = new Point(94, 158);
            DepositoBox.Name = "DepositoBox";
            DepositoBox.Size = new Size(134, 23);
            DepositoBox.TabIndex = 27;
            // 
            // ClienteBox
            // 
            ClienteBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClienteBox.FormattingEnabled = true;
            ClienteBox.Location = new Point(328, 71);
            ClienteBox.Name = "ClienteBox";
            ClienteBox.Size = new Size(121, 23);
            ClienteBox.TabIndex = 28;
            // 
            // productoBox
            // 
            productoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productoBox.FormattingEnabled = true;
            productoBox.Location = new Point(94, 115);
            productoBox.Name = "productoBox";
            productoBox.Size = new Size(134, 23);
            productoBox.TabIndex = 29;
            // 
            // transportistaLabel
            // 
            transportistaLabel.AutoSize = true;
            transportistaLabel.Location = new Point(240, 164);
            transportistaLabel.Name = "transportistaLabel";
            transportistaLabel.Size = new Size(74, 15);
            transportistaLabel.TabIndex = 30;
            transportistaLabel.Text = "Transportista";
            // 
            // transportistaBox
            // 
            transportistaBox.DropDownStyle = ComboBoxStyle.DropDownList;
            transportistaBox.FormattingEnabled = true;
            transportistaBox.Location = new Point(328, 161);
            transportistaBox.Name = "transportistaBox";
            transportistaBox.Size = new Size(121, 23);
            transportistaBox.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(161, 32, 89);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 52);
            panel1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(253, 15);
            label3.Name = "label3";
            label3.Size = new Size(238, 31);
            label3.TabIndex = 33;
            label3.Text = "Orden de Preparación";
            // 
            // FormOrdenDePreparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(763, 695);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}