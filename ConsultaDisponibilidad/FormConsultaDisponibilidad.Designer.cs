namespace GrupoE_Protitipos.ConsultaDisponibilidad
{
    partial class FormConsultaDisponibilidad
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
            desplegableDepositos = new ComboBox();
            espacio = new TextBox();
            label2 = new Label();
            ConsultarEspacio = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Depósito";
            // 
            // desplegableDepositos
            // 
            desplegableDepositos.DropDownStyle = ComboBoxStyle.DropDownList;
            desplegableDepositos.FormattingEnabled = true;
            desplegableDepositos.Location = new Point(14, 36);
            desplegableDepositos.Margin = new Padding(3, 4, 3, 4);
            desplegableDepositos.Name = "desplegableDepositos";
            desplegableDepositos.Size = new Size(138, 28);
            desplegableDepositos.TabIndex = 2;
            desplegableDepositos.SelectedIndexChanged += desplegableDepositos_SelectedIndexChanged;
            // 
            // espacio
            // 
            espacio.Location = new Point(14, 108);
            espacio.Margin = new Padding(3, 4, 3, 4);
            espacio.Name = "espacio";
            espacio.Size = new Size(114, 27);
            espacio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 84);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 4;
            label2.Text = "Espacio a consultar";
            // 
            // ConsultarEspacio
            // 
            ConsultarEspacio.Location = new Point(14, 161);
            ConsultarEspacio.Margin = new Padding(3, 4, 3, 4);
            ConsultarEspacio.Name = "ConsultarEspacio";
            ConsultarEspacio.Size = new Size(138, 31);
            ConsultarEspacio.TabIndex = 5;
            ConsultarEspacio.Text = "Consultar espacio";
            ConsultarEspacio.UseVisualStyleBackColor = true;
            ConsultarEspacio.Click += ConsultarEspacio_Click;
            // 
            // button1
            // 
            button1.Location = new Point(211, 349);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(121, 31);
            button1.TabIndex = 6;
            button1.Text = "Volver al Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormConsultaDisponibilidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 396);
            Controls.Add(button1);
            Controls.Add(ConsultarEspacio);
            Controls.Add(label2);
            Controls.Add(espacio);
            Controls.Add(desplegableDepositos);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormConsultaDisponibilidad";
            Text = "ConsultaDisponibilidad";
            FormClosed += ConsultaDisponibilidad_Closed;
            Load += ConsultaDisponibilidad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox desplegableDepositos;
        private TextBox espacio;
        private Label label2;
        private Button ConsultarEspacio;
        private Button button1;
    }
}