using GrupoE_Protitipos.ConfirmarOrdenDeEntrega;
using GrupoE_Protitipos.ConfirmarOrdenDeSeleccion;
using GrupoE_Protitipos.ConsultaDisponibilidad;
using GrupoE_Protitipos.DPreparacionOrden;
using GrupoE_Protitipos.OrdenDeEntrega;

namespace GrupoE_Protitipos
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        public void btnConsultaDisponibilidad_Click(object sender, EventArgs e)
        {
            Form formConsultaDisponibilidad = new FormConsultaDisponibilidad();
            formConsultaDisponibilidad.Show();
        }

        private void OrdendeRecepcionBtn_Click(object sender, EventArgs e)
        {
            Form formOrdenDeRecepcion = new FormOrdenDeRecepcion();
            formOrdenDeRecepcion.Show();
        }

        private void btnOrdenDePreparacion_Click(object sender, EventArgs e)
        {
            Form formOrdenDePreparacion = new FormOrdenDePreparacion();
            formOrdenDePreparacion.Show();
        }

        private void btnOrdenDeSeleccion_Click(object sender, EventArgs e)
        {
            Form formOrdenSeleccion = new FormOrdenDeSeleccion();
            formOrdenSeleccion.Show();
        }

        private void btnOrdenDeEntrega_Click(object sender, EventArgs e)
        {
            Form formordendeentrega = new FormOrdenDeEntrega();
            formordendeentrega.Show();
        }

        private void btnEstadoOrdenes_Click(object sender, EventArgs e)
        {
            Form formulario = new FormConsultarOrdenes();
            formulario.Show();
        }

        private void confirmarOrdenDeSeleccion_Click(object sender, EventArgs e)
        {
            Form formConfirmarOrdenDeSeleccion = new FormConfirmarOrdenDeSeleccion();
            formConfirmarOrdenDeSeleccion.Show();
        }

        private void btnConfirmarOrdenDeEntrega_Click(object sender, EventArgs e)
        {
            Form formConfirmarOrdenDeEntrega = new FormConfirmarOrdenDeEntrega();
            formConfirmarOrdenDeEntrega.Show();
        }

        private void btnPrepararMercaderia_Click(object sender, EventArgs e)
        {
            Form formPrepararMercaderia = new FormPreparacionOrden();
            formPrepararMercaderia.Show();
        }
    }
}
