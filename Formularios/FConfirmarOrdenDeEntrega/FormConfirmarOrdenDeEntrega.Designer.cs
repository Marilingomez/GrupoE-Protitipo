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
            label1 = new Label();
            listaOrdenesDeEntrega = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox1 = new GroupBox();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            inputIdOrden = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            inputCliente = new TextBox();
            inputTransportista = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnMenu = new Button();
            btnConfirmar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 0;
            label1.Text = "Ordenes de Entrega en transito";
            // 
            // listaOrdenesDeEntrega
            // 
            listaOrdenesDeEntrega.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listaOrdenesDeEntrega.FullRowSelect = true;
            listaOrdenesDeEntrega.Location = new Point(12, 27);
            listaOrdenesDeEntrega.MultiSelect = false;
            listaOrdenesDeEntrega.Name = "listaOrdenesDeEntrega";
            listaOrdenesDeEntrega.Size = new Size(518, 165);
            listaOrdenesDeEntrega.TabIndex = 1;
            listaOrdenesDeEntrega.UseCompatibleStateImageBehavior = false;
            listaOrdenesDeEntrega.View = View.Details;
            listaOrdenesDeEntrega.SelectedIndexChanged += listaOrdenesDeEntrega_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id Orden";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "CUIT transportista";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "CUIT cliente";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(inputIdOrden);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(inputCliente);
            groupBox1.Controls.Add(inputTransportista);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(518, 187);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del transportista";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 19);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 11;
            label7.Text = "Id Orden";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(261, 147);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(162, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(7, 147);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(162, 23);
            textBox4.TabIndex = 8;
            // 
            // inputIdOrden
            // 
            inputIdOrden.Enabled = false;
            inputIdOrden.Location = new Point(7, 37);
            inputIdOrden.Name = "inputIdOrden";
            inputIdOrden.Size = new Size(162, 23);
            inputIdOrden.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(261, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 23);
            textBox3.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(261, 129);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 6;
            label6.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 129);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 5;
            label5.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 77);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "Nombre";
            // 
            // inputCliente
            // 
            inputCliente.Enabled = false;
            inputCliente.Location = new Point(261, 37);
            inputCliente.Name = "inputCliente";
            inputCliente.Size = new Size(162, 23);
            inputCliente.TabIndex = 3;
            // 
            // inputTransportista
            // 
            inputTransportista.Enabled = false;
            inputTransportista.Location = new Point(6, 95);
            inputTransportista.Name = "inputTransportista";
            inputTransportista.Size = new Size(162, 23);
            inputTransportista.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 19);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 1;
            label3.Text = "CUIT cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 0;
            label2.Text = "CUIT transportista";
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(422, 402);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(108, 23);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu Principal";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(308, 402);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(108, 23);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FormConfirmarOrdenDeEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmar);
            Controls.Add(btnMenu);
            Controls.Add(groupBox1);
            Controls.Add(listaOrdenesDeEntrega);
            Controls.Add(label1);
            Name = "FormConfirmarOrdenDeEntrega";
            Text = "FormConfirmarOrdenDeEntrega";
            Load += FormConfirmarOrdenDeEntrega_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listaOrdenesDeEntrega;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private TextBox inputCliente;
        private TextBox inputTransportista;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox5;
        private Button btnMenu;
        private Button btnConfirmar;
        private Label label7;
        private TextBox inputIdOrden;
    }
}