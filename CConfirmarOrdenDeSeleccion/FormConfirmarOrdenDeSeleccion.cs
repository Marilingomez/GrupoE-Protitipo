using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoE_Protitipos.ConfirmarOrdenDeSeleccion
{
    public partial class FormConfirmarOrdenDeSeleccion : Form
    {
        ConfirmarOrdenDeSeleccionModelo modelo = new ConfirmarOrdenDeSeleccionModelo();
        public FormConfirmarOrdenDeSeleccion()
        {
            InitializeComponent();
        }

        private void ConfirmarOrdenDeSeleccion_Load(object sender, EventArgs e)
        {
            CargarOrdenesDeSeleccionEnTransito();
        }

        private void listOrdSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            listDetalleOrden.Items.Clear();

            string selectedItem = listOrdSeleccion.SelectedItem.ToString();

            List<DetalleOrdSeleccion> detalle = modelo.OrdenesDeSeleccion.Find(ods => ods.IdOrden.ToString() == selectedItem).DetalleProductos;

            foreach (var producto in detalle)
            {
                ListViewItem item = new ListViewItem(new[] { producto.IdProducto.ToString(), producto.Cantidad.ToString(), producto.ObtenerUbicacion() });
                listDetalleOrden.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ordenSeleccionada = listOrdSeleccion.SelectedItem.ToString();

            modelo.FinalizarOrdenDeSeleccion(int.Parse(ordenSeleccionada));

            MessageBox.Show("La orden de Selección fue finalizada con éxito." + Environment.NewLine + "Las ordenes de preparación asociadas pasaron a estado Seleccionada");

            listOrdSeleccion.Items.Clear();
            listDetalleOrden.Items.Clear();

            CargarOrdenesDeSeleccionEnTransito();
        }

        private void CargarOrdenesDeSeleccionEnTransito()
        {
            foreach (var orden in modelo.ObtenerOrdenesEnTransito())
            {
                listOrdSeleccion.Items.Add(orden.IdOrden);
            }
        }

        private void MenuPrincipalVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
