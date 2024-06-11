using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrupoE_Protitipos.ConsultarOrdenes;
using GrupoE_Protitipos.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoE_Protitipos
{
    public partial class FormConsultarOrdenes : Form
    {
        ConsultarOrdenesModel Model = new();

        public FormConsultarOrdenes()
        {
            InitializeComponent();
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ConsultarOrdenes_Load(object sender, EventArgs e)
        {
            Array estados = Enum.GetValues(typeof(OrdenDePreparacionEstado));

            cmbEstado.Items.Add("Todos");
            foreach (var estado in estados)
            {
                cmbEstado.Items.Add(estado);   
            }

            List<string> clientes = Model.ObtenerClientes();

            clienteBox.Items.Add("Todos");
            foreach (var cliente in clientes)
            {
                clienteBox.Items.Add(cliente);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string errores = Model.ValidarDatos(txtNroOrden.Text, clienteBox.Text, cmbEstado.Text);
            if(errores.Trim() != "")
            {
                MessageBox.Show(errores, "Error");
                return;
            }

            listViewEstado.Items.Clear();

            string estado = cmbEstado.Text;

            List<OrdenDePreparacionEntidad> ordenes = Model.ObtenerOrdenesFiltradas(txtNroOrden.Text, clienteBox.Text, estado);

            if (ordenes.Count == 0)
            {
                MessageBox.Show("No hay ordenes que coincidan con el filtro indicado: " + Environment.NewLine +
                    "- IdOrden: " + txtNroOrden.Text + Environment.NewLine +
                    "- Cliente: " + clienteBox.Text + Environment.NewLine + 
                    "- Estado: " + estado + "."
                    , "Sin resultados");
                return;
            }

            foreach (var orden in ordenes)
            {
                ListViewItem item = new ListViewItem(new string[] { 
                    orden.IdOrden.ToString(), 
                    orden.CuitCliente,
                    orden.Estado.ToString()
                });

                listViewEstado.Items.Add(item);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroOrden.Text = "";
            clienteBox.SelectedIndex = -1;
            cmbEstado.SelectedItem = null;

            RestaurarVistaOriginal();
        }

        private void RestaurarVistaOriginal()
        {
            listViewEstado.SelectedItems.Clear();
            listViewEstado.Items.Clear();
        }

    }


}
