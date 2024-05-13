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
            ListViewItem listViewItem1 = new ListViewItem("10001");
            ProductoAingresarbtn = new Label();
            textBox6 = new TextBox();
            CrearOrdenderecepGbox = new GroupBox();
            groupBox1 = new GroupBox();
            OrdenSeleccionadaList = new ListView();
            OrdenCol = new ColumnHeader();
            ProdcutoCol = new ColumnHeader();
            CantidadCol = new ColumnHeader();
            ClienteCol = new ColumnHeader();
            RechazarOrdenRecepBtn = new Button();
            VolverOrdenRecepBtn = new Button();
            ConfirmarOrdenBtn = new Button();
            DepositoCol = new ColumnHeader();
            CrearOrdenderecepGbox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ProductoAingresarbtn
            // 
            ProductoAingresarbtn.AutoSize = true;
            ProductoAingresarbtn.Location = new Point(15, 20);
            ProductoAingresarbtn.Name = "ProductoAingresarbtn";
            ProductoAingresarbtn.Size = new Size(103, 15);
            ProductoAingresarbtn.TabIndex = 0;
            ProductoAingresarbtn.Text = "Numero de Orden";
            ProductoAingresarbtn.Click += ProductoAingresarbtn_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(14, 37);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(199, 23);
            textBox6.TabIndex = 1;
            // 
            // CrearOrdenderecepGbox
            // 
            CrearOrdenderecepGbox.Controls.Add(textBox6);
            CrearOrdenderecepGbox.Controls.Add(ProductoAingresarbtn);
            CrearOrdenderecepGbox.Location = new Point(25, 28);
            CrearOrdenderecepGbox.Margin = new Padding(3, 2, 3, 2);
            CrearOrdenderecepGbox.Name = "CrearOrdenderecepGbox";
            CrearOrdenderecepGbox.Padding = new Padding(3, 2, 3, 2);
            CrearOrdenderecepGbox.Size = new Size(257, 77);
            CrearOrdenderecepGbox.TabIndex = 15;
            CrearOrdenderecepGbox.TabStop = false;
            CrearOrdenderecepGbox.Text = "Orden de Recepcion";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OrdenSeleccionadaList);
            groupBox1.Location = new Point(25, 110);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(582, 118);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ordenes Seleccionadas";
            // 
            // OrdenSeleccionadaList
            // 
            OrdenSeleccionadaList.Columns.AddRange(new ColumnHeader[] { OrdenCol, ProdcutoCol, CantidadCol, ClienteCol, DepositoCol });
            OrdenSeleccionadaList.Items.AddRange(new ListViewItem[] { listViewItem1 });
            OrdenSeleccionadaList.Location = new Point(6, 16);
            OrdenSeleccionadaList.Margin = new Padding(3, 2, 3, 2);
            OrdenSeleccionadaList.Name = "OrdenSeleccionadaList";
            OrdenSeleccionadaList.Size = new Size(576, 92);
            OrdenSeleccionadaList.TabIndex = 0;
            OrdenSeleccionadaList.UseCompatibleStateImageBehavior = false;
            OrdenSeleccionadaList.View = View.Details;
            OrdenSeleccionadaList.SelectedIndexChanged += OrdenSeleccionadaList_SelectedIndexChanged;
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
            // RechazarOrdenRecepBtn
            // 
            RechazarOrdenRecepBtn.Location = new Point(481, 241);
            RechazarOrdenRecepBtn.Margin = new Padding(3, 2, 3, 2);
            RechazarOrdenRecepBtn.Name = "RechazarOrdenRecepBtn";
            RechazarOrdenRecepBtn.Size = new Size(126, 22);
            RechazarOrdenRecepBtn.TabIndex = 19;
            RechazarOrdenRecepBtn.Text = "Rechazar";
            RechazarOrdenRecepBtn.UseVisualStyleBackColor = true;
            // 
            // VolverOrdenRecepBtn
            // 
            VolverOrdenRecepBtn.Location = new Point(481, 278);
            VolverOrdenRecepBtn.Margin = new Padding(3, 2, 3, 2);
            VolverOrdenRecepBtn.Name = "VolverOrdenRecepBtn";
            VolverOrdenRecepBtn.Size = new Size(126, 22);
            VolverOrdenRecepBtn.TabIndex = 18;
            VolverOrdenRecepBtn.Text = "Volver";
            VolverOrdenRecepBtn.UseVisualStyleBackColor = true;
            VolverOrdenRecepBtn.Click += VolverOrdenRecepBtn_Click;
            // 
            // ConfirmarOrdenBtn
            // 
            ConfirmarOrdenBtn.Location = new Point(340, 241);
            ConfirmarOrdenBtn.Margin = new Padding(3, 2, 3, 2);
            ConfirmarOrdenBtn.Name = "ConfirmarOrdenBtn";
            ConfirmarOrdenBtn.Size = new Size(126, 22);
            ConfirmarOrdenBtn.TabIndex = 17;
            ConfirmarOrdenBtn.Text = "Confirmar";
            ConfirmarOrdenBtn.UseVisualStyleBackColor = true;
            ConfirmarOrdenBtn.Click += CrearOrdenBtn_Click;
            // 
            // DepositoCol
            // 
            DepositoCol.Text = "Depósito";
            // 
            // ConfirmarOrdenDeRecepcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 343);
            Controls.Add(RechazarOrdenRecepBtn);
            Controls.Add(VolverOrdenRecepBtn);
            Controls.Add(ConfirmarOrdenBtn);
            Controls.Add(groupBox1);
            Controls.Add(CrearOrdenderecepGbox);
            Margin = new Padding(2, 2, 2, 2);
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
        private Button RechazarOrdenRecepBtn;
        private Button VolverOrdenRecepBtn;
        private Button ConfirmarOrdenBtn;
        private ColumnHeader DepositoCol;
    }
}