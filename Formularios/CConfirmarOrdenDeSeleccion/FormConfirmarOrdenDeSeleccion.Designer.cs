namespace GrupoE_Protitipos.ConfirmarOrdenDeSeleccion
{
    partial class FormConfirmarOrdenDeSeleccion
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnConfirmar = new Button();
            MenuPrincipalVolver = new Button();
            listDetalleOrden = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            pasillo = new ColumnHeader();
            fechaBox = new TextBox();
            listaOrdenesEnSeleccion = new ListView();
            Id = new ColumnHeader();
            FechaDeCreacion = new ColumnHeader();
            depositoBox = new ComboBox();
            Deposito = new Label();
            Fila = new ColumnHeader();
            estante = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 5;
            label1.Text = "Ordenes de Seleccion pendientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 199);
            label2.Name = "label2";
            label2.Size = new Size(232, 15);
            label2.TabIndex = 7;
            label2.Text = "Detalle de la Orden de Seleccion pendiente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 369);
            label3.Name = "label3";
            label3.Size = new Size(296, 15);
            label3.TabIndex = 8;
            label3.Text = "Fecha de recepcion de mercaderia en Area Preparacion";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(418, 437);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(101, 23);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_click;
            // 
            // MenuPrincipalVolver
            // 
            MenuPrincipalVolver.Location = new Point(418, 483);
            MenuPrincipalVolver.Name = "MenuPrincipalVolver";
            MenuPrincipalVolver.Size = new Size(101, 23);
            MenuPrincipalVolver.TabIndex = 11;
            MenuPrincipalVolver.Text = "Menu principal";
            MenuPrincipalVolver.UseVisualStyleBackColor = true;
            // 
            // listDetalleOrden
            // 
            listDetalleOrden.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, pasillo, Fila, estante });
            listDetalleOrden.FullRowSelect = true;
            listDetalleOrden.Location = new Point(12, 217);
            listDetalleOrden.Name = "listDetalleOrden";
            listDetalleOrden.Size = new Size(507, 135);
            listDetalleOrden.TabIndex = 12;
            listDetalleOrden.UseCompatibleStateImageBehavior = false;
            listDetalleOrden.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Producto";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            columnHeader2.Width = 90;
            // 
            // pasillo
            // 
            pasillo.Text = "Pasillo";
            pasillo.Width = 90;
            // 
            // fechaBox
            // 
            fechaBox.Enabled = false;
            fechaBox.Location = new Point(12, 387);
            fechaBox.Name = "fechaBox";
            fechaBox.Size = new Size(100, 23);
            fechaBox.TabIndex = 13;
            // 
            // listaOrdenesEnSeleccion
            // 
            listaOrdenesEnSeleccion.Columns.AddRange(new ColumnHeader[] { Id, FechaDeCreacion });
            listaOrdenesEnSeleccion.FullRowSelect = true;
            listaOrdenesEnSeleccion.Location = new Point(12, 56);
            listaOrdenesEnSeleccion.MultiSelect = false;
            listaOrdenesEnSeleccion.Name = "listaOrdenesEnSeleccion";
            listaOrdenesEnSeleccion.Size = new Size(507, 130);
            listaOrdenesEnSeleccion.TabIndex = 14;
            listaOrdenesEnSeleccion.UseCompatibleStateImageBehavior = false;
            listaOrdenesEnSeleccion.View = View.Details;
            listaOrdenesEnSeleccion.SelectedIndexChanged += listOrdSeleccion_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 120;
            // 
            // FechaDeCreacion
            // 
            FechaDeCreacion.Text = "Fecha de Creación";
            FechaDeCreacion.Width = 120;
            // 
            // depositoBox
            // 
            depositoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            depositoBox.FormattingEnabled = true;
            depositoBox.Location = new Point(101, 12);
            depositoBox.Name = "depositoBox";
            depositoBox.Size = new Size(162, 23);
            depositoBox.TabIndex = 15;
            depositoBox.SelectedIndexChanged += depositoBox_SelectedIndexChanged;
            // 
            // Deposito
            // 
            Deposito.AutoSize = true;
            Deposito.Location = new Point(12, 15);
            Deposito.Name = "Deposito";
            Deposito.Size = new Size(54, 15);
            Deposito.TabIndex = 16;
            Deposito.Text = "Deposito";
            // 
            // Fila
            // 
            Fila.Text = "Fila";
            // 
            // estante
            // 
            estante.Text = "Estante";
            // 
            // FormConfirmarOrdenDeSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 555);
            Controls.Add(Deposito);
            Controls.Add(depositoBox);
            Controls.Add(listaOrdenesEnSeleccion);
            Controls.Add(fechaBox);
            Controls.Add(listDetalleOrden);
            Controls.Add(MenuPrincipalVolver);
            Controls.Add(btnConfirmar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormConfirmarOrdenDeSeleccion";
            Text = "ConfirmarOrdenDeSeleccion";
            Load += ConfirmarOrdenDeSeleccion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnConfirmar;
        private Button MenuPrincipalVolver;
        private ListView listDetalleOrden;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader pasillo;
        private TextBox fechaBox;
        private ListView listaOrdenesEnSeleccion;
        private ColumnHeader Id;
        private ColumnHeader FechaDeCreacion;
        private ComboBox depositoBox;
        private Label Deposito;
        private ColumnHeader Fila;
        private ColumnHeader estante;
    }
}