
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
            cmbEstado = new ComboBox();
            listViewEstado = new ListView();
            NroOrdenCol = new ColumnHeader();
            DniCol = new ColumnHeader();
            EstadoCol = new ColumnHeader();
            FechaCol = new ColumnHeader();
            groupBoxEdicion = new GroupBox();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            clienteBox = new ComboBox();
            groupBoxEdicion.SuspendLayout();
            SuspendLayout();
            // 
            // labelNroOrden
            // 
            labelNroOrden.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNroOrden.AutoSize = true;
            labelNroOrden.Location = new Point(6, 41);
            labelNroOrden.Name = "labelNroOrden";
            labelNroOrden.Size = new Size(73, 15);
            labelNroOrden.TabIndex = 0;
            labelNroOrden.Text = "N° de Orden";
            // 
            // labelDNI
            // 
            labelDNI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDNI.AutoSize = true;
            labelDNI.Location = new Point(314, 41);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(44, 15);
            labelDNI.TabIndex = 1;
            labelDNI.Text = "Cliente";
            // 
            // labelEstado
            // 
            labelEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(554, 41);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(42, 15);
            labelEstado.TabIndex = 2;
            labelEstado.Text = "Estado";
            labelEstado.Click += labelEstado_Click;
            // 
            // txtNroOrden
            // 
            txtNroOrden.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNroOrden.BorderStyle = BorderStyle.FixedSingle;
            txtNroOrden.Location = new Point(85, 39);
            txtNroOrden.Name = "txtNroOrden";
            txtNroOrden.Size = new Size(183, 23);
            txtNroOrden.TabIndex = 3;
            // 
            // cmbEstado
            // 
            cmbEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(596, 38);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(179, 23);
            cmbEstado.TabIndex = 5;
            // 
            // listViewEstado
            // 
            listViewEstado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewEstado.Columns.AddRange(new ColumnHeader[] { NroOrdenCol, DniCol, EstadoCol, FechaCol });
            listViewEstado.FullRowSelect = true;
            listViewEstado.Location = new Point(12, 201);
            listViewEstado.Name = "listViewEstado";
            listViewEstado.Size = new Size(794, 161);
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
            groupBoxEdicion.Controls.Add(clienteBox);
            groupBoxEdicion.Controls.Add(labelNroOrden);
            groupBoxEdicion.Controls.Add(cmbEstado);
            groupBoxEdicion.Controls.Add(txtNroOrden);
            groupBoxEdicion.Controls.Add(labelEstado);
            groupBoxEdicion.Controls.Add(labelDNI);
            groupBoxEdicion.Location = new Point(12, 12);
            groupBoxEdicion.Name = "groupBoxEdicion";
            groupBoxEdicion.Size = new Size(792, 97);
            groupBoxEdicion.TabIndex = 7;
            groupBoxEdicion.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpiar.Location = new Point(677, 126);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(118, 29);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBuscar.Location = new Point(551, 126);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(118, 29);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // clienteBox
            // 
            clienteBox.DropDownStyle = ComboBoxStyle.DropDownList;
            clienteBox.FormattingEnabled = true;
            clienteBox.Location = new Point(364, 39);
            clienteBox.Name = "clienteBox";
            clienteBox.Size = new Size(141, 23);
            clienteBox.TabIndex = 10;
            // 
            // FormConsultarOrdenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 375);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(listViewEstado);
            Controls.Add(groupBoxEdicion);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultarOrdenes";
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
        private ComboBox cmbEstado;
        private ListView listViewEstado;
        private ColumnHeader NroOrdenCol;
        private ColumnHeader DniCol;
        private ColumnHeader EstadoCol;
        private ColumnHeader FechaCol;
        private GroupBox groupBoxEdicion;
        private Button btnLimpiar;
        private Button btnBuscar;
        private ComboBox clienteBox;
    }
}