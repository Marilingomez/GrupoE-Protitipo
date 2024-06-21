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
            Pampazon = new GroupBox();
            Pampazon.SuspendLayout();
            SuspendLayout();
            // 
            // listOrdenesSeleccionada
            // 
            listOrdenesSeleccionada.Columns.AddRange(new ColumnHeader[] { IdOrden, IdCliente, Prioridad });
            listOrdenesSeleccionada.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listOrdenesSeleccionada.FullRowSelect = true;
            listOrdenesSeleccionada.Location = new Point(20, 111);
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
            label1.BackColor = Color.CornflowerBlue;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(20, 89);
            label1.Name = "label1";
            label1.Size = new Size(392, 26);
            label1.TabIndex = 1;
            label1.Text = "Ordenes de preparación por preparar";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDetallePreparar
            // 
            labelDetallePreparar.BackColor = Color.CornflowerBlue;
            labelDetallePreparar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDetallePreparar.ForeColor = SystemColors.ControlLightLight;
            labelDetallePreparar.Location = new Point(20, 310);
            labelDetallePreparar.Name = "labelDetallePreparar";
            labelDetallePreparar.Size = new Size(392, 26);
            labelDetallePreparar.TabIndex = 2;
            labelDetallePreparar.Text = "Detalle a preparar";
            labelDetallePreparar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listaDetalleProducto
            // 
            listaDetalleProducto.Columns.AddRange(new ColumnHeader[] { IdProducto, Producto, Cantidad });
            listaDetalleProducto.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listaDetalleProducto.FullRowSelect = true;
            listaDetalleProducto.Location = new Point(20, 332);
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
            btnProductoPreparado.BackColor = Color.CornflowerBlue;
            btnProductoPreparado.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductoPreparado.ForeColor = SystemColors.ButtonFace;
            btnProductoPreparado.Location = new Point(449, 338);
            btnProductoPreparado.Name = "btnProductoPreparado";
            btnProductoPreparado.Size = new Size(264, 32);
            btnProductoPreparado.TabIndex = 4;
            btnProductoPreparado.Text = "Producto embalado";
            btnProductoPreparado.UseVisualStyleBackColor = false;
            btnProductoPreparado.Click += btnProductoPreparado_Click;
            // 
            // btnConfirmaOrdenPreparada
            // 
            btnConfirmaOrdenPreparada.BackColor = Color.FromArgb(46, 189, 37);
            btnConfirmaOrdenPreparada.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmaOrdenPreparada.ForeColor = SystemColors.ButtonFace;
            btnConfirmaOrdenPreparada.Location = new Point(449, 126);
            btnConfirmaOrdenPreparada.Margin = new Padding(0);
            btnConfirmaOrdenPreparada.Name = "btnConfirmaOrdenPreparada";
            btnConfirmaOrdenPreparada.Size = new Size(264, 31);
            btnConfirmaOrdenPreparada.TabIndex = 5;
            btnConfirmaOrdenPreparada.Text = "Confirma Orden Preparada";
            btnConfirmaOrdenPreparada.UseVisualStyleBackColor = false;
            btnConfirmaOrdenPreparada.Click += btnConfirmaOrdenPreparada_Click;
            // 
            // depositoLabel
            // 
            depositoLabel.AutoSize = true;
            depositoLabel.BackColor = Color.CornflowerBlue;
            depositoLabel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            depositoLabel.ForeColor = SystemColors.ButtonFace;
            depositoLabel.Location = new Point(51, 76);
            depositoLabel.Name = "depositoLabel";
            depositoLabel.Size = new Size(72, 18);
            depositoLabel.TabIndex = 6;
            depositoLabel.Text = "Deposito";
            // 
            // depositoBox
            // 
            depositoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            depositoBox.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            depositoBox.FormattingEnabled = true;
            depositoBox.Location = new Point(131, 73);
            depositoBox.Name = "depositoBox";
            depositoBox.Size = new Size(182, 25);
            depositoBox.TabIndex = 7;
            depositoBox.SelectedIndexChanged += depositoBox_SelectedIndexChanged;
            // 
            // Pampazon
            // 
            Pampazon.BackColor = SystemColors.ControlLight;
            Pampazon.Controls.Add(listaDetalleProducto);
            Pampazon.Controls.Add(labelDetallePreparar);
            Pampazon.Controls.Add(listOrdenesSeleccionada);
            Pampazon.Controls.Add(label1);
            Pampazon.Location = new Point(31, 28);
            Pampazon.Margin = new Padding(0);
            Pampazon.Name = "Pampazon";
            Pampazon.Padding = new Padding(0);
            Pampazon.Size = new Size(776, 561);
            Pampazon.TabIndex = 8;
            Pampazon.TabStop = false;
            // 
            // FormPreparacionOrden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 615);
            Controls.Add(depositoBox);
            Controls.Add(depositoLabel);
            Controls.Add(btnConfirmaOrdenPreparada);
            Controls.Add(btnProductoPreparado);
            Controls.Add(Pampazon);
            Name = "FormPreparacionOrden";
            Text = "FormPreparacionOrden";
            Load += FormPreparacionOrden_Load;
            Pampazon.ResumeLayout(false);
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
        private GroupBox Pampazon;
    }
}