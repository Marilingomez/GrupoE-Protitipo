using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Entidades
{
    public class PruebaDos
    {
        internal static List<Deposito> depositos = new();

        internal static List<Deposito> LeerDepositos()
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

            MessageBox.Show("cantidad " + depositos.Count.ToString());

            return depositos;
        }

        internal static List<Deposito> ObtenerDepositos() { return depositos; }
    }
}
