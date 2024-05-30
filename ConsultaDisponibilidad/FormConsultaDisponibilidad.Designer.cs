namespace GrupoE_Protitipos.ConsultaDisponibilidad
{
    partial class FormConsultaDisponibilidad
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
            ListViewItem listViewItem2 = new ListViewItem("");
            label1 = new Label();
            desplegableDepositos = new ComboBox();
            ConsultarEspacio = new Button();
            button1 = new Button();
            desplegableClientes = new ComboBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            espacioUtilizado = new Label();
            espacioDisponible = new Label();
            espacioContratado = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            detalleStock = new ListView();
            columnHeader2 = new ColumnHeader();
            hoasld = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Depósito";
            // 
            // desplegableDepositos
            // 
            desplegableDepositos.DropDownStyle = ComboBoxStyle.DropDownList;
            desplegableDepositos.FormattingEnabled = true;
            desplegableDepositos.Location = new Point(12, 27);
            desplegableDepositos.Name = "desplegableDepositos";
            desplegableDepositos.Size = new Size(121, 23);
            desplegableDepositos.TabIndex = 2;
            // 
            // ConsultarEspacio
            // 
            ConsultarEspacio.Location = new Point(409, 27);
            ConsultarEspacio.Name = "ConsultarEspacio";
            ConsultarEspacio.Size = new Size(121, 23);
            ConsultarEspacio.TabIndex = 5;
            ConsultarEspacio.Text = "Consultar espacio";
            ConsultarEspacio.UseVisualStyleBackColor = true;
            ConsultarEspacio.Click += ConsultarEspacio_Click;
            // 
            // button1
            // 
            button1.Location = new Point(430, 363);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 6;
            button1.Text = "Volver al Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // desplegableClientes
            // 
            desplegableClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            desplegableClientes.FormattingEnabled = true;
            desplegableClientes.Location = new Point(216, 27);
            desplegableClientes.Name = "desplegableClientes";
            desplegableClientes.Size = new Size(121, 23);
            desplegableClientes.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 9);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "Cliente";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 85);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información sobre espacio";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.8480225F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.1519775F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            tableLayoutPanel1.Controls.Add(espacioUtilizado, 2, 1);
            tableLayoutPanel1.Controls.Add(espacioDisponible, 1, 1);
            tableLayoutPanel1.Controls.Add(espacioContratado, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(512, 57);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // espacioUtilizado
            // 
            espacioUtilizado.AutoSize = true;
            espacioUtilizado.Location = new Point(349, 28);
            espacioUtilizado.Name = "espacioUtilizado";
            espacioUtilizado.Size = new Size(12, 15);
            espacioUtilizado.TabIndex = 5;
            espacioUtilizado.Text = "-";
            // 
            // espacioDisponible
            // 
            espacioDisponible.AutoSize = true;
            espacioDisponible.Location = new Point(175, 28);
            espacioDisponible.Name = "espacioDisponible";
            espacioDisponible.Size = new Size(12, 15);
            espacioDisponible.TabIndex = 4;
            espacioDisponible.Text = "-";
            // 
            // espacioContratado
            // 
            espacioContratado.AutoSize = true;
            espacioContratado.Location = new Point(3, 28);
            espacioContratado.Name = "espacioContratado";
            espacioContratado.Size = new Size(12, 15);
            espacioContratado.TabIndex = 3;
            espacioContratado.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(349, 0);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 2;
            label5.Text = "Espacio utilizado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 1;
            label4.Text = "Espacio disponible";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 0;
            label2.Text = "Espacio contratado";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(detalleStock);
            groupBox2.Location = new Point(12, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(518, 169);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle de stock del cliente en depósito consultado";
            // 
            // detalleStock
            // 
            detalleStock.BorderStyle = BorderStyle.FixedSingle;
            detalleStock.Columns.AddRange(new ColumnHeader[] { columnHeader2, hoasld, columnHeader3 });
            detalleStock.FullRowSelect = true;
            detalleStock.GridLines = true;
            detalleStock.Items.AddRange(new ListViewItem[] { listViewItem2 });
            detalleStock.Location = new Point(9, 22);
            detalleStock.Name = "detalleStock";
            detalleStock.Size = new Size(501, 141);
            detalleStock.TabIndex = 0;
            detalleStock.UseCompatibleStateImageBehavior = false;
            detalleStock.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ubicación";
            columnHeader2.Width = 167;
            // 
            // hoasld
            // 
            hoasld.Text = "Producto";
            hoasld.Width = 167;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cantidad";
            columnHeader3.Width = 167;
            // 
            // FormConsultaDisponibilidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 398);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(desplegableClientes);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(ConsultarEspacio);
            Controls.Add(desplegableDepositos);
            Controls.Add(label1);
            Name = "FormConsultaDisponibilidad";
            Text = "ConsultaDisponibilidad";
            FormClosed += ConsultaDisponibilidad_Closed;
            Load += ConsultaDisponibilidad_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox desplegableDepositos;
        private Button ConsultarEspacio;
        private Button button1;
        private ComboBox desplegableClientes;
        private Label label3;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label espacioUtilizado;
        private Label espacioDisponible;
        private Label espacioContratado;
        private Label label5;
        private Label label4;
        private Label label2;
        private GroupBox groupBox2;
        private ListView detalleStock;
        private ColumnHeader hoasld;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}