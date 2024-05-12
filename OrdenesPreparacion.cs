using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoE_Protitipos
{
    public partial class OrdenesPreparacion : Form
    {
        OrdenesModelo modelo = new();

        public OrdenesPreparacion()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila
            if (OrdenesList.SelectedItems.Count > 0)
            {
                // Obtener la fila seleccionada
                ListViewItem selectedRow = OrdenesList.SelectedItems[0];

                // Obtener el índice de la fila seleccionada
                int selectedIndex = OrdenesList.SelectedIndices[0];

                // Actualizar el estado de la orden en la lista de modelo
                modelo.Ordenes[selectedIndex].Estado = "PENDIENTE";

                // Actualizar la vista del ListView
                selectedRow.SubItems[2].Text = "PENDIENTE"; // Suponiendo que "Estado" es la tercera columna (índice 2) en tu ListView

                // Opcionalmente, puedes mostrar un mensaje para indicar que se ha confirmado la orden
                MessageBox.Show("La orden ha sido confirmada como PENDIENTE.", "Confirmación");
            }
            else
            {
                // Si no se ha seleccionado ninguna fila, mostrar un mensaje de error
                MessageBox.Show("Por favor, seleccione una orden antes de confirmar.", "Error");
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            // Llenar ListView1 con las órdenes
            foreach (var orden in modelo.Ordenes)
            {
                var fila = new ListViewItem();
                fila.Text = orden.ID.ToString();
                fila.SubItems.Add(orden.Cliente.ToString());
                fila.SubItems.Add(orden.Estado);
                OrdenesList.Items.Add(fila);
            }

        }

        private void OrdenesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar ListView2 antes de agregar nuevos detalles
            DetallesList.Items.Clear();

            // Verificar si se ha seleccionado una fila en ListView1
            if (OrdenesList.SelectedItems.Count > 0)
            {
                // Obtener el ID de la orden seleccionada
                int orderId = Convert.ToInt32(OrdenesList.SelectedItems[0].Text);

                // Buscar la orden correspondiente en el modelo
                OrdenPreparacion ordenSeleccionada = modelo.Ordenes.FirstOrDefault(o => o.ID == orderId);

                // Agregar detalles de la orden seleccionada a ListView2
                foreach (var detalle in ordenSeleccionada.Detalles)
                {
                    var fila = new ListViewItem();
                    fila.Text = detalle.Producto;
                    fila.SubItems.Add(detalle.Cantidad.ToString());
                    DetallesList.Items.Add(fila);
                }


            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en OrdenesList
            if (OrdenesList.SelectedItems.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int selectedIndex = OrdenesList.SelectedIndices[0];

                // Verificar si la fila seleccionada tiene el estado pendiente
                if (OrdenesList.SelectedItems[0].SubItems[2].Text == "PENDIENTE")
                {
                    // Eliminar el estado pendiente de la fila seleccionada
                    modelo.Ordenes[selectedIndex].Estado = null;

                    // Actualizar la vista del ListView
                    OrdenesList.SelectedItems[0].SubItems[2].Text = ""; // Limpiar el estado en la vista

                    // Opcionalmente, mostrar un mensaje de confirmación
                    MessageBox.Show("El estado pendiente ha sido eliminado de la orden seleccionada.", "Cancelación");
                }
                else
                {
                    // Si la fila seleccionada no tiene el estado pendiente, mostrar un mensaje de error
                    MessageBox.Show("La orden seleccionada no tiene el estado pendiente para ser cancelado.", "Error");
                }
            }
            else
            {
                // Si no se ha seleccionado ninguna fila, mostrar un mensaje de error
                MessageBox.Show("Por favor, seleccione una orden antes de cancelar.", "Error");
            }
        }
    }
}
