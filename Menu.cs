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

        public void button1_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formordendeentrega = new OrdenDeEntregacs();
            formordendeentrega.Show();
        }

        private List<Deposito> leerDepositos()
        {
            string ruta = @"../../../InfoPrecargada/Depositos.txt";
            List<Deposito> depositos = new List<Deposito>();

            try
            {
                // Abrir el archivo para lectura
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        // Dividir la línea en partes usando el punto y coma como separador
                        string[] partes = linea.Split(';');

                        // Convertir los datos a los tipos adecuados
                        if (partes.Length == 2 && int.TryParse(partes[0], out int id))
                        {
                            string ubicacion = partes[1];

                            // Crear una nueva instancia de Deposito y agregarla a la lista
                            Deposito deposito = new Deposito(id, ubicacion);
                            depositos.Add(deposito);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo: " + ex.Message);
            }

            return depositos;
        }
    }
}
