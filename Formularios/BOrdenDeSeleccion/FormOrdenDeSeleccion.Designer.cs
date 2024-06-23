namespace GrupoE_Protitipos
{
    partial class FormOrdenDeSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenDeSeleccion));
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            buttonFinalizar = new Button();
            ordenesPreparar = new ListView();
            Id = new ColumnHeader();
            Cliente = new ColumnHeader();
            ordenesSeleccionar = new ListView();
            IdSeleccionado = new ColumnHeader();
            clienteSeleccionado = new ColumnHeader();
            listProductos = new ListView();
            Pasillo = new ColumnHeader();
            Fila = new ColumnHeader();
            Estante = new ColumnHeader();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            depositoLabel = new Label();
            depositoBox = new ComboBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            VolverBoton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(161, 32, 89);
            label1.Location = new Point(18, 116);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 4;
            label1.Text = "Órdenes a preparar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(161, 32, 89);
            label2.Location = new Point(454, 116);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 5;
            label2.Text = "Órdenes a seleccionar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(161, 32, 89);
            label4.Location = new Point(17, 336);
            label4.Name = "label4";
            label4.Size = new Size(170, 20);
            label4.TabIndex = 7;
            label4.Text = "Productos a seleccionar";
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.FromArgb(161, 32, 89);
            buttonAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregar.ForeColor = SystemColors.ButtonHighlight;
            buttonAgregar.Location = new Point(334, 186);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(113, 41);
            buttonAgregar.TabIndex = 16;
            buttonAgregar.Text = "→";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.FromArgb(161, 32, 89);
            buttonEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEliminar.ForeColor = SystemColors.ButtonHighlight;
            buttonEliminar.Location = new Point(334, 232);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(113, 41);
            buttonEliminar.TabIndex = 17;
            buttonEliminar.Text = "←";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.BackColor = Color.FromArgb(161, 32, 89);
            buttonFinalizar.ForeColor = SystemColors.ButtonHighlight;
            buttonFinalizar.Location = new Point(578, 534);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(185, 36);
            buttonFinalizar.TabIndex = 18;
            buttonFinalizar.Text = "Finalizar y Guardar";
            buttonFinalizar.UseVisualStyleBackColor = false;
            buttonFinalizar.Click += buttonFinalizar_Click;
            // 
            // ordenesPreparar
            // 
            ordenesPreparar.Columns.AddRange(new ColumnHeader[] { Id, Cliente });
            ordenesPreparar.FullRowSelect = true;
            ordenesPreparar.Location = new Point(18, 144);
            ordenesPreparar.Margin = new Padding(3, 4, 3, 4);
            ordenesPreparar.Name = "ordenesPreparar";
            ordenesPreparar.Size = new Size(309, 176);
            ordenesPreparar.TabIndex = 19;
            ordenesPreparar.UseCompatibleStateImageBehavior = false;
            ordenesPreparar.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 100;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 200;
            // 
            // ordenesSeleccionar
            // 
            ordenesSeleccionar.Columns.AddRange(new ColumnHeader[] { IdSeleccionado, clienteSeleccionado });
            ordenesSeleccionar.FullRowSelect = true;
            ordenesSeleccionar.Location = new Point(454, 140);
            ordenesSeleccionar.Margin = new Padding(3, 4, 3, 4);
            ordenesSeleccionar.Name = "ordenesSeleccionar";
            ordenesSeleccionar.Size = new Size(309, 176);
            ordenesSeleccionar.TabIndex = 20;
            ordenesSeleccionar.UseCompatibleStateImageBehavior = false;
            ordenesSeleccionar.View = View.Details;
            // 
            // IdSeleccionado
            // 
            IdSeleccionado.Text = "Id";
            IdSeleccionado.Width = 100;
            // 
            // clienteSeleccionado
            // 
            clienteSeleccionado.Text = "Cliente seleccionado";
            clienteSeleccionado.Width = 200;
            // 
            // listProductos
            // 
            listProductos.Columns.AddRange(new ColumnHeader[] { Pasillo, Fila, Estante, Producto, Cantidad });
            listProductos.Location = new Point(17, 360);
            listProductos.Margin = new Padding(3, 4, 3, 4);
            listProductos.Name = "listProductos";
            listProductos.Size = new Size(746, 148);
            listProductos.TabIndex = 21;
            listProductos.UseCompatibleStateImageBehavior = false;
            listProductos.View = View.Details;
            // 
            // Pasillo
            // 
            Pasillo.Text = "Pasillo";
            Pasillo.Width = 90;
            // 
            // Fila
            // 
            Fila.Text = "Fila";
            Fila.Width = 90;
            // 
            // Estante
            // 
            Estante.Text = "Estante";
            Estante.Width = 90;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 300;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 90;
            // 
            // depositoLabel
            // 
            depositoLabel.AutoSize = true;
            depositoLabel.Location = new Point(18, 84);
            depositoLabel.Name = "depositoLabel";
            depositoLabel.Size = new Size(70, 20);
            depositoLabel.TabIndex = 22;
            depositoLabel.Text = "Deposito";
            // 
            // depositoBox
            // 
            depositoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            depositoBox.FormattingEnabled = true;
            depositoBox.Location = new Point(86, 80);
            depositoBox.Margin = new Padding(3, 4, 3, 4);
            depositoBox.Name = "depositoBox";
            depositoBox.Size = new Size(204, 28);
            depositoBox.TabIndex = 23;
            depositoBox.SelectedIndexChanged += depositoBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(161, 32, 89);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 52);
            panel1.TabIndex = 33;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(277, 15);
            label3.Name = "label3";
            label3.Size = new Size(212, 31);
            label3.TabIndex = 2;
            label3.Text = "Orden de Selección";
            // 
            // VolverBoton
            // 
            VolverBoton.BackColor = Color.FromArgb(161, 32, 89);
            VolverBoton.ForeColor = SystemColors.ButtonHighlight;
            VolverBoton.Location = new Point(578, 576);
            VolverBoton.Name = "VolverBoton";
            VolverBoton.Size = new Size(185, 36);
            VolverBoton.TabIndex = 34;
            VolverBoton.Text = "Volver al menu";
            VolverBoton.UseVisualStyleBackColor = false;
            VolverBoton.Click += VolverBoton_Click;
            // 
            // FormOrdenDeSeleccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 630);
            Controls.Add(VolverBoton);
            Controls.Add(panel1);
            Controls.Add(depositoBox);
            Controls.Add(depositoLabel);
            Controls.Add(listProductos);
            Controls.Add(ordenesSeleccionar);
            Controls.Add(ordenesPreparar);
            Controls.Add(buttonFinalizar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormOrdenDeSeleccion";
            Text = "Orden de Selección";
            Load += FormOrdenDeSeleccion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label4;
        private Button buttonAgregar;
        private Button buttonEliminar;
        private Button buttonFinalizar;
        private ListView ordenesPreparar;
        private ColumnHeader Id;
        private ListView ordenesSeleccionar;
        private ColumnHeader Cliente;
        private ColumnHeader IdSeleccionado;
        private ColumnHeader clienteSeleccionado;
        private ListView listProductos;
        private ColumnHeader Pasillo;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private ColumnHeader Fila;
        private ColumnHeader Estante;
        private Label depositoLabel;
        private ComboBox depositoBox;
        private Panel panel1;
        private Button VolverBoton;
        private Label label3;
        private PictureBox pictureBox1;
    }
}