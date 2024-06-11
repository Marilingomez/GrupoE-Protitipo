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
        private static List<ProductoEntidad> productos = new();

        static ProductoAlmacen()
        {
            if (File.Exists(@"Datos/productos.json"))
            {
                var contenido = File.ReadAllText(@"Datos/productos.json");
                productos = JsonConvert.DeserializeObject<List<ProductoEntidad>>(contenido);
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(productos);
            File.WriteAllText(@"Datos/productos.json", contenido);
        }

        public static List<ProductoEntidad> ObtenerProductos() { return productos; }

        public static int ObtenerIdPorDescripcion(string descripcion)
        {
            return productos.Find(p => p.Descripcion == descripcion).IdProducto;
        }

        public static ProductoEntidad ObtenerProductoPorId(int idProducto)
        {
            return productos.Find(p => p.IdProducto == idProducto);
        }
    }
}
