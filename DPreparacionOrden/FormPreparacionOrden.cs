using GrupoE_Protitipos.ConfirmarOrdenDeEntrega;
using GrupoE_Protitipos.ConsultarOrdenes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoE_Protitipos.DPreparacionOrden
{
    public partial class FormPreparacionOrden : Form
    {
        OrdenDePreparacionModelo modelo = new OrdenDePreparacionModelo();
        public FormPreparacionOrden()
        {
            InitializeComponent();
        }

        private void FormPreparacionOrden_Load(object sender, EventArgs e)
        {
            cargaDatosIniciales();
        }

        private void listOrdenesSeleccionada_ListViewItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                e.Item.Selected = false;
            }
        }

        private void btnProductoPreparado_Click(object sender, EventArgs e)
        {
            if (listaDetalleProducto.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listaDetalleProducto.SelectedItems[0];

                listaDetalleProducto.Items.Remove(selectedItem);
            } else
            {
                MessageBox.Show("Debe seleccionar el producto que ha sido preparado.", "Error");
            }
        }

        private void btnConfirmaOrdenPreparada_Click(object sender, EventArgs e)
        {
            if (listaDetalleProducto.Items.Count != 0)
            {
                MessageBox.Show("Debe preparar todos los productos detallados antes de poder continuar.", "Error");
            } else
            {
                ListViewItem primerOrden = listOrdenesSeleccionada.Items[0];

                int idPrimerOrden = int.Parse(primerOrden.SubItems[0].Text);

                modelo.ActualizarEstadoPorId(idPrimerOrden, OrdenDePreparacionEstado.Preparada);

                MessageBox.Show("La orden ha sido confirmada como Preparada con éxito.", "Operación exitosa");

                listOrdenesSeleccionada.Items.Clear();

                cargaDatosIniciales();
            }
        }

        private void cargaDatosIniciales()
        {
            List<OrdenDePreparacionEntidad> ordenes = modelo.ObtenerOrdenesDePreparacionFiltradasPorEstado(OrdenDePreparacionEstado.Seleccionada);

            cargarOrdenes(ordenes);

            OrdenDePreparacionEntidad primerOrden = ordenes.First(); // TODO: Ver caso que no hay ninguna orden por preparar.

            btnConfirmaOrdenPreparada.Text = "Confirma orden Id " + primerOrden.IdOrden.ToString() + " como Preparada";

            cargaProductos(primerOrden);

            labelDetallePreparar.Text = "Detalle a preparar de orden Id " + primerOrden.IdOrden.ToString();
        }

        private void cargarOrdenes(List<OrdenDePreparacionEntidad> ordenes)
        {
            ordenes.Sort((x, y) => x.Prioridad.CompareTo(y.Prioridad));
            {
                foreach (var orden in ordenes)
                {
                    ListViewItem item = new ListViewItem(new[] {
                        orden.IdOrden.ToString(),
                        orden.IdCliente.ToString(),
                        orden.Prioridad.ToString()
                    });
                    listOrdenesSeleccionada.Items.Add(item);
                }
            }
        }

        private void cargaProductos(OrdenDePreparacionEntidad orden)
        {
            foreach (var producto in orden.DetalleProductos)
            {
                ListViewItem item = new ListViewItem(new[] {
                        producto.IdProducto.ToString(),
                        producto.Cantidad.ToString()
                    });
                listaDetalleProducto.Items.Add(item);
            }
        }
    }
}
