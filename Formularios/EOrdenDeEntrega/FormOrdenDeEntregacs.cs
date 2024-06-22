using GrupoE_Protitipos.ConsultarOrdenes;
using GrupoE_Protitipos.Entidades;

namespace GrupoE_Protitipos.OrdenDeEntrega
{
    public partial class FormOrdenDeEntrega : Form
    {
        private OrdenDeEntregaModelo modeloentrega = new();

        List<ListViewItem> itemsSeleccionados = new List<ListViewItem>();
        public FormOrdenDeEntrega()
        {
            InitializeComponent();

        }

        private void OrdenDeEntregacs_Load(object sender, EventArgs e)
        {
            IDtext.Text = modeloentrega.ObtenerNuevoIdOrdenesDeEntrega().ToString();

            List<string> depositos = modeloentrega.ObtenerDepositos();
            foreach (var deposito in depositos)
            {
                depositoBox.Items.Add(deposito);
            }

            fechaBox.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            if (OrdenEntrega.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una Orden de Preparación para eliminar.", "Error");
                return;
            }

            foreach (ListViewItem item in OrdenEntrega.SelectedItems)
            {
                OrdenEntrega.Items.Remove(item);
                OrdenSeleccionadaList.Items.Add((ListViewItem)item.Clone());
            }
        }

        private void VolverBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeleccionarBoton_Click(object sender, EventArgs e)
        {
            if (OrdenSeleccionadaList.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in OrdenSeleccionadaList.SelectedItems)
                {
                    OrdenEntrega.Items.Add((ListViewItem)item.Clone());
                    itemsSeleccionados.Add(item);
                }

                foreach (ListViewItem item in itemsSeleccionados)
                {
                    OrdenSeleccionadaList.Items.Remove(item);
                }

                itemsSeleccionados.Clear();
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una Orden de Preparación", "Error");
            }
        }

        private void OrdenEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdenEntrega.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = OrdenEntrega.SelectedItems[0];

                string id = selectedItem.SubItems[0].Text;
                string cliente = selectedItem.SubItems[1].Text;
            }
        }

        private void GenerarBoton_Click(object sender, EventArgs e)
        {
            string errores = modeloentrega.ValidacionesParaGenerarOrdenDeEntrega(
                OrdenEntrega.Items.Count,
                depositoBox.Text
                );

            if (errores != "")
            {
                MessageBox.Show(errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool validacion = modeloentrega.ValidacionSobreTransportista(OrdenEntrega.Items);
            if (validacion)
            {
                MessageBox.Show("Las ordenes seleccionadas deben pertenecer a un mismo transportista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = int.Parse(IDtext.Text);
            DateTime fecha = DateTime.Parse(fechaBox.Text);
            string deposito = depositoBox.Text;
            List<int> ordenesDePreparacion = new List<int>();

            foreach (ListViewItem itemSeleccionado in OrdenEntrega.Items)
            {
                ordenesDePreparacion.Add(int.Parse(itemSeleccionado.SubItems[0].Text));
            }

            string nombreTransportista = OrdenEntrega.Items[0].SubItems[3].Text;

            modeloentrega.CrearOrdenDeEntrega(id, nombreTransportista, fecha, deposito, ordenesDePreparacion);
            modeloentrega.ActualizarOrdenesHaciaPorDespachar(ordenesDePreparacion);

            MessageBox.Show("La orden se ha generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            IDtext.Text = modeloentrega.ObtenerNuevoIdOrdenesDeEntrega().ToString();

            OrdenEntrega.Items.Clear();
        }

        private void DepositoBox_SelectedIndexChange(object sender, EventArgs e)
        {
            OrdenSeleccionadaList.Items.Clear();

            string nombreDeposito = depositoBox.Text;
            CargarOrdenes(nombreDeposito);

            OrdenEntrega.Items.Clear();
        }

        private void CargarOrdenes(string deposito)
        {
            foreach (var ordenDePreparacion in modeloentrega.ObtenerOrdenesPorNombreDeposito(
                deposito,
                OrdenDePreparacionEstado.Preparada
                ))
            {
                var fila = new ListViewItem();
                string nombreTransportista = modeloentrega.ObtenerNombreTransportistaPorId(ordenDePreparacion.IdTransportista);

                fila.Text = ordenDePreparacion.IdOrden.ToString();
                fila.SubItems.Add(ordenDePreparacion.CuitCliente.ToString());
                fila.SubItems.Add(ordenDePreparacion.Prioridad.ToString());
                fila.SubItems.Add(nombreTransportista);
                OrdenSeleccionadaList.Items.Add(fila);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

