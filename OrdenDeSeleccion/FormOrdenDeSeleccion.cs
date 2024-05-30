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
                MessageBox.Show("Debe seleccionar una orden.");
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
                MessageBox.Show("Debe seleccionar una orden.");
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
                MessageBox.Show("Debe seleccionar al menos una orden.");
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
                    listProductos.Items.Add("Orden01: Ubicacion AAA, Remeras 15, Camperas 30.");
                    break;
                case "Orden02":
                    listProductos.Items.Add("Orden02: Ubicacion BBB, Pelotas 20, Mini arcos 40.");
                    break;
                case "Orden03":
                    listProductos.Items.Add("Orden03: Ubicacion CCC, 10 Notebooks.");
                    break;
                case "Orden04":
                    listProductos.Items.Add("Orden04: Ubicacion DDD, 50 termos, 100 bombillas.");
                    break;
                case "Orden05":
                    listProductos.Items.Add("Orden05: Ubicación EEE, Buzos 25, Zapatillas 10, Gorras 30.");
                    break;
            }
        }        
    }
}

