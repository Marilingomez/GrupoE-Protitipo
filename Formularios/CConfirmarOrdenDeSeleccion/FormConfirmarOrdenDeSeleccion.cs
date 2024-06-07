using GrupoE_Protitipos.Entidades;
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
            fechaBox.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CargarOrdenesDeSeleccionEnTransito();
        }

        private void listOrdSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaOrdenesEnSeleccion.SelectedItems.Count > 0)
            {
                listDetalleOrden.Items.Clear();

                ListView.SelectedListViewItemCollection selectedItem = listaOrdenesEnSeleccion.SelectedItems;

                int idOrden = int.Parse(selectedItem[0].SubItems[0].Text);

                List<DetalleOrdenDeSeleccion> detalle = modelo.ObtenerOrdenDeSeleccionPorId(idOrden).DetalleProductos;

                foreach (var producto in detalle)
                {
                    ListViewItem item = new ListViewItem(new[] { 
                        producto.IdProducto.ToString(), 
                        producto.Cantidad.ToString(),
                        producto.ObtenerUbicacion()
                    });
                    listDetalleOrden.Items.Add(item);
                }
            }
        }

        private void btnConfirmar_click(object sender, EventArgs e)
        {
            if (listaOrdenesEnSeleccion.SelectedItems.Count == 0) {
                MessageBox.Show("Debe seleccionar una Orden para confirmala como Seleccionada.", "Error");
                return;
            }

            int idOrdenSeleccionada = int.Parse(listaOrdenesEnSeleccion.SelectedItems[0].SubItems[0].Text);

            modelo.FinalizarOrdenDeSeleccion(idOrdenSeleccionada);
            modelo.ActualizarOrdenesDePreparacion(idOrdenSeleccionada);

            MessageBox.Show("La orden de Selección fue finalizada con éxito." + Environment.NewLine + "Las ordenes de preparación asociadas pasaron a estado Seleccionada");

            listaOrdenesEnSeleccion.Items.Clear();
            listDetalleOrden.Items.Clear();

            CargarOrdenesDeSeleccionEnTransito();
        }

        private void CargarOrdenesDeSeleccionEnTransito() {
            foreach (var orden in modelo.ObtenerOrdenesEnTransito())
            {
                ListViewItem item = new(new string[] { 
                    orden.IdOrden.ToString(), 
                    orden.FechaDeCreacion.ToString("dd/MM/yyyy") 
                });
                listaOrdenesEnSeleccion.Items.Add(item);
            }
        }
    }
}
