namespace GrupoE_Protitipos
{
    partial class formordenderecpcion
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
            CrearOrdenRecepBtn = new Button();
            ConfirmarOrdenRecepBtn = new Button();
            VolverOrdenRecepBtn = new Button();
            SuspendLayout();
            // 
            // CrearOrdenRecepBtn
            // 
            CrearOrdenRecepBtn.Location = new Point(203, 96);
            CrearOrdenRecepBtn.Margin = new Padding(4);
            CrearOrdenRecepBtn.Name = "CrearOrdenRecepBtn";
            CrearOrdenRecepBtn.Size = new Size(385, 59);
            CrearOrdenRecepBtn.TabIndex = 3;
            CrearOrdenRecepBtn.Text = "Crear orden de recepción";
            CrearOrdenRecepBtn.UseVisualStyleBackColor = true;
            // 
            // ConfirmarOrdenRecepBtn
            // 
            ConfirmarOrdenRecepBtn.Location = new Point(203, 199);
            ConfirmarOrdenRecepBtn.Margin = new Padding(4);
            ConfirmarOrdenRecepBtn.Name = "ConfirmarOrdenRecepBtn";
            ConfirmarOrdenRecepBtn.Size = new Size(385, 59);
            ConfirmarOrdenRecepBtn.TabIndex = 4;
            ConfirmarOrdenRecepBtn.Text = "Confirmar orden de recepción";
            ConfirmarOrdenRecepBtn.UseVisualStyleBackColor = true;
            // 
            // VolverOrdenRecepBtn
            // 
            VolverOrdenRecepBtn.Location = new Point(607, 312);
            VolverOrdenRecepBtn.Margin = new Padding(4);
            VolverOrdenRecepBtn.Name = "VolverOrdenRecepBtn";
            VolverOrdenRecepBtn.Size = new Size(180, 36);
            VolverOrdenRecepBtn.TabIndex = 19;
            VolverOrdenRecepBtn.Text = "Volver";
            VolverOrdenRecepBtn.UseVisualStyleBackColor = true;
            VolverOrdenRecepBtn.Click += VolverOrdenRecepBtn_Click;
            // 
            // formordenderecpcion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 361);
            Controls.Add(VolverOrdenRecepBtn);
            Controls.Add(ConfirmarOrdenRecepBtn);
            Controls.Add(CrearOrdenRecepBtn);
            Name = "formordenderecpcion";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Orden de recpcion";
            ResumeLayout(false);
        }

        #endregion

        public Button CrearOrdenRecepBtn;
        public Button ConfirmarOrdenRecepBtn;
        private Button VolverOrdenRecepBtn;
    }
}