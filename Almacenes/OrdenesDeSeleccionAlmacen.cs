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
        private static List<OrdenDeSeleccionEntidad> ordenesDeSeleccion;

        static OrdenesDeSeleccionAlmacen()
        {
            if (File.Exists("ordenesDeSeleccion.json"))
            {
                var contenido = File.ReadAllText("ordenesDeSeleccion.json");
                ordenesDeSeleccion = JsonConvert.DeserializeObject<List<OrdenDeSeleccionEntidad>>(contenido);
            }
        }

        public static ReadOnlyCollection<OrdenDeSeleccionEntidad> OrdenesDeSeleccion = ordenesDeSeleccion.AsReadOnly();

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(ordenesDeSeleccion);
            File.WriteAllText(@"ordenesDeSeleccion.json", contenido);
        }

        public static void AgregarOrden(OrdenDeSeleccionEntidad orden)
        {
            ordenesDeSeleccion.Add(orden);
        } 

        public static void FinalizarOrdenPorIdOrden(int id)
        {
            int index = ordenesDeSeleccion.FindIndex(ods => ods.IdOrden == id);
            ordenesDeSeleccion[index].Estado = Estado.Finalizada;
        }

        public static List<OrdenDeSeleccionEntidad> ObtenerOrdenesEnEstadoEnSeleccion()
        {
            return ordenesDeSeleccion.FindAll(ods => ods.Estado == Estado.EnTransito);
        }
    }
}
