using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.DataFormats;

namespace GrupoE_Protitipos
{
    public partial class FormOrdenDeSeleccion : Form
    {
        public FormOrdenDeSeleccion()
        {
            InitializeComponent();
        }

        private void FormOrdenDeSeleccion_Load(object sender, EventArgs e)
        {
            // Agregar datos de prueba a listPreparar
            listPreparar.Items.Add("Orden01");
            listPreparar.Items.Add("Orden02");
            listPreparar.Items.Add("Orden03");
            listPreparar.Items.Add("Orden04");
            listPreparar.Items.Add("Orden05");
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (listPreparar.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una orden de la lista ´Órdenes a preparar´.");
                return;
            }

            string selectedOrder = listPreparar.SelectedItem.ToString();
            listPreparar.Items.Remove(selectedOrder);
            listSeleccionada.Items.Add(selectedOrder);

            // Actualizar detalles de productos
            ActualizarDetallesProductos();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listSeleccionada.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una orden de la lista ´Órdenes a seleccionar´.");
                return;
            }

            string selectedOrder = listSeleccionada.SelectedItem.ToString();
            listSeleccionada.Items.Remove(selectedOrder);
            listPreparar.Items.Add(selectedOrder);

            // Actualizar detalles de productos
            ActualizarDetallesProductos();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (listProductos.Items.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos una orden a lista ´Órdenes a seleccionar´.");
                return;
            }

            MessageBox.Show("La orden de selección se ha generado correctamente.");
        }
        private void ActualizarDetallesProductos()
        {
            listProductos.Items.Clear();

            foreach (string orden in listSeleccionada.Items)
            {
                MostrarDetallesProductos(orden);
            }
        }
        private void MostrarDetallesProductos(string orden)
        {
            switch (orden)
            {
                case "Orden01":
                    listProductos.Items.Add("Ubicacion AAA - Remeras - 15.");
                    listProductos.Items.Add("Ubicacion AAB - Camperas - 30.");
                    break;
                case "Orden02":
                    listProductos.Items.Add("Ubicacion BBA - Pelotas - 20.");
                    listProductos.Items.Add("Ubicacion BBB - Mini arcos - 40.");
                    break;
                case "Orden03":
                    listProductos.Items.Add("Ubicacion CCA - Notebooks - 10.");
                    break;
                case "Orden04":
                    listProductos.Items.Add("Ubicacion DDA - Termos - 50.");
                    listProductos.Items.Add("Ubicacion DDB - Bombillas - 100.");
                    break;
                case "Orden05":
                    listProductos.Items.Add("Ubicación EEA - Buzos - 25.");
                    listProductos.Items.Add("Ubicación EEB - Zapatillas - 10.");
                    listProductos.Items.Add("Ubicación EEC - Gorras - 30.");
                    break;
            }
        }        
    }
}

