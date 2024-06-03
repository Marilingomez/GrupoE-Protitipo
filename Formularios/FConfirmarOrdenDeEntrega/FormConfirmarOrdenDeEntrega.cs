using GrupoE_Protitipos.ConfirmarOrdenDeSeleccion;
using GrupoE_Protitipos.ConsultaDisponibilidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoE_Protitipos.ConfirmarOrdenDeEntrega
{
    public partial class FormConfirmarOrdenDeEntrega : Form
    {
        public ConfirmarOrdenDeEntregaModelo modelo = new ConfirmarOrdenDeEntregaModelo();
        public FormConfirmarOrdenDeEntrega()
        {
            InitializeComponent();
        }

        private void FormConfirmarOrdenDeEntrega_Load(object sender, EventArgs e)
        {
            cargarOrdenesDeEntregaEnTransito();
        }

        private void listaOrdenesDeEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaOrdenesDeEntrega.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listaOrdenesDeEntrega.SelectedItems[0];

                int idOrdenSeleccionada = int.Parse(selectedItem.SubItems[0].Text);

                OrdEntrega ordenSeleccionada = modelo.ObtenerOrdenesDeEntrega().Find(ode => ode.IdOrden == idOrdenSeleccionada);

                inputCliente.Text = ordenSeleccionada.CuitCliente.ToString();
                inputTransportista.Text = ordenSeleccionada.CuitTransportista.ToString();
                inputIdOrden.Text = idOrdenSeleccionada.ToString();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int idOrdenSeleccionada = int.Parse(inputIdOrden.Text);

            modelo.FinalizarOrdenDeEntrega(idOrdenSeleccionada);

            MessageBox.Show("La orden de entrega ha finalizado con éxito." + Environment.NewLine +
                "Las ordenes de preparación asociadas han pasado a estado Entregadas");

            listaOrdenesDeEntrega.Items.Clear();

            cargarOrdenesDeEntregaEnTransito();
        }

        private void cargarOrdenesDeEntregaEnTransito()
        {
            foreach (var orden in modelo.ObtenerOrdenesDeEntrega())
            {
                ListViewItem item = new ListViewItem(new[] { orden.IdOrden.ToString(), orden.CuitTransportista.ToString(), orden.CuitCliente.ToString() });
                listaOrdenesDeEntrega.Items.Add(item);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
