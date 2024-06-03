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
    public static class ClienteAlmacen
    {
        private static List<ClienteEntidad> clientes = new List<ClienteEntidad>();

        private const string path = @"Datos/clientes.json";

        static ClienteAlmacen()
        {
            if(File.Exists(path))
            {
                var contenido = File.ReadAllText(path);
                clientes = JsonConvert.DeserializeObject<List<ClienteEntidad>>(contenido);
            }
        }

        public static List<ClienteEntidad> ObtenerClientes() { return clientes; }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(clientes);
            File.WriteAllText(path, contenido);
        }

        public static ClienteEntidad ObtenerClientePorCuit(string cuit)
        {
            return clientes.Find(c => c.CuitCliente == cuit);
        }
    }
}
