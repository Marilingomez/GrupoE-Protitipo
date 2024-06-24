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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfirmarOrdenDeSeleccion));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnConfirmar = new Button();
            MenuPrincipalVolver = new Button();
            listDetalleOrden = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            pasillo = new ColumnHeader();
            Fila = new ColumnHeader();
            estante = new ColumnHeader();
            fechaBox = new TextBox();
            listaOrdenesEnSeleccion = new ListView();
            Id = new ColumnHeader();
            FechaDeCreacion = new ColumnHeader();
            depositoBox = new ComboBox();
            Deposito = new Label();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(161, 32, 89);
            label1.Location = new Point(16, 127);
            label1.Name = "label1";
            label1.Size = new Size(234, 20);
            label1.TabIndex = 5;
            label1.Text = "Ordenes de Seleccion pendientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(161, 32, 89);
            label2.Location = new Point(16, 341);
            label2.Name = "label2";
            label2.Size = new Size(303, 20);
            label2.TabIndex = 7;
            label2.Text = "Detalle de la Orden de Seleccion pendiente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 568);
            label3.Name = "label3";
            label3.Size = new Size(375, 20);
            label3.TabIndex = 8;
            label3.Text = "Fecha de recepcion de mercaderia en Area Preparacion";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(161, 32, 89);
            btnConfirmar.ForeColor = SystemColors.ButtonHighlight;
            btnConfirmar.Location = new Point(471, 657);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(124, 31);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_click;
            // 
            // MenuPrincipalVolver
            // 
            MenuPrincipalVolver.BackColor = Color.FromArgb(161, 32, 89);
            MenuPrincipalVolver.ForeColor = SystemColors.ButtonHighlight;
            MenuPrincipalVolver.Location = new Point(471, 696);
            MenuPrincipalVolver.Margin = new Padding(3, 4, 3, 4);
            MenuPrincipalVolver.Name = "MenuPrincipalVolver";
            MenuPrincipalVolver.Size = new Size(124, 31);
            MenuPrincipalVolver.TabIndex = 11;
            MenuPrincipalVolver.Text = "Volver al menu";
            MenuPrincipalVolver.UseVisualStyleBackColor = false;
            MenuPrincipalVolver.Click += MenuPrincipalVolver_Click;
            // 
            // listDetalleOrden
            // 
            listDetalleOrden.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, pasillo, Fila, estante });
            listDetalleOrden.FullRowSelect = true;
            listDetalleOrden.Location = new Point(16, 365);
            listDetalleOrden.Margin = new Padding(3, 4, 3, 4);
            listDetalleOrden.Name = "listDetalleOrden";
            listDetalleOrden.Size = new Size(579, 179);
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
            // Fila
            // 
            Fila.Text = "Fila";
            // 
            // estante
            // 
            estante.Text = "Estante";
            // 
            // fechaBox
            // 
            fechaBox.Enabled = false;
            fechaBox.Location = new Point(16, 592);
            fechaBox.Margin = new Padding(3, 4, 3, 4);
            fechaBox.Name = "fechaBox";
            fechaBox.Size = new Size(114, 27);
            fechaBox.TabIndex = 13;
            // 
            // listaOrdenesEnSeleccion
            // 
            listaOrdenesEnSeleccion.Columns.AddRange(new ColumnHeader[] { Id, FechaDeCreacion });
            listaOrdenesEnSeleccion.FullRowSelect = true;
            listaOrdenesEnSeleccion.Location = new Point(16, 151);
            listaOrdenesEnSeleccion.Margin = new Padding(3, 4, 3, 4);
            listaOrdenesEnSeleccion.MultiSelect = false;
            listaOrdenesEnSeleccion.Name = "listaOrdenesEnSeleccion";
            listaOrdenesEnSeleccion.Size = new Size(579, 172);
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
            FechaDeCreacion.Width = 200;
            // 
            // depositoBox
            // 
            depositoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            depositoBox.FormattingEnabled = true;
            depositoBox.Location = new Point(117, 92);
            depositoBox.Margin = new Padding(3, 4, 3, 4);
            depositoBox.Name = "depositoBox";
            depositoBox.Size = new Size(185, 28);
            depositoBox.TabIndex = 15;
            depositoBox.SelectedIndexChanged += depositoBox_SelectedIndexChanged;
            // 
            // Deposito
            // 
            Deposito.AutoSize = true;
            Deposito.Location = new Point(16, 96);
            Deposito.Name = "Deposito";
            Deposito.Size = new Size(70, 20);
            Deposito.TabIndex = 16;
            Deposito.Text = "Deposito";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(161, 32, 89);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(673, 52);
            panel1.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(164, 15);
            label4.Name = "label4";
            label4.Size = new Size(319, 31);
            label4.TabIndex = 19;
            label4.Text = "Confirmar Orden de Selección";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // FormConfirmarOrdenDeSeleccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(620, 740);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormConfirmarOrdenDeSeleccion";
            Text = "Confirmar Orden de Selección";
            Load += ConfirmarOrdenDeSeleccion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
    }
}