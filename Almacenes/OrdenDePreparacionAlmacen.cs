using GrupoE_Protitipos.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Almacenes
{
    public static class OrdenDePreparacionAlmacen
    {
        private static List<OrdenDePreparacionEntidad> ordenesDePreparacion = new List<OrdenDePreparacionEntidad>();

        private const string path = @"Datos/ordenesDePreparacion.json";

        static OrdenDePreparacionAlmacen()
        {
            if (File.Exists(path))
            {
                var contenido = File.ReadAllText(path);
                ordenesDePreparacion = JsonConvert.DeserializeObject<List<OrdenDePreparacionEntidad>>(contenido);
            }
        }

        public static List<OrdenDePreparacionEntidad> ObtenerOrdenes() {
            List<OrdenDePreparacionEntidad> listaOrdenes = ordenesDePreparacion;
            return ordenesDePreparacion;
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(ordenesDePreparacion);
            File.WriteAllText(path, contenido);
        }

        public static void AgregarOrden(OrdenDePreparacionEntidad orden)
        {
            ordenesDePreparacion.Add(orden);
        }

        public static void ActualizarEstadoPorId(int id, OrdenDePreparacionEstado estado)
        {
            int index = ordenesDePreparacion.FindIndex(ods => ods.IdOrden == id);
            ordenesDePreparacion[index].Estado = estado;
        }

        public static List<OrdenDePreparacionEntidad> ObtenerOrdenesPorEstado(OrdenDePreparacionEstado estado)
        {
            return ordenesDePreparacion.FindAll(ods => ods.Estado == estado);
        }

        public static int ObtenerIdParaNuevaOrden()
        {
            return ordenesDePreparacion.Last().IdOrden + 1;
        }

        public static OrdenDePreparacionEntidad ObtenerOrdenPorId(int idOrden)
        {
            return ordenesDePreparacion.Find(odp => odp.IdOrden == idOrden);
        }

        public static List<OrdenDePreparacionEntidad> ObtenerOrdenesPorIdDeposito(int idDeposito)
        {
            return ordenesDePreparacion.FindAll(odp => odp.Deposito == idDeposito);
        }
    }
}
