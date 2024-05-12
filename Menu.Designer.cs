
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            btnEstadoOrdenes = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(206, 53);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(386, 58);
            button1.TabIndex = 0;
            button1.Text = "Informar espacio disponible";
            button1.UseVisualStyleBackColor = true;

            // 
            // button2
            // 
            button2.Location = new Point(206, 220);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(386, 58);
            button2.TabIndex = 1;
            button2.Text = "Procesamiento orden de preparacion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(206, 138);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(386, 58);
            button3.TabIndex = 2;
            button3.Text = "Orden recepción";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(206, 297);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(386, 58);
            button4.TabIndex = 3;
            button4.Text = "Orden de seleccion";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(206, 377);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(386, 58);
            button5.TabIndex = 4;
            button5.Text = "Orden de entrega";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnEstadoOrdenes
            // 
            btnEstadoOrdenes.Location = new Point(206, 457);
            btnEstadoOrdenes.Margin = new Padding(4, 3, 4, 3);
            btnEstadoOrdenes.Name = "btnEstadoOrdenes";
            btnEstadoOrdenes.Size = new Size(386, 58);
            btnEstadoOrdenes.TabIndex = 5;
            btnEstadoOrdenes.Text = "Estado de ordenes";
            btnEstadoOrdenes.UseVisualStyleBackColor = true;
            btnEstadoOrdenes.Click += btnEstadoOrdenes_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 563);
            Controls.Add(btnEstadoOrdenes);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Menu";
            Text = "Menu Principal";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        public void Menu_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button btnEstadoOrdenes;
    }

}