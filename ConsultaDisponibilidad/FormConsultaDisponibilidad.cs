using GrupoE_Protitipos.Utiles;

namespace GrupoE_Protitipos.ConsultaDisponibilidad
{
    public partial class FormConsultaDisponibilidad : Form
    {
        ConsultaDisponibilidadModelo modelo;
        public FormConsultaDisponibilidad()
        {
            InitializeComponent();
        }

        private void ConsultaDisponibilidad_Load(object sender, EventArgs e)
        {
            modelo = new ConsultaDisponibilidadModelo();
            modelo.Depositos.ForEach(de => { desplegableDepositos.Items.Add(de.Ubicacion); });
            desplegableDepositos.SelectedIndex = 0;
        }

        private void ConsultaDisponibilidad_Closed(object sender, EventArgs e)
        {

        }

        private void ConsultarEspacio_Click(object sender, EventArgs e)
        {
            string errores = validarDatos();
            if (errores != "")
            {
                MessageBox.Show(errores, "Datos incorrectos.");
                espacio.Focus();
                return;
            }

            int espacioConsultado = int.Parse(espacio.Text);

            string depositoSeleccionado = desplegableDepositos.Text;
            Deposito deposito = modelo.Depositos.Find(it => it.Ubicacion == depositoSeleccionado);

            string detalleEspacio = "Espacio consultado: " + espacioConsultado + "." + Environment.NewLine +
                    "Espacio disponible en el almacen seleccionado: " + deposito.Capacidad + ".";

            if (espacioConsultado < deposito.Capacidad)
            {
                MessageBox.Show(
                    "Existe espacio suficiente en el deposito para almacenar la mercaderia" + Environment.NewLine +
                    detalleEspacio, "Operación disponible"
                    );
            }
            else
            {
                MessageBox.Show(
                    "No existe espacio suficiente en el deposito para almacenar la mercaderia" + Environment.NewLine +
                    detalleEspacio, "Operación no disponible"
                    );
            }

            espacio.Clear();
        }

        private string validarDatos()
        {
            string errores;

            errores = Validadores.EstaVacio(espacio.Text, "Espacio a consultar");
            if (errores != "")
            {
                return errores;
            }

            errores = Validadores.EsNumero(espacio.Text, "Espacio a consultar");

            return errores;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
