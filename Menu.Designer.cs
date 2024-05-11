
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
            OrdendeRecepcionBtn = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(206, 54);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(385, 59);
            button1.TabIndex = 0;
            button1.Text = "Informar espacio disponible";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(206, 220);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(385, 59);
            button2.TabIndex = 1;
            button2.Text = "Procesamiento orden de preparacion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // OrdendeRecepcionBtn
            // 
            OrdendeRecepcionBtn.Location = new Point(206, 139);
            OrdendeRecepcionBtn.Margin = new Padding(4, 4, 4, 4);
            OrdendeRecepcionBtn.Name = "OrdendeRecepcionBtn";
            OrdendeRecepcionBtn.Size = new Size(385, 59);
            OrdendeRecepcionBtn.TabIndex = 2;
            OrdendeRecepcionBtn.Text = "Orden recepción";
            OrdendeRecepcionBtn.UseVisualStyleBackColor = true;
            OrdendeRecepcionBtn.Click += OrdendeRecepcionBtn_Click;
            // 
            // button4
            // 
            button4.Location = new Point(206, 298);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(385, 59);
            button4.TabIndex = 3;
            button4.Text = "Orden de seleccion";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(206, 376);
            button5.Margin = new Padding(4, 4, 4, 4);
            button5.Name = "button5";
            button5.Size = new Size(385, 59);
            button5.TabIndex = 4;
            button5.Text = "Orden de entrega";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(206, 458);
            button6.Margin = new Padding(4, 4, 4, 4);
            button6.Name = "button6";
            button6.Size = new Size(385, 59);
            button6.TabIndex = 5;
            button6.Text = "Estado de ordenes";
            button6.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 562);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(OrdendeRecepcionBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 4, 4, 4);
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

        public Button button1;
        public Button button2;
        public Button OrdendeRecepcionBtn;
        public Button button4;
        public Button button5;
        public Button button6;
    }

}