namespace GrupoE_Protitipos.DPreparacionOrden
{
    partial class FormPreparacionOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreparacionOrden));
            listOrdenesSeleccionada = new ListView();
            IdOrden = new ColumnHeader();
            IdCliente = new ColumnHeader();
            Prioridad = new ColumnHeader();
            label1 = new Label();
            labelDetallePreparar = new Label();
            listaDetalleProducto = new ListView();
            IdProducto = new ColumnHeader();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            btnProductoPreparado = new Button();
            btnConfirmaOrdenPreparada = new Button();
            depositoLabel = new Label();
            depositoBox = new ComboBox();
            Pampazon = new GroupBox();
            VolverBoton = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            Pampazon.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listOrdenesSeleccionada
            // 
            listOrdenesSeleccionada.Columns.AddRange(new ColumnHeader[] { IdOrden, IdCliente, Prioridad });
            listOrdenesSeleccionada.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listOrdenesSeleccionada.FullRowSelect = true;
            listOrdenesSeleccionada.Location = new Point(22, 93);
            listOrdenesSeleccionada.Margin = new Padding(3, 4, 3, 4);
            listOrdenesSeleccionada.Name = "listOrdenesSeleccionada";
            listOrdenesSeleccionada.Size = new Size(447, 233);
            listOrdenesSeleccionada.TabIndex = 0;
            listOrdenesSeleccionada.UseCompatibleStateImageBehavior = false;
            listOrdenesSeleccionada.View = View.Details;
            listOrdenesSeleccionada.ItemSelectionChanged += listOrdenesSeleccionada_ListViewItemSelectionChanged;
            // 
            // IdOrden
            // 
            IdOrden.Text = "IdOrden";
            IdOrden.Width = 120;
            // 
            // IdCliente
            // 
            IdCliente.Text = "IdCliente";
            IdCliente.Width = 120;
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            Prioridad.Width = 120;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(161, 32, 89);
            label1.Location = new Point(22, 64);
            label1.Name = "label1";
            label1.Size = new Size(448, 35);
            label1.TabIndex = 1;
            label1.Text = "Ordenes de preparación por preparar";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDetallePreparar
            // 
            labelDetallePreparar.BackColor = SystemColors.ButtonHighlight;
            labelDetallePreparar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDetallePreparar.ForeColor = Color.FromArgb(161, 32, 89);
            labelDetallePreparar.Location = new Point(21, 353);
            labelDetallePreparar.Name = "labelDetallePreparar";
            labelDetallePreparar.Size = new Size(448, 35);
            labelDetallePreparar.TabIndex = 2;
            labelDetallePreparar.Text = "Detalle a preparar";
            labelDetallePreparar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listaDetalleProducto
            // 
            listaDetalleProducto.Columns.AddRange(new ColumnHeader[] { IdProducto, Producto, Cantidad });
            listaDetalleProducto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listaDetalleProducto.FullRowSelect = true;
            listaDetalleProducto.Location = new Point(22, 383);
            listaDetalleProducto.Margin = new Padding(3, 4, 3, 4);
            listaDetalleProducto.Name = "listaDetalleProducto";
            listaDetalleProducto.Size = new Size(447, 233);
            listaDetalleProducto.TabIndex = 3;
            listaDetalleProducto.UseCompatibleStateImageBehavior = false;
            listaDetalleProducto.View = View.Details;
            // 
            // IdProducto
            // 
            IdProducto.Text = "IdProducto";
            IdProducto.Width = 120;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 120;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 120;
            // 
            // btnProductoPreparado
            // 
            btnProductoPreparado.BackColor = Color.FromArgb(161, 32, 89);
            btnProductoPreparado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductoPreparado.ForeColor = SystemColors.ButtonFace;
            btnProductoPreparado.Location = new Point(475, 292);
            btnProductoPreparado.Margin = new Padding(3, 4, 3, 4);
            btnProductoPreparado.Name = "btnProductoPreparado";
            btnProductoPreparado.Size = new Size(286, 34);
            btnProductoPreparado.TabIndex = 4;
            btnProductoPreparado.Text = "Producto embalado";
            btnProductoPreparado.UseVisualStyleBackColor = false;
            btnProductoPreparado.Click += btnProductoPreparado_Click;
            // 
            // btnConfirmaOrdenPreparada
            // 
            btnConfirmaOrdenPreparada.BackColor = Color.FromArgb(161, 32, 89);
            btnConfirmaOrdenPreparada.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmaOrdenPreparada.ForeColor = SystemColors.ButtonFace;
            btnConfirmaOrdenPreparada.Location = new Point(475, 581);
            btnConfirmaOrdenPreparada.Margin = new Padding(0);
            btnConfirmaOrdenPreparada.Name = "btnConfirmaOrdenPreparada";
            btnConfirmaOrdenPreparada.Size = new Size(286, 35);
            btnConfirmaOrdenPreparada.TabIndex = 5;
            btnConfirmaOrdenPreparada.Text = "Confirma Orden Preparada";
            btnConfirmaOrdenPreparada.UseVisualStyleBackColor = false;
            btnConfirmaOrdenPreparada.Click += btnConfirmaOrdenPreparada_Click;
            // 
            // depositoLabel
            // 
            depositoLabel.AutoSize = true;
            depositoLabel.BackColor = Color.White;
            depositoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            depositoLabel.ForeColor = Color.Black;
            depositoLabel.Location = new Point(22, 24);
            depositoLabel.Name = "depositoLabel";
            depositoLabel.Size = new Size(70, 20);
            depositoLabel.TabIndex = 6;
            depositoLabel.Text = "Deposito";
            // 
            // depositoBox
            // 
            depositoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            depositoBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            depositoBox.FormattingEnabled = true;
            depositoBox.Location = new Point(114, 24);
            depositoBox.Margin = new Padding(3, 4, 3, 4);
            depositoBox.Name = "depositoBox";
            depositoBox.Size = new Size(207, 28);
            depositoBox.TabIndex = 7;
            depositoBox.SelectedIndexChanged += depositoBox_SelectedIndexChanged;
            // 
            // Pampazon
            // 
            Pampazon.BackColor = SystemColors.ButtonHighlight;
            Pampazon.Controls.Add(VolverBoton);
            Pampazon.Controls.Add(depositoLabel);
            Pampazon.Controls.Add(depositoBox);
            Pampazon.Controls.Add(btnProductoPreparado);
            Pampazon.Controls.Add(listaDetalleProducto);
            Pampazon.Controls.Add(labelDetallePreparar);
            Pampazon.Controls.Add(btnConfirmaOrdenPreparada);
            Pampazon.Controls.Add(listOrdenesSeleccionada);
            Pampazon.Controls.Add(label1);
            Pampazon.Location = new Point(35, 69);
            Pampazon.Margin = new Padding(0);
            Pampazon.Name = "Pampazon";
            Pampazon.Padding = new Padding(0);
            Pampazon.Size = new Size(786, 696);
            Pampazon.TabIndex = 8;
            Pampazon.TabStop = false;
            // 
            // VolverBoton
            // 
            VolverBoton.BackColor = Color.FromArgb(161, 32, 89);
            VolverBoton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            VolverBoton.ForeColor = SystemColors.ButtonFace;
            VolverBoton.Location = new Point(599, 634);
            VolverBoton.Margin = new Padding(0);
            VolverBoton.Name = "VolverBoton";
            VolverBoton.Size = new Size(162, 35);
            VolverBoton.TabIndex = 8;
            VolverBoton.Text = "Volver al menu";
            VolverBoton.UseVisualStyleBackColor = false;
            VolverBoton.Click += VolverBoton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(161, 32, 89);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 52);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(304, 18);
            label4.Name = "label4";
            label4.Size = new Size(171, 31);
            label4.TabIndex = 20;
            label4.Text = "Preparar Orden";
            // 
            // FormPreparacionOrden
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(824, 767);
            Controls.Add(panel1);
            Controls.Add(Pampazon);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPreparacionOrden";
            Text = "Preparar Mercaderia a Entregar";
            Load += FormPreparacionOrden_Load;
            Pampazon.ResumeLayout(false);
            Pampazon.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView listOrdenesSeleccionada;
        private Label label1;
        private ColumnHeader IdOrden;
        private ColumnHeader IdCliente;
        private ColumnHeader Prioridad;
        private Label labelDetallePreparar;
        private ListView listaDetalleProducto;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private Button btnProductoPreparado;
        private Button btnConfirmaOrdenPreparada;
        private ColumnHeader IdProducto;
        private Label depositoLabel;
        private ComboBox depositoBox;
        private GroupBox Pampazon;
        private Panel panel1;
        private Button VolverBoton;
        private Label label4;
        private PictureBox pictureBox1;
    }
}