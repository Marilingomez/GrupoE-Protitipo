namespace GrupoE_Protitipos.ConfirmarOrdenDeEntrega
{
    partial class FormConfirmarOrdenDeEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfirmarOrdenDeEntrega));
            label1 = new Label();
            listaOrdenesDeEntrega = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            dniBox = new TextBox();
            apellidoBox = new TextBox();
            inputIdOrden = new TextBox();
            nombreBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            inputTransportista = new TextBox();
            label2 = new Label();
            btnMenu = new Button();
            btnConfirmar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(161, 32, 89);
            label1.Location = new Point(11, 101);
            label1.Name = "label1";
            label1.Size = new Size(221, 20);
            label1.TabIndex = 0;
            label1.Text = "Ordenes de Entrega en transito";
            // 
            // listaOrdenesDeEntrega
            // 
            listaOrdenesDeEntrega.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listaOrdenesDeEntrega.FullRowSelect = true;
            listaOrdenesDeEntrega.Location = new Point(11, 133);
            listaOrdenesDeEntrega.Margin = new Padding(3, 5, 3, 5);
            listaOrdenesDeEntrega.MultiSelect = false;
            listaOrdenesDeEntrega.Name = "listaOrdenesDeEntrega";
            listaOrdenesDeEntrega.Size = new Size(591, 219);
            listaOrdenesDeEntrega.TabIndex = 1;
            listaOrdenesDeEntrega.UseCompatibleStateImageBehavior = false;
            listaOrdenesDeEntrega.View = View.Details;
            listaOrdenesDeEntrega.SelectedIndexChanged += listaOrdenesDeEntrega_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id Orden";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "CUIT transportista";
            columnHeader2.Width = 200;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dniBox);
            groupBox1.Controls.Add(apellidoBox);
            groupBox1.Controls.Add(inputIdOrden);
            groupBox1.Controls.Add(nombreBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(inputTransportista);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(11, 372);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(592, 249);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(161, 32, 89);
            label8.Location = new Point(-2, 0);
            label8.Name = "label8";
            label8.Size = new Size(165, 20);
            label8.TabIndex = 12;
            label8.Text = "Datos del Transportista";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 25);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 11;
            label7.Text = "Id Orden";
            // 
            // dniBox
            // 
            dniBox.Location = new Point(298, 196);
            dniBox.Margin = new Padding(3, 4, 3, 4);
            dniBox.Name = "dniBox";
            dniBox.Size = new Size(185, 27);
            dniBox.TabIndex = 9;
            // 
            // apellidoBox
            // 
            apellidoBox.Location = new Point(8, 196);
            apellidoBox.Margin = new Padding(3, 4, 3, 4);
            apellidoBox.Name = "apellidoBox";
            apellidoBox.Size = new Size(185, 27);
            apellidoBox.TabIndex = 8;
            // 
            // inputIdOrden
            // 
            inputIdOrden.Enabled = false;
            inputIdOrden.Location = new Point(8, 49);
            inputIdOrden.Margin = new Padding(3, 4, 3, 4);
            inputIdOrden.Name = "inputIdOrden";
            inputIdOrden.Size = new Size(185, 27);
            inputIdOrden.TabIndex = 10;
            // 
            // nombreBox
            // 
            nombreBox.Location = new Point(298, 127);
            nombreBox.Margin = new Padding(3, 4, 3, 4);
            nombreBox.Name = "nombreBox";
            nombreBox.Size = new Size(185, 27);
            nombreBox.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(298, 172);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 6;
            label6.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 172);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 5;
            label5.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 103);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 4;
            label4.Text = "Nombre";
            // 
            // inputTransportista
            // 
            inputTransportista.Enabled = false;
            inputTransportista.Location = new Point(7, 127);
            inputTransportista.Margin = new Padding(3, 4, 3, 4);
            inputTransportista.Name = "inputTransportista";
            inputTransportista.Size = new Size(185, 27);
            inputTransportista.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 103);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 0;
            label2.Text = "CUIT transportista";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(161, 32, 89);
            btnMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMenu.Location = new Point(484, 631);
            btnMenu.Margin = new Padding(3, 5, 3, 5);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(123, 31);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Volver al menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(161, 32, 89);
            btnConfirmar.ForeColor = SystemColors.ButtonHighlight;
            btnConfirmar.Location = new Point(336, 631);
            btnConfirmar.Margin = new Padding(3, 5, 3, 5);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(123, 31);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(161, 32, 89);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 69);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-13, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(199, 28);
            label9.Name = "label9";
            label9.Size = new Size(302, 31);
            label9.TabIndex = 22;
            label9.Text = "Confirmar Orden de Entrega";
            // 
            // FormConfirmarOrdenDeEntrega
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(633, 682);
            Controls.Add(panel1);
            Controls.Add(btnConfirmar);
            Controls.Add(btnMenu);
            Controls.Add(groupBox1);
            Controls.Add(listaOrdenesDeEntrega);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormConfirmarOrdenDeEntrega";
            Text = "Confirmar Orden de Entrega";
            Load += FormConfirmarOrdenDeEntrega_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listaOrdenesDeEntrega;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private TextBox inputTransportista;
        private Label label2;
        private TextBox apellidoBox;
        private TextBox nombreBox;
        private Label label6;
        private TextBox dniBox;
        private Button btnMenu;
        private Button btnConfirmar;
        private Label label7;
        private TextBox inputIdOrden;
        private Label label8;
        private Panel panel1;
        private Label label9;
        private PictureBox pictureBox1;
    }
}