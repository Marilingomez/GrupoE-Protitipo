using GrupoE_Protitipos.ConsultaDisponibilidad;
using GrupoE_Protitipos.ConsultarOrdenes;
using GrupoE_Protitipos.OrdenDeEntrega.EditarOrdenDeEntrega;

namespace GrupoE_Protitipos.OrdenDeEntrega
{
    public partial class FormOrdenDeEntrega : Form
    {
        OrdenPreparacionModelo modelo = new();
        OrdenEntregaModelo modeloentrega = new();

        private List<OrdenPreparacion> ordenes = new List<OrdenPreparacion>();
        private List<OrdenDeEntrega> ordenesdeentrega = new List<OrdenDeEntrega>();
        List<ListViewItem> itemsSeleccionados = new List<ListViewItem>();
        public FormOrdenDeEntrega()
        {
            InitializeComponent();

        }

        private void OrdenDeEntregacs_Load(object sender, EventArgs e)
        {
            foreach (var ordenpreparacion in modelo.OrdenesPreparacion)
            {
                var fila = new ListViewItem();

                fila.Text = ordenpreparacion.IdOrden;
                fila.SubItems.Add(ordenpreparacion.IdCliente);
                fila.SubItems.Add(ordenpreparacion.IdProducto);
                fila.SubItems.Add(ordenpreparacion.Cantidad);
                fila.SubItems.Add(ordenpreparacion.Posicion);
                OrdenSeleccionadaList.Items.Add(fila);
            }

            int nuevoIdEntrega = nuevoIdOrdenDeEntrega();
            IDtext.Text = nuevoIdEntrega.ToString();
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

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            Form formEditarOrdenDeEntrega = new FormEditarOrdenEntrega();
            formEditarOrdenDeEntrega.Show();
        }


        private void GenerarBoton_Click(object sender, EventArgs e)
        {
            if (OrdenEntrega.Items.Count > 0)
            {

                if (string.IsNullOrWhiteSpace(FechaText.Text))
                {
                    MessageBox.Show("Por favor ingrese la fecha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                if (!DateTime.TryParseExact(FechaText.Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out _))
                {
                    MessageBox.Show("Por favor ingrese una fecha en formato válido (DD-MM-YYYY).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                string id = IDtext.Text;
                string transportistacuit = TransportistaCUITText.Text;
                string fecha = FechaText.Text;
                string deposito = DepositoText.Text;

                OrdenDeEntrega nuevaOrden = new OrdenDeEntrega(id, transportistacuit, fecha, deposito)
                {
                    ID = id,
                    TransportistaCUIT = transportistacuit,
                    Fecha = fecha,
                    Deposito = deposito,

                };


                modeloentrega.GuardarOrdenEntrega(nuevaOrden);

                MessageBox.Show("La orden se ha generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                IDtext.Text = nuevoIdOrdenDeEntrega().ToString();
                TransportistaCUITText.Clear();
                FechaText.Clear();
                DepositoText.Clear();


                OrdenEntrega.Items.Clear();
            }
            else
            {
                MessageBox.Show("No hay órdenes seleccionadas para generar la orden de entrega.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarBoton_Click(object sender, EventArgs e)
        {
            //FormEditarOrdenEntrega formularioEditar = new FormEditarOrdenEntrega();


            //formularioEditar.MostrarOrdenes(ordenesdeentrega);
            //formularioEditar.Show();


        }

        private void OrdenSeleccionadaList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void IDtext_TextChanged(object sender, EventArgs e)
        {

        }

        private int nuevoIdOrdenDeEntrega()
        {
            string ultimoIdEntregaString = modeloentrega.OrdenesDeEntrega.Last().ID;
            int ultimoIdEntrega = int.Parse(ultimoIdEntregaString);
            int nuevoIdEntrega = ultimoIdEntrega + 1;
            return nuevoIdEntrega;
        }
    }
}

