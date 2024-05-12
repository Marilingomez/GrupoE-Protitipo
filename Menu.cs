using GrupoE_Protitipos.Formularios;
using GrupoE_Protitipos.Utiles;
using System.Reflection.Metadata.Ecma335;
using GrupoE_Protitipos.Entidades.Deposito;

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

        private void button2_Click(object sender, EventArgs e)
        {

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
