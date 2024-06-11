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
        private static List<TransportistaEntidad> transportistas;

        static TransportistaAlmacen()
        {
            if (File.Exists("transportistas.json"))
            {
                var contenido = File.ReadAllText("transportistas.json");
                transportistas = JsonConvert.DeserializeObject<List<TransportistaEntidad>>(contenido);
            }
        }

        public static ReadOnlyCollection<TransportistaEntidad> Transportistas = transportistas.AsReadOnly();

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(transportistas);
            File.WriteAllText(@"transportistas.json", contenido);
        }

        public static TransportistaEntidad ObtenerTransportistaPorCuit(string cuit)
        {
            return transportistas.Find(t => t.CuitTransportista == cuit);
        }
    }
}
