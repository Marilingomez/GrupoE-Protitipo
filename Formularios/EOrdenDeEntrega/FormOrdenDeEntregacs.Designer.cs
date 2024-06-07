namespace GrupoE_Protitipos.OrdenDeEntrega
{
    partial class FormOrdenDeEntrega
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
            OrdenSeleccionadaList = new ListView();
            IDOrdenCol = new ColumnHeader();
            IDClienteCol = new ColumnHeader();
            IDProductosCol = new ColumnHeader();
            CantidadCol = new ColumnHeader();
            PosicionDepositoCol = new ColumnHeader();
            SeleccionarBoton = new Button();
            OrdenEntrega = new ListView();
            IDOrdenSCol = new ColumnHeader();
            IdClienteSCol = new ColumnHeader();
            IDProductosSCol = new ColumnHeader();
            CantidadSCol = new ColumnHeader();
            PosicionSCol = new ColumnHeader();
            GenerarBoton = new Button();
            VolverBoton = new Button();
            EliminarSeleccionBoton = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            fechaBox = new TextBox();
            depositoBox = new ComboBox();
            TransportistaCUITText = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            IDtext = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // OrdenSeleccionadaList
            // 
            OrdenSeleccionadaList.Columns.AddRange(new ColumnHeader[] { IDOrdenCol, IDClienteCol, IDProductosCol, CantidadCol, PosicionDepositoCol });
            OrdenSeleccionadaList.FullRowSelect = true;
            OrdenSeleccionadaList.Location = new Point(5, 22);
            OrdenSeleccionadaList.Margin = new Padding(3, 2, 3, 2);
            OrdenSeleccionadaList.Name = "OrdenSeleccionadaList";
            OrdenSeleccionadaList.Size = new Size(510, 143);
            OrdenSeleccionadaList.TabIndex = 0;
            OrdenSeleccionadaList.UseCompatibleStateImageBehavior = false;
            OrdenSeleccionadaList.View = View.Details;
            // 
            // IDOrdenCol
            // 
            IDOrdenCol.Text = "ID Orden ";
            IDOrdenCol.Width = 100;
            // 
            // IDClienteCol
            // 
            IDClienteCol.Text = "ID Cliente";
            IDClienteCol.Width = 100;
            // 
            // IDProductosCol
            // 
            IDProductosCol.Text = "ID Productos";
            IDProductosCol.Width = 100;
            // 
            // CantidadCol
            // 
            CantidadCol.Text = "Cantidad";
            CantidadCol.Width = 100;
            // 
            // PosicionDepositoCol
            // 
            PosicionDepositoCol.Text = "Posicion";
            PosicionDepositoCol.Width = 100;
            // 
            // SeleccionarBoton
            // 
            SeleccionarBoton.Location = new Point(30, 338);
            SeleccionarBoton.Margin = new Padding(3, 2, 3, 2);
            SeleccionarBoton.Name = "SeleccionarBoton";
            SeleccionarBoton.Size = new Size(122, 22);
            SeleccionarBoton.TabIndex = 1;
            SeleccionarBoton.Text = "Seleccionar";
            SeleccionarBoton.UseVisualStyleBackColor = true;
            SeleccionarBoton.Click += SeleccionarBoton_Click;
            // 
            // OrdenEntrega
            // 
            OrdenEntrega.Columns.AddRange(new ColumnHeader[] { IDOrdenSCol, IdClienteSCol, IDProductosSCol, CantidadSCol, PosicionSCol });
            OrdenEntrega.FullRowSelect = true;
            OrdenEntrega.Location = new Point(5, 20);
            OrdenEntrega.Margin = new Padding(3, 2, 3, 2);
            OrdenEntrega.Name = "OrdenEntrega";
            OrdenEntrega.Size = new Size(508, 125);
            OrdenEntrega.TabIndex = 2;
            OrdenEntrega.UseCompatibleStateImageBehavior = false;
            OrdenEntrega.View = View.Details;
            OrdenEntrega.SelectedIndexChanged += OrdenEntrega_SelectedIndexChanged;
            // 
            // IDOrdenSCol
            // 
            IDOrdenSCol.Text = "ID Orden";
            IDOrdenSCol.Width = 100;
            // 
            // IdClienteSCol
            // 
            IdClienteSCol.Text = "ID Cliente";
            IdClienteSCol.Width = 100;
            // 
            // IDProductosSCol
            // 
            IDProductosSCol.Text = "ID Productos";
            IDProductosSCol.Width = 100;
            // 
            // CantidadSCol
            // 
            CantidadSCol.Text = "Cantidad";
            CantidadSCol.Width = 100;
            // 
            // PosicionSCol
            // 
            PosicionSCol.Text = "Posicion";
            PosicionSCol.Width = 100;
            // 
            // GenerarBoton
            // 
            GenerarBoton.Location = new Point(196, 554);
            GenerarBoton.Margin = new Padding(3, 2, 3, 2);
            GenerarBoton.Name = "GenerarBoton";
            GenerarBoton.Size = new Size(126, 22);
            GenerarBoton.TabIndex = 3;
            GenerarBoton.Text = "Generar ";
            GenerarBoton.UseVisualStyleBackColor = true;
            GenerarBoton.Click += GenerarBoton_Click;
            // 
            // VolverBoton
            // 
            VolverBoton.Location = new Point(336, 554);
            VolverBoton.Margin = new Padding(3, 2, 3, 2);
            VolverBoton.Name = "VolverBoton";
            VolverBoton.Size = new Size(126, 22);
            VolverBoton.TabIndex = 4;
            VolverBoton.Text = "Volver";
            VolverBoton.UseVisualStyleBackColor = true;
            VolverBoton.Click += VolverBoton_Click;
            // 
            // EliminarSeleccionBoton
            // 
            EliminarSeleccionBoton.Location = new Point(30, 528);
            EliminarSeleccionBoton.Margin = new Padding(3, 2, 3, 2);
            EliminarSeleccionBoton.Name = "EliminarSeleccionBoton";
            EliminarSeleccionBoton.Size = new Size(122, 22);
            EliminarSeleccionBoton.TabIndex = 5;
            EliminarSeleccionBoton.Text = "Eliminar selección";
            EliminarSeleccionBoton.UseVisualStyleBackColor = true;
            EliminarSeleccionBoton.Click += CancelarBoton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OrdenSeleccionadaList);
            groupBox1.Location = new Point(26, 165);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(521, 169);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ordenes Preparadas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(OrdenEntrega);
            groupBox2.Location = new Point(26, 375);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(519, 149);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selección de Ordenes Preparadas";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(fechaBox);
            groupBox3.Controls.Add(depositoBox);
            groupBox3.Controls.Add(TransportistaCUITText);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(IDtext);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(26, 26);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(521, 124);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Orden de Entrega";
            // 
            // fechaBox
            // 
            fechaBox.Location = new Point(14, 85);
            fechaBox.Margin = new Padding(3, 2, 3, 2);
            fechaBox.Name = "fechaBox";
            fechaBox.ReadOnly = true;
            fechaBox.Size = new Size(198, 23);
            fechaBox.TabIndex = 10;
            // 
            // depositoBox
            // 
            depositoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            depositoBox.FormattingEnabled = true;
            depositoBox.Location = new Point(236, 86);
            depositoBox.Name = "depositoBox";
            depositoBox.Size = new Size(200, 23);
            depositoBox.TabIndex = 9;
            depositoBox.SelectedIndexChanged += DepositoBox_SelectedIndexChange;
            // 
            // TransportistaCUITText
            // 
            TransportistaCUITText.Location = new Point(236, 37);
            TransportistaCUITText.Margin = new Padding(3, 2, 3, 2);
            TransportistaCUITText.Name = "TransportistaCUITText";
            TransportistaCUITText.Size = new Size(198, 23);
            TransportistaCUITText.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 17);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 6;
            label4.Text = "Transportista CUIT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 68);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 68);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Deposito";
            // 
            // IDtext
            // 
            IDtext.Location = new Point(14, 37);
            IDtext.Margin = new Padding(3, 2, 3, 2);
            IDtext.Name = "IDtext";
            IDtext.ReadOnly = true;
            IDtext.Size = new Size(198, 23);
            IDtext.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // FormOrdenDeEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 601);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(EliminarSeleccionBoton);
            Controls.Add(VolverBoton);
            Controls.Add(GenerarBoton);
            Controls.Add(SeleccionarBoton);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormOrdenDeEntrega";
            Text = " ";
            Load += OrdenDeEntregacs_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView OrdenSeleccionadaList;
        private Button SeleccionarBoton;
        private ListView OrdenEntrega;
        private Button GenerarBoton;
        private Button VolverBoton;
        private Button EliminarSeleccionBoton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox IDtext;
        private Label label2;
        private ColumnHeader IDOrdenCol;
        private ColumnHeader IDClienteCol;
        private TextBox TransportistaCUITText;
        private Label label4;
        private Label label3;
        private ColumnHeader IDOrdenSCol;
        private ColumnHeader IdClienteSCol;
        private ColumnHeader IDProductosCol;
        private ColumnHeader CantidadCol;
        private ColumnHeader PosicionDepositoCol;
        private ColumnHeader IDProductosSCol;
        private ColumnHeader CantidadSCol;
        private ColumnHeader PosicionSCol;
        private ComboBox depositoBox;
        private TextBox fechaBox;
    }
}