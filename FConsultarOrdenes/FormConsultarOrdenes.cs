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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoE_Protitipos
{
    public partial class FormConsultarOrdenes : Form
    {
        ConsultarOrdenesModel Model;

        public FormConsultarOrdenes()
        {
            InitializeComponent();

            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ConsultarOrdenes_Load(object sender, EventArgs e)
        {
            Model = new();

            foreach (var orden in Model.Ordenes)
            {
                var fila = new ListViewItem();
                fila.Text = orden.NroOrden.ToString();
                fila.SubItems.Add(orden.DNI.ToString());
                fila.SubItems.Add(orden.Estado);
                fila.SubItems.Add(orden.Fecha.ToString("dd/MM/yyyy"));
                listViewEstado.Items.Add(fila);
            }            

            cmbEstado.Items.Add("Recepción");
            cmbEstado.Items.Add("Preparación");
            cmbEstado.Items.Add("Selección");
            cmbEstado.Items.Add("Entrega");
        }
        private List<ListViewItem> itemsTemporales;

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            listViewEstado.SelectedItems.Clear();

            if (itemsTemporales == null)
            {
                itemsTemporales = new List<ListViewItem>(listViewEstado.Items.Cast<ListViewItem>());
            }

            int nroOrden = -1;
            int dni = -1;
            string estadoSeleccionado = cmbEstado.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(txtNroOrden.Text) && !int.TryParse(txtNroOrden.Text, out nroOrden))
            {
                MessageBox.Show("Por favor, ingrese un N° de Orden válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(txtDni.Text) && (!int.TryParse(txtDni.Text, out dni) || txtDni.Text.Length < 7 || txtDni.Text.Length > 8))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido con entre 7 y 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool ordenEncontrada = false;

            foreach (ListViewItem item in itemsTemporales)
            {
                int nroOrdenItem = int.Parse(item.SubItems[0].Text);
                int dniItem = int.Parse(item.SubItems[1].Text);
                string estadoItem = item.SubItems[2].Text;

                bool cumpleCriterios = true;
                if (nroOrden != -1 && nroOrdenItem != nroOrden)
                {
                    cumpleCriterios = false;
                }
                if (dni != -1 && dniItem != dni)
                {
                    cumpleCriterios = false;
                }
                if (!string.IsNullOrEmpty(estadoSeleccionado) && !estadoItem.Equals(estadoSeleccionado, StringComparison.OrdinalIgnoreCase))
                {
                    cumpleCriterios = false;
                }

                if (!cumpleCriterios)
                {
                    listViewEstado.Items.Remove(item);
                }
                else
                {
                    ordenEncontrada = true;
                }
            }

            if (!ordenEncontrada)
            {
                MessageBox.Show("No se encontró la orden especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroOrden.Text = "";
            txtDni.Text = "";
            cmbEstado.SelectedItem = null;

            RestaurarVistaOriginal();
        }

        private void RestaurarVistaOriginal()
        {
            listViewEstado.SelectedItems.Clear();

            listViewEstado.Items.Clear();

            foreach (var item in itemsTemporales)
            {
                listViewEstado.Items.Add(item);
            }
        }

    }


}
