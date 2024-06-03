using GrupoE_Protitipos.ConsultaDisponibilidad;
using GrupoE_Protitipos.ConsultarOrdenes;
using GrupoE_Protitipos.Entidades;
using GrupoE_Protitipos.OrdenDeEntrega.EditarOrdenDeEntrega;

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
            foreach (var ordenDePreparacion in modeloentrega.OrdenesDePreparacion)
            {
                var fila = new ListViewItem();

                fila.Text = ordenDePreparacion.IdOrden.ToString();
                fila.SubItems.Add(ordenDePreparacion.CuitCliente.ToString());
                fila.SubItems.Add("0");
                fila.SubItems.Add("0");
                fila.SubItems.Add("0");
                OrdenSeleccionadaList.Items.Add(fila);
            }

            IDtext.Text = modeloentrega.ObtenerNuevoIdOrdenesDeEntrega().ToString();
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {

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
                DepositoText.Text, 
                TransportistaCUITText.Text
                );
            if (errores == "")
            {
                //if (string.IsNullOrWhiteSpace(FechaText.Text))
                //{
                //    MessageBox.Show("Por favor ingrese la fecha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                int id = int.Parse(IDtext.Text);
                string transportistacuit = TransportistaCUITText.Text;
                DateTime fecha = fechaPicker.Value;
                int deposito = int.Parse(DepositoText.Text);
                List<int> ordenesDePreparacion = new List<int>();
                
                foreach (ListViewItem itemSeleccionado in OrdenEntrega.Items)
                {
                    ordenesDePreparacion.Add(int.Parse(itemSeleccionado.SubItems[0].Text));
                }

                OrdenDeEntregaEntidad nuevaOrden = new OrdenDeEntregaEntidad(id, transportistacuit, fecha, deposito, ordenesDePreparacion);

                modeloentrega.GuardarOrdenEntrega(nuevaOrden);
                modeloentrega.ActualizarOrdenesHaciaPorDespachar(ordenesDePreparacion);

                MessageBox.Show("La orden se ha generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                IDtext.Text = modeloentrega.ObtenerNuevoIdOrdenesDeEntrega().ToString();
                TransportistaCUITText.Clear();
                fechaPicker.ResetText();
                DepositoText.Clear();

                OrdenEntrega.Items.Clear();
            }
            else
            {
                MessageBox.Show(errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}

