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
    public static class InventarioAlmacen
    {
        private static List<InventarioEntidad> inventarios;

        static InventarioAlmacen()
        {
            if (File.Exists("inventarios.json"))
            {
                var contenido = File.ReadAllText("inventarios.json");
                inventarios = JsonConvert.DeserializeObject<List<InventarioEntidad>>(contenido);
            }
        }

        public static ReadOnlyCollection<InventarioEntidad> Inventarios = inventarios.AsReadOnly();

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(inventarios);
            File.WriteAllText(@"inventarios.json", contenido);
        }
    }
}
