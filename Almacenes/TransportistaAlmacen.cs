using GrupoE_Protitipos.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Almacenes
{
    public static class TransportistaAlmacen
    {
        private static List<TransportistaEntidad> transportistas = new();

        static TransportistaAlmacen()
        {
            if (File.Exists(@"Datos/transportistas.json"))
            {
                var contenido = File.ReadAllText(@"Datos/transportistas.json");
                transportistas = JsonConvert.DeserializeObject<List<TransportistaEntidad>>(contenido);
            }
        }

        public static List<TransportistaEntidad> ObtenerTransportistas() { return transportistas; }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(transportistas);
            File.WriteAllText(@"Datos/transportistas.json", contenido);
        }

        public static TransportistaEntidad ObtenerTransportistaPorCuit(string cuit)
        {
            return transportistas.Find(t => t.CuitTransportista == cuit);
        }

        public static int ObtenerIdTransportistaPorNombre(string nombre)
        {
            return transportistas.Find(t => t.NombreFantasia == nombre).IdTransportista;
        }

        public static string ObtenerCuitTransportistaPorNombre(string nombre)
        {
            return transportistas.Find(t => t.NombreFantasia == nombre).CuitTransportista;
        }

        public static string ObtenerNombrePorId(int idTransportista)
        {
            return transportistas.Find(t => t.IdTransportista == idTransportista).NombreFantasia;
        }
    }
}
