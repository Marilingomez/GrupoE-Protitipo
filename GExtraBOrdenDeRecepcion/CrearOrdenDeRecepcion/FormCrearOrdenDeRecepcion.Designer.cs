namespace GrupoE_Protitipos.Recepcion
{
    partial class FormCrearOrdenDeRecepcion
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
            CancelarOrdenRecepBtn = new Button();
            EditarOrdenRecepBtn = new Button();
            CrearOrdenderecepGbox = new GroupBox();
            ListDepositoCmbBox = new ComboBox();
            DepositoRecepBtn = new Label();
            textBox2 = new TextBox();
            NotasRecepcionBtn = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            FechaRecepcionBtn = new Label();
            textBox5 = new TextBox();
            ClienteRecepcBtn = new Label();
            textBox6 = new TextBox();
            ProductoAingresarbtn = new Label();
            VolverOrdenRecepBtn = new Button();
            CrearOrdenBtn = new Button();
            CrearOrdenderecepGbox.SuspendLayout();
            SuspendLayout();
            // 
            // CancelarOrdenRecepBtn
            // 
            CancelarOrdenRecepBtn.Location = new Point(427, 265);
            CancelarOrdenRecepBtn.Name = "CancelarOrdenRecepBtn";
            CancelarOrdenRecepBtn.Size = new Size(144, 29);
            CancelarOrdenRecepBtn.TabIndex = 16;
            CancelarOrdenRecepBtn.Text = "Cancelar";
            CancelarOrdenRecepBtn.UseVisualStyleBackColor = true;
            // 
            // EditarOrdenRecepBtn
            // 
            EditarOrdenRecepBtn.Location = new Point(251, 265);
            EditarOrdenRecepBtn.Name = "EditarOrdenRecepBtn";
            EditarOrdenRecepBtn.Size = new Size(144, 29);
            EditarOrdenRecepBtn.TabIndex = 15;
            EditarOrdenRecepBtn.Text = "Editar ";
            EditarOrdenRecepBtn.UseVisualStyleBackColor = true;
            // 
            // CrearOrdenderecepGbox
            // 
            CrearOrdenderecepGbox.Controls.Add(ListDepositoCmbBox);
            CrearOrdenderecepGbox.Controls.Add(DepositoRecepBtn);
            CrearOrdenderecepGbox.Controls.Add(textBox2);
            CrearOrdenderecepGbox.Controls.Add(NotasRecepcionBtn);
            CrearOrdenderecepGbox.Controls.Add(textBox3);
            CrearOrdenderecepGbox.Controls.Add(label9);
            CrearOrdenderecepGbox.Controls.Add(textBox4);
            CrearOrdenderecepGbox.Controls.Add(FechaRecepcionBtn);
            CrearOrdenderecepGbox.Controls.Add(textBox5);
            CrearOrdenderecepGbox.Controls.Add(ClienteRecepcBtn);
            CrearOrdenderecepGbox.Controls.Add(textBox6);
            CrearOrdenderecepGbox.Controls.Add(ProductoAingresarbtn);
            CrearOrdenderecepGbox.Location = new Point(69, 27);
            CrearOrdenderecepGbox.Name = "CrearOrdenderecepGbox";
            CrearOrdenderecepGbox.Size = new Size(503, 212);
            CrearOrdenderecepGbox.TabIndex = 14;
            CrearOrdenderecepGbox.TabStop = false;
            CrearOrdenderecepGbox.Text = "Orden de Recepcion";
            CrearOrdenderecepGbox.Enter += CrearOrdenderecepGbox_Enter;
            // 
            // ListDepositoCmbBox
            // 
            ListDepositoCmbBox.FormattingEnabled = true;
            ListDepositoCmbBox.Items.AddRange(new object[] { "GBA Zona Norte", "Rosario", "Córdoba ", "Bahía Blanca", "Neuquén ", "Misiones ", "GBA Zona Sur", "Mendoza ", "Salta ", "Tierra del Fuego" });
            ListDepositoCmbBox.Location = new Point(18, 176);
            ListDepositoCmbBox.Margin = new Padding(3, 4, 3, 4);
            ListDepositoCmbBox.Name = "ListDepositoCmbBox";
            ListDepositoCmbBox.Size = new Size(225, 28);
            ListDepositoCmbBox.TabIndex = 11;
            ListDepositoCmbBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // DepositoRecepBtn
            // 
            DepositoRecepBtn.AutoSize = true;
            DepositoRecepBtn.Location = new Point(17, 148);
            DepositoRecepBtn.Name = "DepositoRecepBtn";
            DepositoRecepBtn.Size = new Size(70, 20);
            DepositoRecepBtn.TabIndex = 10;
            DepositoRecepBtn.Text = "Deposito";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(265, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 27);
            textBox2.TabIndex = 9;
            // 
            // NotasRecepcionBtn
            // 
            NotasRecepcionBtn.AutoSize = true;
            NotasRecepcionBtn.Location = new Point(266, 148);
            NotasRecepcionBtn.Name = "NotasRecepcionBtn";
            NotasRecepcionBtn.Size = new Size(121, 20);
            NotasRecepcionBtn.TabIndex = 8;
            NotasRecepcionBtn.Text = "Notas Recepcion";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(265, 49);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 27);
            textBox3.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(266, 27);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 6;
            label9.Text = "Cantidad";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(16, 113);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(229, 27);
            textBox4.TabIndex = 5;
            // 
            // FechaRecepcionBtn
            // 
            FechaRecepcionBtn.AutoSize = true;
            FechaRecepcionBtn.Location = new Point(17, 91);
            FechaRecepcionBtn.Name = "FechaRecepcionBtn";
            FechaRecepcionBtn.Size = new Size(47, 20);
            FechaRecepcionBtn.TabIndex = 4;
            FechaRecepcionBtn.Text = "Fecha";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(265, 113);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(229, 27);
            textBox5.TabIndex = 3;
            // 
            // ClienteRecepcBtn
            // 
            ClienteRecepcBtn.AutoSize = true;
            ClienteRecepcBtn.Location = new Point(266, 91);
            ClienteRecepcBtn.Name = "ClienteRecepcBtn";
            ClienteRecepcBtn.Size = new Size(59, 20);
            ClienteRecepcBtn.TabIndex = 2;
            ClienteRecepcBtn.Text = "Cliente ";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(16, 49);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(227, 27);
            textBox6.TabIndex = 1;
            // 
            // ProductoAingresarbtn
            // 
            ProductoAingresarbtn.AutoSize = true;
            ProductoAingresarbtn.Location = new Point(17, 27);
            ProductoAingresarbtn.Name = "ProductoAingresarbtn";
            ProductoAingresarbtn.Size = new Size(69, 20);
            ProductoAingresarbtn.TabIndex = 0;
            ProductoAingresarbtn.Text = "Producto";
            // 
            // VolverOrdenRecepBtn
            // 
            VolverOrdenRecepBtn.Location = new Point(427, 309);
            VolverOrdenRecepBtn.Name = "VolverOrdenRecepBtn";
            VolverOrdenRecepBtn.Size = new Size(144, 29);
            VolverOrdenRecepBtn.TabIndex = 13;
            VolverOrdenRecepBtn.Text = "Volver";
            VolverOrdenRecepBtn.UseVisualStyleBackColor = true;
            VolverOrdenRecepBtn.Click += VolverOrdenRecepBtn_Click;
            // 
            // CrearOrdenBtn
            // 
            CrearOrdenBtn.Location = new Point(91, 265);
            CrearOrdenBtn.Name = "CrearOrdenBtn";
            CrearOrdenBtn.Size = new Size(144, 29);
            CrearOrdenBtn.TabIndex = 12;
            CrearOrdenBtn.Text = "Crear";
            CrearOrdenBtn.UseVisualStyleBackColor = true;
            CrearOrdenBtn.Click += GenerarBoton_Click;
            // 
            // FormCrearOrdenDeRecepcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 397);
            Controls.Add(CancelarOrdenRecepBtn);
            Controls.Add(EditarOrdenRecepBtn);
            Controls.Add(CrearOrdenderecepGbox);
            Controls.Add(VolverOrdenRecepBtn);
            Controls.Add(CrearOrdenBtn);
            Margin = new Padding(2, 3, 2, 3);
            Name = "FormCrearOrdenDeRecepcion";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Crear orden de recepcion";
            Load += FormCrearOrdenDeRecepcion_Load;
            CrearOrdenderecepGbox.ResumeLayout(false);
            CrearOrdenderecepGbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button CancelarOrdenRecepBtn;
        private Button EditarOrdenRecepBtn;
        private GroupBox CrearOrdenderecepGbox;
        private Label DepositoRecepBtn;
        private TextBox textBox2;
        private Label NotasRecepcionBtn;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox4;
        private Label FechaRecepcionBtn;
        private TextBox textBox5;
        private Label ClienteRecepcBtn;
        private TextBox textBox6;
        private Label ProductoAingresarbtn;
        private Button VolverOrdenRecepBtn;
        private Button CrearOrdenBtn;
        private ComboBox ListDepositoCmbBox;
    }
}