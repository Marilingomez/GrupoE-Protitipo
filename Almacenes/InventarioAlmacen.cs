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
        private static List<InventarioEntidad> inventarios = new();

        static InventarioAlmacen()
        {
            if (File.Exists(@"Datos/inventarios.json"))
            {
                var contenido = File.ReadAllText(@"Datos/inventarios.json");
                inventarios = JsonConvert.DeserializeObject<List<InventarioEntidad>>(contenido);
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(inventarios);
            File.WriteAllText(@"Datos/inventarios.json", contenido);
        }

        public static List<InventarioEntidad> ObtenerInventarios() { return inventarios; }

        public static int ObtenerCantidadDeProductoPorClienteYDeposito(string cuitCliente, int idProducto, int idDeposito)
        {
            return inventarios
                .Where(i => i.CuitCliente == cuitCliente && i.Deposito == idDeposito)
                .SelectMany(i => i.Productos)
                .Where(p => p.IdProducto == idProducto)
                .Sum(p => p.Disponibilidad.Disponible);
        }
    }
}
