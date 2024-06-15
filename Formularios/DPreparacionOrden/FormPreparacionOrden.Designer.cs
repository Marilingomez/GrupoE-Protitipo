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
            SuspendLayout();
            // 
            // listOrdenesSeleccionada
            // 
            listOrdenesSeleccionada.Columns.AddRange(new ColumnHeader[] { IdOrden, IdCliente, Prioridad });
            listOrdenesSeleccionada.FullRowSelect = true;
            listOrdenesSeleccionada.Location = new Point(12, 69);
            listOrdenesSeleccionada.Name = "listOrdenesSeleccionada";
            listOrdenesSeleccionada.Size = new Size(392, 176);
            listOrdenesSeleccionada.TabIndex = 0;
            listOrdenesSeleccionada.UseCompatibleStateImageBehavior = false;
            listOrdenesSeleccionada.View = View.Details;
            listOrdenesSeleccionada.ItemSelectionChanged += listOrdenesSeleccionada_ListViewItemSelectionChanged;
            // 
            // IdOrden
            // 
            IdOrden.Text = "IdOrden";
            // 
            // IdCliente
            // 
            IdCliente.Text = "IdCliente";
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(201, 15);
            label1.TabIndex = 1;
            label1.Text = "Ordenes de preparación por preparar";
            // 
            // labelDetallePreparar
            // 
            labelDetallePreparar.AutoSize = true;
            labelDetallePreparar.Location = new Point(12, 263);
            labelDetallePreparar.Name = "labelDetallePreparar";
            labelDetallePreparar.Size = new Size(99, 15);
            labelDetallePreparar.TabIndex = 2;
            labelDetallePreparar.Text = "Detalle a preparar";
            // 
            // listaDetalleProducto
            // 
            listaDetalleProducto.Columns.AddRange(new ColumnHeader[] { IdProducto, Producto, Cantidad });
            listaDetalleProducto.FullRowSelect = true;
            listaDetalleProducto.Location = new Point(12, 281);
            listaDetalleProducto.Name = "listaDetalleProducto";
            listaDetalleProducto.Size = new Size(392, 176);
            listaDetalleProducto.TabIndex = 3;
            listaDetalleProducto.UseCompatibleStateImageBehavior = false;
            listaDetalleProducto.View = View.Details;
            // 
            // IdProducto
            // 
            IdProducto.Text = "IdProducto";
            IdProducto.Width = 80;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 80;
            // 
            // btnProductoPreparado
            // 
            btnProductoPreparado.Location = new Point(410, 281);
            btnProductoPreparado.Name = "btnProductoPreparado";
            btnProductoPreparado.Size = new Size(264, 23);
            btnProductoPreparado.TabIndex = 4;
            btnProductoPreparado.Text = "Producto embalado";
            btnProductoPreparado.UseVisualStyleBackColor = true;
            btnProductoPreparado.Click += btnProductoPreparado_Click;
            // 
            // btnConfirmaOrdenPreparada
            // 
            btnConfirmaOrdenPreparada.Location = new Point(410, 69);
            btnConfirmaOrdenPreparada.Name = "btnConfirmaOrdenPreparada";
            btnConfirmaOrdenPreparada.Size = new Size(264, 23);
            btnConfirmaOrdenPreparada.TabIndex = 5;
            btnConfirmaOrdenPreparada.Text = "Confirma Orden Preparada";
            btnConfirmaOrdenPreparada.UseVisualStyleBackColor = true;
            btnConfirmaOrdenPreparada.Click += btnConfirmaOrdenPreparada_Click;
            // 
            // depositoLabel
            // 
            depositoLabel.AutoSize = true;
            depositoLabel.Location = new Point(12, 19);
            depositoLabel.Name = "depositoLabel";
            depositoLabel.Size = new Size(54, 15);
            depositoLabel.TabIndex = 6;
            depositoLabel.Text = "Deposito";
            // 
            // depositoBox
            // 
            depositoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            depositoBox.FormattingEnabled = true;
            depositoBox.Location = new Point(92, 16);
            depositoBox.Name = "depositoBox";
            depositoBox.Size = new Size(182, 23);
            depositoBox.TabIndex = 7;
            depositoBox.SelectedIndexChanged += depositoBox_SelectedIndexChanged;
            // 
            // FormPreparacionOrden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(depositoBox);
            Controls.Add(depositoLabel);
            Controls.Add(btnConfirmaOrdenPreparada);
            Controls.Add(btnProductoPreparado);
            Controls.Add(listaDetalleProducto);
            Controls.Add(labelDetallePreparar);
            Controls.Add(label1);
            Controls.Add(listOrdenesSeleccionada);
            Name = "FormPreparacionOrden";
            Text = "FormPreparacionOrden";
            Load += FormPreparacionOrden_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}