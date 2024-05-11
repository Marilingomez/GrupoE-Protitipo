namespace GrupoE_Protitipos.Recepcion
{
    partial class ConfirmarOrdenDeRecepcion
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
            ProductoAingresarbtn = new Label();
            textBox6 = new TextBox();
            CrearOrdenderecepGbox = new GroupBox();
            groupBox1 = new GroupBox();
            OrdenSeleccionadaList = new ListView();
            OrdenCol = new ColumnHeader();
            ProdcutoCol = new ColumnHeader();
            CantidadCol = new ColumnHeader();
            ClienteCol = new ColumnHeader();
            CrearOrdenderecepGbox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ProductoAingresarbtn
            // 
            ProductoAingresarbtn.AutoSize = true;
            ProductoAingresarbtn.Location = new Point(22, 34);
            ProductoAingresarbtn.Margin = new Padding(4, 0, 4, 0);
            ProductoAingresarbtn.Name = "ProductoAingresarbtn";
            ProductoAingresarbtn.Size = new Size(157, 25);
            ProductoAingresarbtn.TabIndex = 0;
            ProductoAingresarbtn.Text = "Numero de Orden";
            ProductoAingresarbtn.Click += ProductoAingresarbtn_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(20, 61);
            textBox6.Margin = new Padding(4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(282, 31);
            textBox6.TabIndex = 1;
            // 
            // CrearOrdenderecepGbox
            // 
            CrearOrdenderecepGbox.Controls.Add(textBox6);
            CrearOrdenderecepGbox.Controls.Add(ProductoAingresarbtn);
            CrearOrdenderecepGbox.Location = new Point(36, 46);
            CrearOrdenderecepGbox.Margin = new Padding(4);
            CrearOrdenderecepGbox.Name = "CrearOrdenderecepGbox";
            CrearOrdenderecepGbox.Padding = new Padding(4);
            CrearOrdenderecepGbox.Size = new Size(367, 129);
            CrearOrdenderecepGbox.TabIndex = 15;
            CrearOrdenderecepGbox.TabStop = false;
            CrearOrdenderecepGbox.Text = "Orden de Recepcion";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OrdenSeleccionadaList);
            groupBox1.Location = new Point(36, 183);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(448, 196);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ordenes Seleccionadas";
            // 
            // OrdenSeleccionadaList
            // 
            OrdenSeleccionadaList.Columns.AddRange(new ColumnHeader[] { OrdenCol, ProdcutoCol, CantidadCol, ClienteCol });
            OrdenSeleccionadaList.Location = new Point(8, 26);
            OrdenSeleccionadaList.Margin = new Padding(4);
            OrdenSeleccionadaList.Name = "OrdenSeleccionadaList";
            OrdenSeleccionadaList.Size = new Size(410, 150);
            OrdenSeleccionadaList.TabIndex = 0;
            OrdenSeleccionadaList.UseCompatibleStateImageBehavior = false;
            OrdenSeleccionadaList.View = View.Details;
            // 
            // OrdenCol
            // 
            OrdenCol.Text = "Orden";
            OrdenCol.Width = 90;
            // 
            // ProdcutoCol
            // 
            ProdcutoCol.Text = "Producto";
            ProdcutoCol.Width = 120;
            // 
            // CantidadCol
            // 
            CantidadCol.Text = "Cantidad";
            CantidadCol.Width = 120;
            // 
            // ClienteCol
            // 
            ClienteCol.Text = "Cliente";
            ClienteCol.Width = 120;
            // 
            // ConfirmarOrdenDeRecepcion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 572);
            Controls.Add(groupBox1);
            Controls.Add(CrearOrdenderecepGbox);
            Name = "ConfirmarOrdenDeRecepcion";
            Text = "Confirmar orden de recepcion";
            CrearOrdenderecepGbox.ResumeLayout(false);
            CrearOrdenderecepGbox.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label ProductoAingresarbtn;
        private TextBox textBox6;
        private GroupBox CrearOrdenderecepGbox;
        private GroupBox groupBox1;
        private ListView OrdenSeleccionadaList;
        private ColumnHeader OrdenCol;
        private ColumnHeader ProdcutoCol;
        private ColumnHeader CantidadCol;
        private ColumnHeader ClienteCol;
    }
}