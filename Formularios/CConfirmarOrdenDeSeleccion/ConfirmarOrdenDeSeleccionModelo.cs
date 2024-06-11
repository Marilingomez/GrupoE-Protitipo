using GrupoE_Protitipos.Almacenes;
using GrupoE_Protitipos.Entidades;
using GrupoE_Protitipos.OrdenDeSeleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConfirmarOrdenDeSeleccion
{
    public class ConfirmarOrdenDeSeleccionModelo
    {

        public void FinalizarOrdenDeSeleccion(int idOrden)
        {
            OrdenesDeSeleccionAlmacen.FinalizarOrdenPorIdOrden(idOrden);
        }

        public List<OrdenDeSeleccionEntidad> ObtenerOrdenesEnTransito()
        {
            return OrdenesDeSeleccionAlmacen.ObtenerOrdenesEnEstadoEnTransito();
        }

        public void ActualizarOrdenesDePreparacion(int idOrdenDeSeleccion)
        {
            OrdenDeSeleccionEntidad ordenDeSeleccion = OrdenesDeSeleccionAlmacen.ObtenerOrdenPorId(idOrdenDeSeleccion);

            foreach (var idOrdenPreparacion in ordenDeSeleccion.OrdenesDePreparacion)
            {
                ActualizarOrdenDePreparacionHaciaSeleccionada(idOrdenPreparacion);
            }
        }

        public void ActualizarOrdenDePreparacionHaciaSeleccionada(int idOrden)
        {
            OrdenDePreparacionAlmacen.ActualizarEstadoPorId(idOrden, OrdenDePreparacionEstado.Seleccionada);
        }

        public OrdenDeSeleccionEntidad ObtenerOrdenDeSeleccionPorId(int idOrden)
        {
            return OrdenesDeSeleccionAlmacen.ObtenerOrdenPorId(idOrden);
        }
    }
}
