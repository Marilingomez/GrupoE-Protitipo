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
            Orden.Location = new Point(11, 52);
            Orden.Name = "Orden";
            Orden.Size = new Size(174, 20);
            Orden.TabIndex = 0;
            Orden.Text = "Ordenes de preparación";
            // 
            // DetallesList
            // 
            DetallesList.Columns.AddRange(new ColumnHeader[] { IDProducto, DescripcionProducto, Cantidad });
            DetallesList.FullRowSelect = true;
            DetallesList.Location = new Point(11, 320);
            DetallesList.Margin = new Padding(3, 4, 3, 4);
            DetallesList.MultiSelect = false;
            DetallesList.Name = "DetallesList";
            DetallesList.Size = new Size(724, 287);
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
            DetalleOrden.Location = new Point(11, 296);
            DetalleOrden.Name = "DetalleOrden";
            DetalleOrden.Size = new Size(151, 20);
            DetalleOrden.TabIndex = 6;
            DetalleOrden.Text = "Detalle de productos";
            // 
            // IdProductoLabel
            // 
            IdProductoLabel.AutoSize = true;
            IdProductoLabel.Location = new Point(11, 156);
            IdProductoLabel.Name = "IdProductoLabel";
            IdProductoLabel.Size = new Size(69, 20);
            IdProductoLabel.TabIndex = 7;
            IdProductoLabel.Text = "Producto";
            // 
            // Fecha
            // 
            Fecha.AutoSize = true;
            Fecha.Location = new Point(542, 95);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(47, 20);
            Fecha.TabIndex = 9;
            Fecha.Text = "Fecha";
            // 
            // FechaBox
            // 
            FechaBox.Enabled = false;
            FechaBox.Location = new Point(595, 92);
            FechaBox.Margin = new Padding(3, 4, 3, 4);
            FechaBox.MaxLength = 8;
            FechaBox.Name = "FechaBox";
            FechaBox.Size = new Size(129, 27);
            FechaBox.TabIndex = 10;
            // 
            // IdClienteLabel
            // 
            IdClienteLabel.AutoSize = true;
            IdClienteLabel.Location = new Point(274, 99);
            IdClienteLabel.Name = "IdClienteLabel";
            IdClienteLabel.Size = new Size(55, 20);
            IdClienteLabel.TabIndex = 11;
            IdClienteLabel.Text = "Cliente";
            // 
            // CantidadBox
            // 
            CantidadBox.Location = new Point(375, 156);
            CantidadBox.Margin = new Padding(3, 4, 3, 4);
            CantidadBox.MaxLength = 5;
            CantidadBox.Name = "CantidadBox";
            CantidadBox.Size = new Size(138, 27);
            CantidadBox.TabIndex = 14;
            // 
            // CantidadLabel
            // 
            CantidadLabel.AutoSize = true;
            CantidadLabel.Location = new Point(274, 163);
            CantidadLabel.Name = "CantidadLabel";
            CantidadLabel.Size = new Size(69, 20);
            CantidadLabel.TabIndex = 13;
            CantidadLabel.Text = "Cantidad";
            CantidadLabel.Click += CantidadLabel_Click;
            // 
            // AgregarBoton
            // 
            AgregarBoton.BackColor = Color.FromArgb(161, 32, 89);
            AgregarBoton.ForeColor = SystemColors.ButtonHighlight;
            AgregarBoton.Location = new Point(589, 280);
            AgregarBoton.Margin = new Padding(3, 4, 3, 4);
            AgregarBoton.Name = "AgregarBoton";
            AgregarBoton.Size = new Size(147, 32);
            AgregarBoton.TabIndex = 21;
            AgregarBoton.Text = "Agregar";
            AgregarBoton.UseVisualStyleBackColor = false;
            AgregarBoton.Click += AgregarBoton_Click;
            // 
            // EliminarBoton
            // 
            EliminarBoton.BackColor = Color.FromArgb(161, 32, 89);
            EliminarBoton.ForeColor = SystemColors.ButtonHighlight;
            EliminarBoton.Location = new Point(429, 615);
            EliminarBoton.Margin = new Padding(3, 4, 3, 4);
            EliminarBoton.Name = "EliminarBoton";
            EliminarBoton.Size = new Size(147, 32);
            EliminarBoton.TabIndex = 22;
            EliminarBoton.Text = "Eliminar";
            EliminarBoton.UseVisualStyleBackColor = false;
            EliminarBoton.Click += EliminarBoton_Click;
            // 
            // ConfirmarBoton
            // 
            ConfirmarBoton.BackColor = Color.FromArgb(161, 32, 89);
            ConfirmarBoton.ForeColor = SystemColors.ButtonHighlight;
            ConfirmarBoton.Location = new Point(600, 615);
            ConfirmarBoton.Margin = new Padding(3, 4, 3, 4);
            ConfirmarBoton.Name = "ConfirmarBoton";
            ConfirmarBoton.Size = new Size(136, 32);
            ConfirmarBoton.TabIndex = 23;
            ConfirmarBoton.Text = "Confirmar";
            ConfirmarBoton.UseVisualStyleBackColor = false;
            ConfirmarBoton.Click += ConfirmarBoton_Click;
            // 
            // SalirBoton
            // 
            SalirBoton.BackColor = Color.FromArgb(161, 32, 89);
            SalirBoton.ForeColor = SystemColors.ButtonHighlight;
            SalirBoton.Location = new Point(600, 655);
            SalirBoton.Margin = new Padding(3, 4, 3, 4);
            SalirBoton.Name = "SalirBoton";
            SalirBoton.Size = new Size(136, 32);
            SalirBoton.TabIndex = 24;
            SalirBoton.Text = "Volver al menu";
            SalirBoton.UseVisualStyleBackColor = false;
            SalirBoton.Click += SalirBoton_Click;
            // 
            // DepositoLabel
            // 
            DepositoLabel.AutoSize = true;
            DepositoLabel.Location = new Point(11, 215);
            DepositoLabel.Name = "DepositoLabel";
            DepositoLabel.Size = new Size(70, 20);
            DepositoLabel.TabIndex = 15;
            DepositoLabel.Text = "Deposito";
            // 
            // IdOrdenBox
            // 
            IdOrdenBox.Enabled = false;
            IdOrdenBox.Location = new Point(107, 92);
            IdOrdenBox.Margin = new Padding(3, 4, 3, 4);
            IdOrdenBox.MaxLength = 10;
            IdOrdenBox.Name = "IdOrdenBox";
            IdOrdenBox.Size = new Size(153, 27);
            IdOrdenBox.TabIndex = 26;
            // 
            // IdOrdenLabel
            // 
            IdOrdenLabel.AutoSize = true;
            IdOrdenLabel.Location = new Point(11, 103);
            IdOrdenLabel.Name = "IdOrdenLabel";
            IdOrdenLabel.Size = new Size(67, 20);
            IdOrdenLabel.TabIndex = 25;
            IdOrdenLabel.Text = "Id Orden";
            // 
            // DepositoBox
            // 
            DepositoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DepositoBox.FormattingEnabled = true;
            DepositoBox.Location = new Point(107, 211);
            DepositoBox.Margin = new Padding(3, 4, 3, 4);
            DepositoBox.Name = "DepositoBox";
            DepositoBox.Size = new Size(153, 28);
            DepositoBox.TabIndex = 27;
            // 
            // ClienteBox
            // 
            ClienteBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClienteBox.FormattingEnabled = true;
            ClienteBox.Location = new Point(375, 95);
            ClienteBox.Margin = new Padding(3, 4, 3, 4);
            ClienteBox.Name = "ClienteBox";
            ClienteBox.Size = new Size(138, 28);
            ClienteBox.TabIndex = 28;
            // 
            // productoBox
            // 
            productoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productoBox.FormattingEnabled = true;
            productoBox.Location = new Point(107, 153);
            productoBox.Margin = new Padding(3, 4, 3, 4);
            productoBox.Name = "productoBox";
            productoBox.Size = new Size(153, 28);
            productoBox.TabIndex = 29;
            // 
            // transportistaLabel
            // 
            transportistaLabel.AutoSize = true;
            transportistaLabel.Location = new Point(274, 219);
            transportistaLabel.Name = "transportistaLabel";
            transportistaLabel.Size = new Size(94, 20);
            transportistaLabel.TabIndex = 30;
            transportistaLabel.Text = "Transportista";
            // 
            // transportistaBox
            // 
            transportistaBox.DropDownStyle = ComboBoxStyle.DropDownList;
            transportistaBox.FormattingEnabled = true;
            transportistaBox.Location = new Point(375, 215);
            transportistaBox.Margin = new Padding(3, 4, 3, 4);
            transportistaBox.Name = "transportistaBox";
            transportistaBox.Size = new Size(138, 28);
            transportistaBox.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(161, 32, 89);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 52);
            panel1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-13, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
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
            label3.Location = new Point(289, 20);
            label3.Name = "label3";
            label3.Size = new Size(238, 31);
            label3.TabIndex = 33;
            label3.Text = "Orden de Preparación";
            // 
            // FormOrdenDePreparacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(763, 693);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormOrdenDePreparacion";
            Text = "Orden de Preparación";
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