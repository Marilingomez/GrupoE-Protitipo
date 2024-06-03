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
    public static class OrdenesDeEntregaAlmacen
    {
        private static List<OrdenDeEntregaEntidad> ordenesDeEntrega = new List<OrdenDeEntregaEntidad>();

        static OrdenesDeEntregaAlmacen()
        {
            if (File.Exists(@"Datos/ordenesDeEntrega.json"))
            {
                var contenido = File.ReadAllText(@"Datos/ordenesDeEntrega.json");
                ordenesDeEntrega = JsonConvert.DeserializeObject<List<OrdenDeEntregaEntidad>>(contenido);
            }
        }

        public static List<OrdenDeEntregaEntidad> ObtenerOrdenes() { return ordenesDeEntrega; }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(ordenesDeEntrega);
            File.WriteAllText(@"Datos/ordenesDeEntrega.json", contenido);
        }

        public static void AgregarOrden(OrdenDeEntregaEntidad orden)
        {
            ordenesDeEntrega.Add(orden);
        }

        public static void FinalizarOrdenPorIdOrden(int id)
        {
            int index = ordenesDeEntrega.FindIndex(ods => ods.IdOrden == id);
            ordenesDeEntrega[index].Estado = Estado.Finalizada;
        }

        public static List<OrdenDeEntregaEntidad> ObtenerOrdenesEnEstadoEnSeleccion()
        {
            return ordenesDeEntrega.FindAll(ods => ods.Estado == Estado.EnTransito);
        }
    }
}
