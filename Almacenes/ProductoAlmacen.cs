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
    public static class ProductoAlmacen
    {
        private static List<ProductoEntidad> productos;

        static ProductoAlmacen()
        {
            if (File.Exists("productos.json"))
            {
                var contenido = File.ReadAllText("productos.json");
                productos = JsonConvert.DeserializeObject<List<ProductoEntidad>>(contenido);
            }
        }

        public static ReadOnlyCollection<ProductoEntidad> Productos = productos.AsReadOnly();

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(productos);
            File.WriteAllText(@"productos.json", contenido);
        }
    }
}
