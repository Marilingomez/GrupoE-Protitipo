
namespace GrupoE_Protitipos
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnOrdenDePreparacion = new Button();
            btnOrdenDeSeleccion = new Button();
            btnOrdenDeEntrega = new Button();
            btnEstadoOrdenes = new Button();
            confirmarOrdenDeSeleccion = new Button();
            btnConfirmarOrdenDeEntrega = new Button();
            btnPrepararMercaderia = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnOrdenDePreparacion
            // 
            btnOrdenDePreparacion.BackColor = Color.FromArgb(161, 32, 89);
            btnOrdenDePreparacion.ForeColor = SystemColors.ButtonHighlight;
            btnOrdenDePreparacion.Location = new Point(146, 85);
            btnOrdenDePreparacion.Name = "btnOrdenDePreparacion";
            btnOrdenDePreparacion.Size = new Size(309, 47);
            btnOrdenDePreparacion.TabIndex = 1;
            btnOrdenDePreparacion.Text = "Procesamiento orden de preparacion";
            btnOrdenDePreparacion.UseVisualStyleBackColor = false;
            btnOrdenDePreparacion.Click += btnOrdenDePreparacion_Click;
            // 
            // btnOrdenDeSeleccion
            // 
            btnOrdenDeSeleccion.BackColor = Color.FromArgb(161, 32, 89);
            btnOrdenDeSeleccion.ForeColor = SystemColors.ButtonHighlight;
            btnOrdenDeSeleccion.Location = new Point(146, 165);
            btnOrdenDeSeleccion.Name = "btnOrdenDeSeleccion";
            btnOrdenDeSeleccion.Size = new Size(309, 47);
            btnOrdenDeSeleccion.TabIndex = 3;
            btnOrdenDeSeleccion.Text = "Orden de seleccion";
            btnOrdenDeSeleccion.UseVisualStyleBackColor = false;
            btnOrdenDeSeleccion.Click += btnOrdenDeSeleccion_Click;
            // 
            // btnOrdenDeEntrega
            // 
            btnOrdenDeEntrega.BackColor = Color.FromArgb(161, 32, 89);
            btnOrdenDeEntrega.ForeColor = SystemColors.ButtonHighlight;
            btnOrdenDeEntrega.Location = new Point(146, 411);
            btnOrdenDeEntrega.Name = "btnOrdenDeEntrega";
            btnOrdenDeEntrega.Size = new Size(309, 47);
            btnOrdenDeEntrega.TabIndex = 4;
            btnOrdenDeEntrega.Text = "Orden de entrega";
            btnOrdenDeEntrega.UseVisualStyleBackColor = false;
            btnOrdenDeEntrega.Click += btnOrdenDeEntrega_Click;
            // 
            // btnEstadoOrdenes
            // 
            btnEstadoOrdenes.BackColor = Color.FromArgb(161, 32, 89);
            btnEstadoOrdenes.ForeColor = SystemColors.ButtonHighlight;
            btnEstadoOrdenes.Location = new Point(146, 573);
            btnEstadoOrdenes.Name = "btnEstadoOrdenes";
            btnEstadoOrdenes.Size = new Size(309, 47);
            btnEstadoOrdenes.TabIndex = 5;
            btnEstadoOrdenes.Text = "Estado de ordenes";
            btnEstadoOrdenes.UseVisualStyleBackColor = false;
            btnEstadoOrdenes.Click += btnEstadoOrdenes_Click;
            // 
            // confirmarOrdenDeSeleccion
            // 
            confirmarOrdenDeSeleccion.BackColor = Color.FromArgb(161, 32, 89);
            confirmarOrdenDeSeleccion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            confirmarOrdenDeSeleccion.ForeColor = SystemColors.ButtonHighlight;
            confirmarOrdenDeSeleccion.Location = new Point(146, 245);
            confirmarOrdenDeSeleccion.Name = "confirmarOrdenDeSeleccion";
            confirmarOrdenDeSeleccion.Size = new Size(309, 47);
            confirmarOrdenDeSeleccion.TabIndex = 6;
            confirmarOrdenDeSeleccion.Text = "Confirmar orden de seleccion";
            confirmarOrdenDeSeleccion.UseVisualStyleBackColor = false;
            confirmarOrdenDeSeleccion.Click += confirmarOrdenDeSeleccion_Click;
            // 
            // btnConfirmarOrdenDeEntrega
            // 
            btnConfirmarOrdenDeEntrega.BackColor = Color.FromArgb(161, 32, 89);
            btnConfirmarOrdenDeEntrega.ForeColor = SystemColors.ButtonHighlight;
            btnConfirmarOrdenDeEntrega.Location = new Point(146, 490);
            btnConfirmarOrdenDeEntrega.Name = "btnConfirmarOrdenDeEntrega";
            btnConfirmarOrdenDeEntrega.Size = new Size(309, 47);
            btnConfirmarOrdenDeEntrega.TabIndex = 7;
            btnConfirmarOrdenDeEntrega.Text = "Confirmar Orden de Entrega";
            btnConfirmarOrdenDeEntrega.UseVisualStyleBackColor = false;
            btnConfirmarOrdenDeEntrega.Click += btnConfirmarOrdenDeEntrega_Click;
            // 
            // btnPrepararMercaderia
            // 
            btnPrepararMercaderia.BackColor = Color.FromArgb(161, 32, 89);
            btnPrepararMercaderia.ForeColor = SystemColors.ButtonHighlight;
            btnPrepararMercaderia.Location = new Point(146, 329);
            btnPrepararMercaderia.Name = "btnPrepararMercaderia";
            btnPrepararMercaderia.Size = new Size(309, 47);
            btnPrepararMercaderia.TabIndex = 8;
            btnPrepararMercaderia.Text = "Preparar Mercaderia";
            btnPrepararMercaderia.UseVisualStyleBackColor = false;
            btnPrepararMercaderia.Click += btnPrepararMercaderia_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(161, 32, 89);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 44);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(598, 647);
            Controls.Add(panel1);
            Controls.Add(btnPrepararMercaderia);
            Controls.Add(btnConfirmarOrdenDeEntrega);
            Controls.Add(confirmarOrdenDeSeleccion);
            Controls.Add(btnEstadoOrdenes);
            Controls.Add(btnOrdenDeEntrega);
            Controls.Add(btnOrdenDeSeleccion);
            Controls.Add(btnOrdenDePreparacion);
            Name = "Menu";
            Text = "Menu Principal";
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        public void Menu_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

#endregion
        private Button btnOrdenDePreparacion;
        private Button btnOrdenDeSeleccion;
        private Button btnOrdenDeEntrega;
        private Button btnEstadoOrdenes;
        private Button confirmarOrdenDeSeleccion;
        private Button btnConfirmarOrdenDeEntrega;
        private Button btnPrepararMercaderia;
        private Panel panel1;
        private PictureBox pictureBox1;
    }

}