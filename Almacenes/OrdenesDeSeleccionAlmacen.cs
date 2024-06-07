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
    public static class OrdenesDeSeleccionAlmacen
    {
        private static List<OrdenDeSeleccionEntidad> ordenesDeSeleccion = new();

        static OrdenesDeSeleccionAlmacen()
        {
            if (File.Exists(@"Datos/ordenesDeSeleccion.json"))
            {
                var contenido = File.ReadAllText(@"Datos/ordenesDeSeleccion.json");
                ordenesDeSeleccion = JsonConvert.DeserializeObject<List<OrdenDeSeleccionEntidad>>(contenido);
            }
        }

        public static List<OrdenDeSeleccionEntidad> ObtenerOrdenes() { return ordenesDeSeleccion; }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(ordenesDeSeleccion);
            File.WriteAllText(@"Datos/ordenesDeSeleccion.json", contenido);
        }

        public static void AgregarOrden(OrdenDeSeleccionEntidad orden)
        {
            ordenesDeSeleccion.Add(orden);
        } 

        public static void FinalizarOrdenPorIdOrden(int id)
        {
            int index = ordenesDeSeleccion.FindIndex(ods => ods.IdOrden == id);
            ordenesDeSeleccion[index].Estado = Estado.Finalizada;
            ordenesDeSeleccion[index].FechaDeEntrega = DateTime.Now;
        }

        public static List<OrdenDeSeleccionEntidad> ObtenerOrdenesEnEstadoEnTransito()
        {
            return ordenesDeSeleccion.FindAll(ods => ods.Estado == Estado.EnTransito);
        }

        public static OrdenDeSeleccionEntidad ObtenerOrdenPorId(int idOrden)
        {
            return ordenesDeSeleccion.Find(ods => ods.IdOrden == idOrden);
        }

        public static int ObtenerIdParaNuevaOrden()
        {
            return ordenesDeSeleccion.Last().IdOrden + 1;
        }
    }
}
