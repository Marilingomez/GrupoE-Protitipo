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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            listProductos = new ListBox();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            buttonFinalizar = new Button();
            ordenesPreparar = new ListView();
            Id = new ColumnHeader();
            Cliente = new ColumnHeader();
            ordenesSeleccionar = new ListView();
            IdSeleccionado = new ColumnHeader();
            clienteSeleccionado = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 12);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 4;
            label1.Text = "Órdenes a preparar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 12);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 5;
            label2.Text = "Órdenes a seleccionar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 169);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 7;
            label4.Text = "Productos a seleccionar";
            // 
            // listProductos
            // 
            listProductos.FormattingEnabled = true;
            listProductos.ItemHeight = 15;
            listProductos.Location = new Point(21, 186);
            listProductos.Margin = new Padding(3, 2, 3, 2);
            listProductos.Name = "listProductos";
            listProductos.Size = new Size(653, 109);
            listProductos.TabIndex = 15;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregar.Location = new Point(298, 64);
            buttonAgregar.Margin = new Padding(3, 2, 3, 2);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(99, 31);
            buttonAgregar.TabIndex = 16;
            buttonAgregar.Text = "→";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(298, 99);
            buttonEliminar.Margin = new Padding(3, 2, 3, 2);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(99, 31);
            buttonEliminar.TabIndex = 17;
            buttonEliminar.Text = "←";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Location = new Point(512, 304);
            buttonFinalizar.Margin = new Padding(3, 2, 3, 2);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(149, 20);
            buttonFinalizar.TabIndex = 18;
            buttonFinalizar.Text = "Finalizar y Guardar";
            buttonFinalizar.UseVisualStyleBackColor = true;
            buttonFinalizar.Click += buttonFinalizar_Click;
            // 
            // ordenesPreparar
            // 
            ordenesPreparar.Columns.AddRange(new ColumnHeader[] { Id, Cliente });
            ordenesPreparar.FullRowSelect = true;
            ordenesPreparar.Location = new Point(21, 33);
            ordenesPreparar.Name = "ordenesPreparar";
            ordenesPreparar.Size = new Size(271, 133);
            ordenesPreparar.TabIndex = 19;
            ordenesPreparar.UseCompatibleStateImageBehavior = false;
            ordenesPreparar.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            // 
            // ordenesSeleccionar
            // 
            ordenesSeleccionar.Columns.AddRange(new ColumnHeader[] { IdSeleccionado, clienteSeleccionado });
            ordenesSeleccionar.FullRowSelect = true;
            ordenesSeleccionar.Location = new Point(403, 30);
            ordenesSeleccionar.Name = "ordenesSeleccionar";
            ordenesSeleccionar.Size = new Size(271, 133);
            ordenesSeleccionar.TabIndex = 20;
            ordenesSeleccionar.UseCompatibleStateImageBehavior = false;
            ordenesSeleccionar.View = View.Details;
            // 
            // IdSeleccionado
            // 
            IdSeleccionado.Text = "Id";
            // 
            // clienteSeleccionado
            // 
            clienteSeleccionado.Text = "Cliente seleccionado";
            // 
            // FormOrdenDeSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(ordenesSeleccionar);
            Controls.Add(ordenesPreparar);
            Controls.Add(buttonFinalizar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(listProductos);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormOrdenDeSeleccion";
            Text = "Orden de Selección";
            Load += FormOrdenDeSeleccion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label4;
        private ListBox listProductos;
        private Button buttonAgregar;
        private Button buttonEliminar;
        private Button buttonFinalizar;
        private ListView ordenesPreparar;
        private ColumnHeader Id;
        private ListView ordenesSeleccionar;
        private ColumnHeader Cliente;
        private ColumnHeader IdSeleccionado;
        private ColumnHeader clienteSeleccionado;
    }
}