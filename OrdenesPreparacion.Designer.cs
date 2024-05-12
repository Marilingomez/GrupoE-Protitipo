namespace GrupoE_Protitipos
{
    partial class OrdenesPreparacion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Orden = new Label();
            OrdenesList = new ListView();
            ID = new ColumnHeader();
            Cliente = new ColumnHeader();
            Estado = new ColumnHeader();
            Confirmar = new Button();
            Cancelar = new Button();
            Salir = new Button();
            DetallesList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            DetalleOrden = new Label();
            SuspendLayout();
            // 
            // Orden
            // 
            Orden.AutoSize = true;
            Orden.Location = new Point(12, 9);
            Orden.Name = "Orden";
            Orden.Size = new Size(133, 15);
            Orden.TabIndex = 0;
            Orden.Text = "Ordenes de preparacion";
            // 
            // OrdenesList
            // 
            OrdenesList.Columns.AddRange(new ColumnHeader[] { ID, Cliente, Estado });
            OrdenesList.FullRowSelect = true;
            OrdenesList.GridLines = true;
            OrdenesList.Location = new Point(12, 27);
            OrdenesList.Name = "OrdenesList";
            OrdenesList.Size = new Size(296, 104);
            OrdenesList.TabIndex = 1;
            OrdenesList.UseCompatibleStateImageBehavior = false;
            OrdenesList.View = View.Details;
            OrdenesList.SelectedIndexChanged += OrdenesList_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 80;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 80;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 80;
            // 
            // Confirmar
            // 
            Confirmar.Location = new Point(329, 46);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(77, 26);
            Confirmar.TabIndex = 2;
            Confirmar.Text = "Confirmar";
            Confirmar.UseVisualStyleBackColor = true;
            Confirmar.Click += Confirmar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(329, 78);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(77, 26);
            Cancelar.TabIndex = 3;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(329, 379);
            Salir.Name = "Salir";
            Salir.Size = new Size(77, 26);
            Salir.TabIndex = 4;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Confirmar_Click;
            // 
            // DetallesList
            // 
            DetallesList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            DetallesList.FullRowSelect = true;
            DetallesList.GridLines = true;
            DetallesList.Location = new Point(12, 169);
            DetallesList.Name = "DetallesList";
            DetallesList.Size = new Size(296, 216);
            DetallesList.TabIndex = 5;
            DetallesList.UseCompatibleStateImageBehavior = false;
            DetallesList.View = View.Details;
            DetallesList.SelectedIndexChanged += OrdenesList_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Producto";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            columnHeader2.Width = 80;
            // 
            // DetalleOrden
            // 
            DetalleOrden.AutoSize = true;
            DetalleOrden.Location = new Point(12, 151);
            DetalleOrden.Name = "DetalleOrden";
            DetalleOrden.Size = new Size(43, 15);
            DetalleOrden.TabIndex = 6;
            DetalleOrden.Text = "Detalle";
            // 
            // Ordenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 407);
            Controls.Add(DetalleOrden);
            Controls.Add(DetallesList);
            Controls.Add(Salir);
            Controls.Add(Cancelar);
            Controls.Add(Confirmar);
            Controls.Add(OrdenesList);
            Controls.Add(Orden);
            Name = "Ordenes";
            Text = "Ordenes";
            Load += Ordenes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Orden;
        private ListView OrdenesList;
        private ColumnHeader ID;
        private ColumnHeader Cliente;
        private ColumnHeader Estado;
        private Button Confirmar;
        private Button Cancelar;
        private Button Salir;
        private ListView DetallesList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label DetalleOrden;
    }
}