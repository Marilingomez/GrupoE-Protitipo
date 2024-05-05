
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
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(165, 43);
            button1.Name = "button1";
            button1.Size = new Size(308, 47);
            button1.TabIndex = 0;
            button1.Text = "Informar espacio disponible";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(165, 176);
            button2.Name = "button2";
            button2.Size = new Size(308, 47);
            button2.TabIndex = 1;
            button2.Text = "Procesamiento orden de preparacion";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(165, 111);
            button3.Name = "button3";
            button3.Size = new Size(308, 47);
            button3.TabIndex = 2;
            button3.Text = "Orden recepción";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(165, 238);
            button4.Name = "button4";
            button4.Size = new Size(308, 47);
            button4.TabIndex = 3;
            button4.Text = "Orden de seleccion";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(165, 301);
            button5.Name = "button5";
            button5.Size = new Size(308, 47);
            button5.TabIndex = 4;
            button5.Text = "Orden de entrega";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(165, 366);
            button6.Name = "button6";
            button6.Size = new Size(308, 47);
            button6.TabIndex = 5;
            button6.Text = "Estado de ordenes";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(54, 151);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 6;
            button7.Text = "Mari";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(60, 269);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 7;
            button8.Text = "Alan";
            button8.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        public Button button3;
        public Button button4;
        public Button button5;
        public Button button6;
        private Button button7;
        private Button button8;
    }

}