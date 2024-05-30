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
            listPreparar = new ListBox();
            listSeleccionada = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            listProductos = new ListBox();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            buttonFinalizar = new Button();
            SuspendLayout();
            // 
            // listPreparar
            // 
            listPreparar.FormattingEnabled = true;
            listPreparar.ItemHeight = 20;
            listPreparar.Items.AddRange(new object[] { "Orden01", "Orden02", "Orden03", "Orden04", "Orden05" });
            listPreparar.Location = new Point(24, 39);
            listPreparar.Name = "listPreparar";
            listPreparar.Size = new Size(306, 164);
            listPreparar.TabIndex = 1;
            // 
            // listSeleccionada
            // 
            listSeleccionada.FormattingEnabled = true;
            listSeleccionada.ItemHeight = 20;
            listSeleccionada.Location = new Point(464, 39);
            listSeleccionada.MultiColumn = true;
            listSeleccionada.Name = "listSeleccionada";
            listSeleccionada.Size = new Size(306, 164);
            listSeleccionada.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 16);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 4;
            label1.Text = "Órdenes a preparar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 16);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 5;
            label2.Text = "Órdenes a seleccionar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 225);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 7;
            label4.Text = "Productos a seleccionar";
            // 
            // listProductos
            // 
            listProductos.FormattingEnabled = true;
            listProductos.ItemHeight = 20;
            listProductos.Location = new Point(24, 248);
            listProductos.Name = "listProductos";
            listProductos.Size = new Size(746, 144);
            listProductos.TabIndex = 15;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregar.Location = new Point(341, 85);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(113, 41);
            buttonAgregar.TabIndex = 16;
            buttonAgregar.Text = "→";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(341, 132);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(113, 41);
            buttonEliminar.TabIndex = 17;
            buttonEliminar.Text = "←";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Location = new Point(585, 406);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(170, 27);
            buttonFinalizar.TabIndex = 18;
            buttonFinalizar.Text = "Finalizar y Guardar";
            buttonFinalizar.UseVisualStyleBackColor = true;
            buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // FormOrdenDeSeleccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFinalizar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(listProductos);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listSeleccionada);
            Controls.Add(listPreparar);
            Name = "FormOrdenDeSeleccion";
            Text = "Orden de Selección";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listPreparar;
        private ListBox listSeleccionada;
        private Label label1;
        private Label label2;
        private Label label4;
        private ListBox listProductos;
        private Button buttonAgregar;
        private Button buttonEliminar;
        private Button buttonFinalizar;
    }
}