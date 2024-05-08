using GrupoE_Protitipos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoE_Protitipos.Formularios
{
    public partial class ConsultaDisponibilidad : Form
    {
        List<Deposito> depositos = new List<Deposito>();
        public ConsultaDisponibilidad()
        {
            InitializeComponent();
        }

        private void ConsultaDisponibilidad_Load(object sender, EventArgs e)
        {
            leerDepositosDesdeTxt();
        }

        private void leerDepositosDesdeTxt()
        {
            string ruta = @"../../../InfoPrecargada/Depositos.txt";

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
                            comboBox1.Items.Add(deposito.Ubicacion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo: " + ex.Message);
            }

            MessageBox.Show("cantidad " + depositos.Count.ToString());
        }
    }
}
