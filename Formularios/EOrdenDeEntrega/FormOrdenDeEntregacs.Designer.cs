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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenDeEntrega));
            SeleccionarBoton = new Button();
            OrdenEntrega = new ListView();
            IDOrdenSCol = new ColumnHeader();
            IdClienteSCol = new ColumnHeader();
            PrioridadTwo = new ColumnHeader();
            transportistaTwo = new ColumnHeader();
            GenerarBoton = new Button();
            VolverBoton = new Button();
            EliminarSeleccionBoton = new Button();
            groupBox2 = new GroupBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label7 = new Label();
            fechaBox = new TextBox();
            depositoBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            IDtext = new TextBox();
            label1 = new Label();
            OrdenSeleccionadaList = new ListView();
            IDOrdenCol = new ColumnHeader();
            IDClienteCol = new ColumnHeader();
            Prioridad = new ColumnHeader();
            transportista = new ColumnHeader();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SeleccionarBoton
            // 
            SeleccionarBoton.BackColor = Color.FromArgb(161, 32, 89);
            SeleccionarBoton.ForeColor = SystemColors.ButtonHighlight;
            SeleccionarBoton.Location = new Point(35, 509);
            SeleccionarBoton.Name = "SeleccionarBoton";
            SeleccionarBoton.Size = new Size(122, 22);
            SeleccionarBoton.TabIndex = 1;
            SeleccionarBoton.Text = "Seleccionar";
            SeleccionarBoton.UseVisualStyleBackColor = false;
            SeleccionarBoton.Click += SeleccionarBoton_Click;
            // 
            // OrdenEntrega
            // 
            OrdenEntrega.Columns.AddRange(new ColumnHeader[] { IDOrdenSCol, IdClienteSCol, PrioridadTwo, transportistaTwo });
            OrdenEntrega.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            IDOrdenSCol.Width = 120;
            // 
            // IdClienteSCol
            // 
            IdClienteSCol.Text = "Cliente";
            IdClienteSCol.Width = 120;
            // 
            // PrioridadTwo
            // 
            PrioridadTwo.Text = "Prioridad";
            PrioridadTwo.Width = 120;
            // 
            // transportistaTwo
            // 
            transportistaTwo.Text = "Transportista";
            transportistaTwo.Width = 215;
            // 
            // GenerarBoton
            // 
            GenerarBoton.BackColor = Color.FromArgb(161, 32, 89);
            GenerarBoton.ForeColor = SystemColors.ButtonHighlight;
            GenerarBoton.Location = new Point(313, 797);
            GenerarBoton.Name = "GenerarBoton";
            GenerarBoton.Size = new Size(126, 22);
            GenerarBoton.TabIndex = 3;
            GenerarBoton.Text = "Generar ";
            GenerarBoton.UseVisualStyleBackColor = false;
            GenerarBoton.Click += GenerarBoton_Click;
            // 
            // VolverBoton
            // 
            VolverBoton.BackColor = Color.FromArgb(161, 32, 89);
            VolverBoton.ForeColor = SystemColors.ButtonHighlight;
            VolverBoton.Location = new Point(475, 797);
            VolverBoton.Name = "VolverBoton";
            VolverBoton.Size = new Size(126, 22);
            VolverBoton.TabIndex = 4;
            VolverBoton.Text = "Volver al menu";
            VolverBoton.UseVisualStyleBackColor = false;
            VolverBoton.Click += VolverBoton_Click;
            // 
            // EliminarSeleccionBoton
            // 
            EliminarSeleccionBoton.BackColor = Color.FromArgb(161, 32, 89);
            EliminarSeleccionBoton.ForeColor = SystemColors.ButtonHighlight;
            EliminarSeleccionBoton.Location = new Point(35, 762);
            EliminarSeleccionBoton.Name = "EliminarSeleccionBoton";
            EliminarSeleccionBoton.Size = new Size(122, 22);
            EliminarSeleccionBoton.TabIndex = 5;
            EliminarSeleccionBoton.Text = "Eliminar selección";
            EliminarSeleccionBoton.UseVisualStyleBackColor = false;
            EliminarSeleccionBoton.Click += CancelarBoton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(OrdenEntrega);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(31, 557);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(519, 149);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(161, 32, 89);
            label5.Location = new Point(5, 0);
            label5.Name = "label5";
            label5.Size = new Size(182, 15);
            label5.TabIndex = 10;
            label5.Text = "Selección de Ordenes Preparadas";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(fechaBox);
            groupBox3.Controls.Add(depositoBox);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(IDtext);
            groupBox3.Controls.Add(label1);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(31, 88);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(521, 124);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(342, 17);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 11;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 68);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // OrdenSeleccionadaList
            // 
            OrdenSeleccionadaList.Columns.AddRange(new ColumnHeader[] { IDOrdenCol, IDClienteCol, Prioridad, transportista });
            OrdenSeleccionadaList.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            IDOrdenCol.Width = 120;
            // 
            // IDClienteCol
            // 
            IDClienteCol.Text = "Cliente";
            IDClienteCol.Width = 120;
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            Prioridad.Width = 120;
            // 
            // transportista
            // 
            transportista.Text = "Transportista";
            transportista.Width = 215;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(OrdenSeleccionadaList);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(35, 278);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(521, 169);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(161, 32, 89);
            label4.Location = new Point(5, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 10;
            label4.Text = "Ordenes preparadas";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(161, 32, 89);
            label6.Location = new Point(37, 76);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 10;
            label6.Text = "Orden de Entrega";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(161, 32, 89);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(673, 52);
            panel1.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(226, 15);
            label8.Name = "label8";
            label8.Size = new Size(195, 31);
            label8.TabIndex = 21;
            label8.Text = "Orden de Entrega";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormOrdenDeEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(674, 847);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(groupBox3);
            Controls.Add(EliminarSeleccionBoton);
            Controls.Add(VolverBoton);
            Controls.Add(GenerarBoton);
            Controls.Add(SeleccionarBoton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormOrdenDeEntrega";
            Text = " ";
            Load += OrdenDeEntregacs_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SeleccionarBoton;
        private ListView OrdenEntrega;
        private Button GenerarBoton;
        private Button VolverBoton;
        private Button EliminarSeleccionBoton;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox IDtext;
        private Label label2;
        private Label label3;
        private ColumnHeader IDOrdenSCol;
        private ColumnHeader IdClienteSCol;
        private ComboBox depositoBox;
        private TextBox fechaBox;
        private ColumnHeader PrioridadTwo;
        private ColumnHeader transportistaTwo;
        private ListView OrdenSeleccionadaList;
        private ColumnHeader IDOrdenCol;
        private ColumnHeader IDClienteCol;
        private ColumnHeader Prioridad;
        private ColumnHeader transportista;
        private GroupBox groupBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label8;
    }
}