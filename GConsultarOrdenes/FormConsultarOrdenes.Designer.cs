
namespace GrupoE_Protitipos
{
    partial class FormConsultarOrdenes
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
            labelNroOrden = new Label();
            labelDNI = new Label();
            labelEstado = new Label();
            txtNroOrden = new TextBox();
            txtDni = new TextBox();
            cmbEstado = new ComboBox();
            listViewEstado = new ListView();
            NroOrdenCol = new ColumnHeader();
            DniCol = new ColumnHeader();
            EstadoCol = new ColumnHeader();
            FechaCol = new ColumnHeader();
            groupBoxEdicion = new GroupBox();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            groupBoxEdicion.SuspendLayout();
            SuspendLayout();
            // 
            // labelNroOrden
            // 
            labelNroOrden.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNroOrden.AutoSize = true;
            labelNroOrden.Location = new Point(9, 68);
            labelNroOrden.Margin = new Padding(4, 0, 4, 0);
            labelNroOrden.Name = "labelNroOrden";
            labelNroOrden.Size = new Size(112, 25);
            labelNroOrden.TabIndex = 0;
            labelNroOrden.Text = "N° de Orden";
            // 
            // labelDNI
            // 
            labelDNI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDNI.AutoSize = true;
            labelDNI.Location = new Point(449, 68);
            labelDNI.Margin = new Padding(4, 0, 4, 0);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(43, 25);
            labelDNI.TabIndex = 1;
            labelDNI.Text = "DNI";
            // 
            // labelEstado
            // 
            labelEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(791, 68);
            labelEstado.Margin = new Padding(4, 0, 4, 0);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(66, 25);
            labelEstado.TabIndex = 2;
            labelEstado.Text = "Estado";
            labelEstado.Click += labelEstado_Click;
            // 
            // txtNroOrden
            // 
            txtNroOrden.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNroOrden.BorderStyle = BorderStyle.FixedSingle;
            txtNroOrden.Location = new Point(121, 65);
            txtNroOrden.Margin = new Padding(4, 5, 4, 5);
            txtNroOrden.Name = "txtNroOrden";
            txtNroOrden.Size = new Size(261, 31);
            txtNroOrden.TabIndex = 3;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Location = new Point(496, 65);
            txtDni.Margin = new Padding(4, 5, 4, 5);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(261, 31);
            txtDni.TabIndex = 4;
            // 
            // cmbEstado
            // 
            cmbEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(851, 63);
            cmbEstado.Margin = new Padding(4, 5, 4, 5);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(254, 33);
            cmbEstado.TabIndex = 5;
            // 
            // listViewEstado
            // 
            listViewEstado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewEstado.Columns.AddRange(new ColumnHeader[] { NroOrdenCol, DniCol, EstadoCol, FechaCol });
            listViewEstado.FullRowSelect = true;
            listViewEstado.Location = new Point(17, 335);
            listViewEstado.Margin = new Padding(4, 5, 4, 5);
            listViewEstado.Name = "listViewEstado";
            listViewEstado.Size = new Size(1132, 266);
            listViewEstado.TabIndex = 6;
            listViewEstado.UseCompatibleStateImageBehavior = false;
            listViewEstado.View = View.Details;
            // 
            // NroOrdenCol
            // 
            NroOrdenCol.Text = "Nro de Orden";
            NroOrdenCol.Width = 171;
            // 
            // DniCol
            // 
            DniCol.Text = "DNI";
            DniCol.TextAlign = HorizontalAlignment.Center;
            DniCol.Width = 200;
            // 
            // EstadoCol
            // 
            EstadoCol.Text = "Estado";
            EstadoCol.TextAlign = HorizontalAlignment.Center;
            EstadoCol.Width = 200;
            // 
            // FechaCol
            // 
            FechaCol.Text = "Fecha";
            FechaCol.TextAlign = HorizontalAlignment.Center;
            FechaCol.Width = 200;
            // 
            // groupBoxEdicion
            // 
            groupBoxEdicion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxEdicion.Controls.Add(labelNroOrden);
            groupBoxEdicion.Controls.Add(cmbEstado);
            groupBoxEdicion.Controls.Add(txtNroOrden);
            groupBoxEdicion.Controls.Add(labelEstado);
            groupBoxEdicion.Controls.Add(txtDni);
            groupBoxEdicion.Controls.Add(labelDNI);
            groupBoxEdicion.Location = new Point(17, 20);
            groupBoxEdicion.Margin = new Padding(4, 5, 4, 5);
            groupBoxEdicion.Name = "groupBoxEdicion";
            groupBoxEdicion.Padding = new Padding(4, 5, 4, 5);
            groupBoxEdicion.Size = new Size(1132, 162);
            groupBoxEdicion.TabIndex = 7;
            groupBoxEdicion.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiar.Location = new Point(967, 210);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(169, 48);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBuscar.Location = new Point(787, 210);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(169, 48);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // ConsultarOrdenes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 625);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(listViewEstado);
            Controls.Add(groupBoxEdicion);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConsultarOrdenes";
            Text = "Consultar Estado de Ordenes";
            Load += ConsultarOrdenes_Load;
            groupBoxEdicion.ResumeLayout(false);
            groupBoxEdicion.PerformLayout();
            ResumeLayout(false);
        }

        private void labelEstado_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private Label labelNroOrden;
        private Label labelDNI;
        private Label labelEstado;
        private TextBox txtNroOrden;
        private TextBox txtDni;
        private ComboBox cmbEstado;
        private ListView listViewEstado;
        private ColumnHeader NroOrdenCol;
        private ColumnHeader DniCol;
        private ColumnHeader EstadoCol;
        private ColumnHeader FechaCol;
        private GroupBox groupBoxEdicion;
        private Button btnLimpiar;
        private Button btnBuscar;
    }
}