namespace GrupoE_Protitipos
{
    partial class EditarOrdenEntrega
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
            EditarOrden = new ListView();
            IDCol = new ColumnHeader();
            CUITCol = new ColumnHeader();
            FechaCol = new ColumnHeader();
            DepositoCol = new ColumnHeader();
            DireccionCol = new ColumnHeader();
            Notas = new ColumnHeader();
            EliminarBotonE = new Button();
            EditarBotonE = new Button();
            VolverBoton = new Button();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            IDtextE = new TextBox();
            label1 = new Label();
            ClienteTextE = new TextBox();
            FechaTextE = new TextBox();
            NotasTextE = new TextBox();
            DireccionTextE = new TextBox();
            DepositoTextE = new TextBox();
            SuspendLayout();
            // 
            // EditarOrden
            // 
            EditarOrden.Columns.AddRange(new ColumnHeader[] { IDCol, CUITCol, FechaCol, DepositoCol, DireccionCol, Notas });
            EditarOrden.Location = new Point(50, 29);
            EditarOrden.Name = "EditarOrden";
            EditarOrden.Size = new Size(648, 121);
            EditarOrden.TabIndex = 0;
            EditarOrden.UseCompatibleStateImageBehavior = false;
            EditarOrden.View = View.Details;
            EditarOrden.SelectedIndexChanged += EditarOrden_SelectedIndexChanged;
            // 
            // IDCol
            // 
            IDCol.Text = "ID";
            IDCol.Width = 40;
            // 
            // CUITCol
            // 
            CUITCol.Text = "CUIT";
            CUITCol.Width = 90;
            // 
            // FechaCol
            // 
            FechaCol.Text = "Fecha";
            // 
            // DepositoCol
            // 
            DepositoCol.Text = "Deposito";
            DepositoCol.Width = 80;
            // 
            // DireccionCol
            // 
            DireccionCol.Text = "Direccion Entrega";
            DireccionCol.Width = 150;
            // 
            // Notas
            // 
            Notas.Text = "Notas";
            Notas.Width = 200;
            // 
            // EliminarBotonE
            // 
            EliminarBotonE.Location = new Point(554, 331);
            EliminarBotonE.Name = "EliminarBotonE";
            EliminarBotonE.Size = new Size(144, 29);
            EliminarBotonE.TabIndex = 14;
            EliminarBotonE.Text = "Eliminar ";
            EliminarBotonE.UseVisualStyleBackColor = true;
            EliminarBotonE.Click += EliminarBotonE_Click;
            // 
            // EditarBotonE
            // 
            EditarBotonE.Location = new Point(404, 331);
            EditarBotonE.Name = "EditarBotonE";
            EditarBotonE.Size = new Size(144, 29);
            EditarBotonE.TabIndex = 13;
            EditarBotonE.Text = "Editar ";
            EditarBotonE.UseVisualStyleBackColor = true;
            EditarBotonE.Click += EditarBotonE_Click;
            // 
            // VolverBoton
            // 
            VolverBoton.Location = new Point(554, 375);
            VolverBoton.Name = "VolverBoton";
            VolverBoton.Size = new Size(144, 29);
            VolverBoton.TabIndex = 12;
            VolverBoton.Text = "Volver";
            VolverBoton.UseVisualStyleBackColor = true;
            VolverBoton.Click += VolverBoton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 240);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 10;
            label5.Text = "Direccion de entrega";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(515, 240);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 8;
            label6.Text = "Notas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 183);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 6;
            label4.Text = "CUIT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 183);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 4;
            label3.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 240);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Deposito";
            // 
            // IDtextE
            // 
            IDtextE.Location = new Point(50, 206);
            IDtextE.Name = "IDtextE";
            IDtextE.Size = new Size(188, 27);
            IDtextE.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 183);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // ClienteTextE
            // 
            ClienteTextE.Location = new Point(278, 206);
            ClienteTextE.Name = "ClienteTextE";
            ClienteTextE.Size = new Size(188, 27);
            ClienteTextE.TabIndex = 16;
            // 
            // FechaTextE
            // 
            FechaTextE.Location = new Point(510, 206);
            FechaTextE.Name = "FechaTextE";
            FechaTextE.Size = new Size(188, 27);
            FechaTextE.TabIndex = 17;
            // 
            // NotasTextE
            // 
            NotasTextE.Location = new Point(510, 263);
            NotasTextE.Name = "NotasTextE";
            NotasTextE.Size = new Size(188, 27);
            NotasTextE.TabIndex = 20;
            // 
            // DireccionTextE
            // 
            DireccionTextE.Location = new Point(278, 263);
            DireccionTextE.Name = "DireccionTextE";
            DireccionTextE.Size = new Size(188, 27);
            DireccionTextE.TabIndex = 19;
            // 
            // DepositoTextE
            // 
            DepositoTextE.Location = new Point(50, 263);
            DepositoTextE.Name = "DepositoTextE";
            DepositoTextE.Size = new Size(188, 27);
            DepositoTextE.TabIndex = 18;
            // 
            // EditarOrdenEntrega
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 423);
            Controls.Add(NotasTextE);
            Controls.Add(DireccionTextE);
            Controls.Add(DepositoTextE);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(FechaTextE);
            Controls.Add(ClienteTextE);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(EliminarBotonE);
            Controls.Add(EditarBotonE);
            Controls.Add(VolverBoton);
            Controls.Add(EditarOrden);
            Controls.Add(IDtextE);
            Controls.Add(label1);
            Name = "EditarOrdenEntrega";
            Text = "EditarOrdenEntrega";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView EditarOrden;
        private ColumnHeader IDCol;
        private ColumnHeader CUITCol;
        private ColumnHeader FechaCol;
        private ColumnHeader DepositoCol;
        private ColumnHeader DireccionCol;
        private ColumnHeader Notas;
        private Button EliminarBotonE;
        private Button EditarBotonE;
        private Button VolverBoton;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox IDtextE;
        private Label label1;
        private TextBox ClienteTextE;
        private TextBox FechaTextE;
        private TextBox NotasTextE;
        private TextBox DireccionTextE;
        private TextBox DepositoTextE;
    }
}