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
            listOrdSeleccion = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnConfirmar = new Button();
            MenuPrincipalVolver = new Button();
            listDetalleOrden = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // listOrdSeleccion
            // 
            listOrdSeleccion.FormattingEnabled = true;
            listOrdSeleccion.ItemHeight = 15;
            listOrdSeleccion.Location = new Point(12, 26);
            listOrdSeleccion.Margin = new Padding(3, 2, 3, 2);
            listOrdSeleccion.MultiColumn = true;
            listOrdSeleccion.Name = "listOrdSeleccion";
            listOrdSeleccion.Size = new Size(296, 124);
            listOrdSeleccion.TabIndex = 4;
            listOrdSeleccion.SelectedIndexChanged += listOrdSeleccion_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 5;
            label1.Text = "Ordenes de Seleccion pendientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 170);
            label2.Name = "label2";
            label2.Size = new Size(232, 15);
            label2.TabIndex = 7;
            label2.Text = "Detalle de la Orden de Seleccion pendiente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 326);
            label3.Name = "label3";
            label3.Size = new Size(296, 15);
            label3.TabIndex = 8;
            label3.Text = "Fecha de recepcion de mercaderia en Area Preparacion";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 344);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(296, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(207, 407);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(101, 23);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += button1_Click;
            // 
            // MenuPrincipalVolver
            // 
            MenuPrincipalVolver.Location = new Point(207, 453);
            MenuPrincipalVolver.Name = "MenuPrincipalVolver";
            MenuPrincipalVolver.Size = new Size(101, 23);
            MenuPrincipalVolver.TabIndex = 11;
            MenuPrincipalVolver.Text = "Menu principal";
            MenuPrincipalVolver.UseVisualStyleBackColor = true;
            MenuPrincipalVolver.Click += MenuPrincipalVolver_Click;
            // 
            // listDetalleOrden
            // 
            listDetalleOrden.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listDetalleOrden.FullRowSelect = true;
            listDetalleOrden.Location = new Point(12, 188);
            listDetalleOrden.Name = "listDetalleOrden";
            listDetalleOrden.Size = new Size(296, 135);
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
            // columnHeader3
            // 
            columnHeader3.Text = "Ubicacion";
            columnHeader3.Width = 100;
            // 
            // FormConfirmarOrdenDeSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 484);
            Controls.Add(listDetalleOrden);
            Controls.Add(MenuPrincipalVolver);
            Controls.Add(btnConfirmar);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listOrdSeleccion);
            Name = "FormConfirmarOrdenDeSeleccion";
            Text = "ConfirmarOrdenDeSeleccion";
            Load += ConfirmarOrdenDeSeleccion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listOrdSeleccion;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button btnConfirmar;
        private Button MenuPrincipalVolver;
        private ListView listDetalleOrden;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}