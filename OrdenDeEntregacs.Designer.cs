namespace GrupoE_Protitipos
{
    partial class OrdenDeEntregacs
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
            ID = new ColumnHeader();
            Cliente = new ColumnHeader();
            SeleccionarBoton = new Button();
            OrdenEntrega = new ListView();
            IDSeleccionado = new ColumnHeader();
            ClienteSeleccionado = new ColumnHeader();
            GenerarBoton = new Button();
            VolverBoton = new Button();
            CancelarBoton = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            DireccionText = new TextBox();
            label5 = new Label();
            Notastext = new TextBox();
            label6 = new Label();
            ClienteText = new TextBox();
            label4 = new Label();
            FechaText = new TextBox();
            label3 = new Label();
            DepositoText = new TextBox();
            label2 = new Label();
            IDtext = new TextBox();
            label1 = new Label();
            EditarBoton = new Button();
            EliminarBoton = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // OrdenSeleccionadaList
            // 
            OrdenSeleccionadaList.Columns.AddRange(new ColumnHeader[] { ID, Cliente });
            OrdenSeleccionadaList.Location = new Point(6, 21);
            OrdenSeleccionadaList.Name = "OrdenSeleccionadaList";
            OrdenSeleccionadaList.Size = new Size(236, 121);
            OrdenSeleccionadaList.TabIndex = 0;
            OrdenSeleccionadaList.UseCompatibleStateImageBehavior = false;
            // 
            // SeleccionarBoton
            // 
            SeleccionarBoton.Location = new Point(26, 172);
            SeleccionarBoton.Name = "SeleccionarBoton";
            SeleccionarBoton.Size = new Size(236, 29);
            SeleccionarBoton.TabIndex = 1;
            SeleccionarBoton.Text = "Seleccionar";
            SeleccionarBoton.UseVisualStyleBackColor = true;
            // 
            // OrdenEntrega
            // 
            OrdenEntrega.Columns.AddRange(new ColumnHeader[] { IDSeleccionado, ClienteSeleccionado });
            OrdenEntrega.Location = new Point(282, 30);
            OrdenEntrega.Name = "OrdenEntrega";
            OrdenEntrega.Size = new Size(236, 121);
            OrdenEntrega.TabIndex = 2;
            OrdenEntrega.UseCompatibleStateImageBehavior = false;
            // 
            // GenerarBoton
            // 
            GenerarBoton.Location = new Point(32, 466);
            GenerarBoton.Name = "GenerarBoton";
            GenerarBoton.Size = new Size(144, 29);
            GenerarBoton.TabIndex = 3;
            GenerarBoton.Text = "Generar ";
            GenerarBoton.UseVisualStyleBackColor = true;
            // 
            // VolverBoton
            // 
            VolverBoton.Location = new Point(368, 510);
            VolverBoton.Name = "VolverBoton";
            VolverBoton.Size = new Size(144, 29);
            VolverBoton.TabIndex = 4;
            VolverBoton.Text = "Volver";
            VolverBoton.UseVisualStyleBackColor = true;
            VolverBoton.Click += VolverBoton_Click;
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(282, 172);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(236, 29);
            CancelarBoton.TabIndex = 5;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            CancelarBoton.Click += CancelarBoton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OrdenSeleccionadaList);
            groupBox1.Location = new Point(16, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 157);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ordenes Seleccionadas";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(273, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 157);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seleccion";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DireccionText);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(Notastext);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(ClienteText);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(FechaText);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(DepositoText);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(IDtext);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(16, 207);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(502, 238);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Orden de Entrega";
            // 
            // DireccionText
            // 
            DireccionText.Location = new Point(16, 170);
            DireccionText.Name = "DireccionText";
            DireccionText.Size = new Size(230, 27);
            DireccionText.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 147);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 10;
            label5.Text = "Direccion de entrega";
            // 
            // Notastext
            // 
            Notastext.Location = new Point(266, 170);
            Notastext.Name = "Notastext";
            Notastext.Size = new Size(230, 27);
            Notastext.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(266, 147);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 8;
            label6.Text = "Notas";
            // 
            // ClienteText
            // 
            ClienteText.Location = new Point(266, 49);
            ClienteText.Name = "ClienteText";
            ClienteText.Size = new Size(226, 27);
            ClienteText.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 26);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 6;
            label4.Text = "Cliente";
            // 
            // FechaText
            // 
            FechaText.Location = new Point(16, 113);
            FechaText.Name = "FechaText";
            FechaText.Size = new Size(230, 27);
            FechaText.TabIndex = 5;
            FechaText.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 90);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 4;
            label3.Text = "Fecha";
            // 
            // DepositoText
            // 
            DepositoText.Location = new Point(266, 113);
            DepositoText.Name = "DepositoText";
            DepositoText.Size = new Size(230, 27);
            DepositoText.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 90);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Deposito";
            // 
            // IDtext
            // 
            IDtext.Location = new Point(16, 49);
            IDtext.Name = "IDtext";
            IDtext.Size = new Size(226, 27);
            IDtext.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // EditarBoton
            // 
            EditarBoton.Location = new Point(193, 466);
            EditarBoton.Name = "EditarBoton";
            EditarBoton.Size = new Size(144, 29);
            EditarBoton.TabIndex = 10;
            EditarBoton.Text = "Editar ";
            EditarBoton.UseVisualStyleBackColor = true;
            // 
            // EliminarBoton
            // 
            EliminarBoton.Location = new Point(368, 466);
            EliminarBoton.Name = "EliminarBoton";
            EliminarBoton.Size = new Size(144, 29);
            EliminarBoton.TabIndex = 11;
            EliminarBoton.Text = "Eliminar ";
            EliminarBoton.UseVisualStyleBackColor = true;
            // 
            // OrdenDeEntregacs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 551);
            Controls.Add(EliminarBoton);
            Controls.Add(EditarBoton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(CancelarBoton);
            Controls.Add(VolverBoton);
            Controls.Add(GenerarBoton);
            Controls.Add(OrdenEntrega);
            Controls.Add(SeleccionarBoton);
            Controls.Add(groupBox2);
            Name = "OrdenDeEntregacs";
            Text = "OrdenDeEntregacs";
            Load += OrdenDeEntregacs_Load;
            groupBox1.ResumeLayout(false);
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
        private Button CancelarBoton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button EditarBoton;
        private Button EliminarBoton;
        private Label label1;
        private TextBox IDtext;
        private TextBox DepositoText;
        private Label label2;
        private TextBox FechaText;
        private ColumnHeader ID;
        private ColumnHeader Cliente;
        private TextBox ClienteText;
        private Label label4;
        private TextBox DireccionText;
        private Label label5;
        private TextBox Notastext;
        private Label label6;
        private Label label3;
        private ColumnHeader IDSeleccionado;
        private ColumnHeader ClienteSeleccionado;
    }
}