
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
            btnConsultaDisponibilidad = new Button();
            btnOrdenDePreparacion = new Button();
            OrdendeRecepcionBtn = new Button();
            btnOrdenDeSeleccion = new Button();
            btnOrdenDeEntrega = new Button();
            btnEstadoOrdenes = new Button();
            SuspendLayout();
            // 
            // btnConsultaDisponibilidad
            // 
            btnConsultaDisponibilidad.Location = new Point(144, 32);
            btnConsultaDisponibilidad.Margin = new Padding(3, 2, 3, 2);
            btnConsultaDisponibilidad.Name = "btnConsultaDisponibilidad";
            btnConsultaDisponibilidad.Size = new Size(270, 35);
            btnConsultaDisponibilidad.TabIndex = 0;
            btnConsultaDisponibilidad.Text = "Informar espacio disponible";
            btnConsultaDisponibilidad.UseVisualStyleBackColor = true;
            btnConsultaDisponibilidad.Click += btnConsultaDisponibilidad_Click;
            // 
            // btnOrdenDePreparacion
            // 
            btnOrdenDePreparacion.Location = new Point(144, 132);
            btnOrdenDePreparacion.Margin = new Padding(3, 2, 3, 2);
            btnOrdenDePreparacion.Name = "btnOrdenDePreparacion";
            btnOrdenDePreparacion.Size = new Size(270, 35);
            btnOrdenDePreparacion.TabIndex = 1;
            btnOrdenDePreparacion.Text = "Procesamiento orden de preparacion";
            btnOrdenDePreparacion.UseVisualStyleBackColor = true;
            btnOrdenDePreparacion.Click += btnOrdenDePreparacion_Click;
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
            // btnOrdenDeSeleccion
            // 
            btnOrdenDeSeleccion.Location = new Point(144, 178);
            btnOrdenDeSeleccion.Margin = new Padding(3, 2, 3, 2);
            btnOrdenDeSeleccion.Name = "btnOrdenDeSeleccion";
            btnOrdenDeSeleccion.Size = new Size(270, 35);
            btnOrdenDeSeleccion.TabIndex = 3;
            btnOrdenDeSeleccion.Text = "Orden de seleccion";
            btnOrdenDeSeleccion.UseVisualStyleBackColor = true;
            btnOrdenDeSeleccion.Click += btnOrdenDeSeleccion_Click;
            // 
            // btnOrdenDeEntrega
            // 
            btnOrdenDeEntrega.Location = new Point(144, 226);
            btnOrdenDeEntrega.Margin = new Padding(3, 2, 3, 2);
            btnOrdenDeEntrega.Name = "btnOrdenDeEntrega";
            btnOrdenDeEntrega.Size = new Size(270, 35);
            btnOrdenDeEntrega.TabIndex = 4;
            btnOrdenDeEntrega.Text = "Orden de entrega";
            btnOrdenDeEntrega.UseVisualStyleBackColor = true;
            btnOrdenDeEntrega.Click += btnOrdenDeEntrega_Click;
            // 
            // btnEstadoOrdenes
            // 
            btnEstadoOrdenes.Location = new Point(144, 274);
            btnEstadoOrdenes.Margin = new Padding(3, 2, 3, 2);
            btnEstadoOrdenes.Name = "btnEstadoOrdenes";
            btnEstadoOrdenes.Size = new Size(270, 35);
            btnEstadoOrdenes.TabIndex = 5;
            btnEstadoOrdenes.Text = "Estado de ordenes";
            btnEstadoOrdenes.UseVisualStyleBackColor = true;
            btnEstadoOrdenes.Click += btnEstadoOrdenes_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 338);
            Controls.Add(btnEstadoOrdenes);
            Controls.Add(btnOrdenDeEntrega);
            Controls.Add(btnOrdenDeSeleccion);
            Controls.Add(OrdendeRecepcionBtn);
            Controls.Add(btnOrdenDePreparacion);
            Controls.Add(btnConsultaDisponibilidad);
            Margin = new Padding(3, 2, 3, 2);
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

        private Button btnConsultaDisponibilidad;
        private Button btnOrdenDePreparacion;
        private Button OrdendeRecepcionBtn;
        private Button btnOrdenDeSeleccion;
        private Button btnOrdenDeEntrega;
        private Button btnEstadoOrdenes;
    }

}