using GrupoE_Protitipos.Formularios;

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
            Form formConsultaDisponibilidad = new ConsultaDisponibilidad();
            formConsultaDisponibilidad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenDePreparacion_Click(object sender, EventArgs e)
        {
            Form formOrdenDePreparacion = new OrdenesPreparacion();
            formOrdenDePreparacion.Show();
        }

        private void btnOrdenDeSeleccion_Click(object sender, EventArgs e)
        {
            Form formOrdenSeleccion = new OrdenDeSeleccion();
            formOrdenSeleccion.Show();
        }

        private void btnOrdenDeEntrega_Click(object sender, EventArgs e)
        {
            Form formordendeentrega = new OrdenDeEntregacs();
            formordendeentrega.Show();
        }

        private void btnEstadoOrdenes_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultarOrdenes();
            formulario.Show();
        }
    }
}
