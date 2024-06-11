using GrupoE_Protitipos.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Almacenes
{
    public static class DepositoAlmacen
    {
        private static List<DepositoEntidad> depositos = new List<DepositoEntidad>();

        static DepositoAlmacen()
        {
            if(File.Exists(@"Datos/depositos.json"))
            {
                var contenido = File.ReadAllText(@"Datos/depositos.json");
                depositos = JsonConvert.DeserializeObject<List<DepositoEntidad>>(contenido);
            }
        }

        public static List<DepositoEntidad> ObtenerDepositos() { return depositos; }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(depositos);
            File.WriteAllText(@"Datos/depositos.json", contenido);
        }

        public static DepositoEntidad ObtenerDepositoPorId(int id)
        {
            return depositos.Find(d => d.IdDeposito == id);
        }

        public static int ObtenerIdDeDepositoPorNombre(string nombre)
        {
            return depositos.Find(d => d.Provincia == nombre).IdDeposito;
        }
    }
}
