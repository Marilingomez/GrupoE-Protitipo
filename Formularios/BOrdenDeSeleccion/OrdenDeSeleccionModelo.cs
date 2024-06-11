using GrupoE_Protitipos.Almacenes;
using GrupoE_Protitipos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.OrdenDeSeleccion
{
    public class OrdenDeSeleccionModelo
    {
        public List<OrdenDePreparacionEntidad> ObtenerOrdenesDePreparacionPendientes()
        {
            return OrdenDePreparacionAlmacen.ObtenerOrdenesPorEstado(OrdenDePreparacionEstado.Pendiente);
        }

        public void ActualizarEstadoDeOrdenes(List<int> ordenes)
        {
            foreach (var orden in ordenes)
            {
                ActualizarEstadoDeOrdenHaciaEnSeleccion(orden);
            }
        }

        private void ActualizarEstadoDeOrdenHaciaEnSeleccion(int idOrden)
        {
            OrdenDePreparacionAlmacen.ActualizarEstadoPorId(idOrden, OrdenDePreparacionEstado.EnSeleccion);
        }

        public void CrearOrdenDeSeleccion(List<int> ordenesDePreparacion)
        {
            int idNuevaOrden = OrdenesDeSeleccionAlmacen.ObtenerIdParaNuevaOrden();
            OrdenDeSeleccionEntidad ordenDeSeleccion = new OrdenDeSeleccionEntidad(
                idNuevaOrden,
                Estado.EnTransito,
                ordenesDePreparacion,
                DateTime.Now
                );

            OrdenesDeSeleccionAlmacen.AgregarOrden(ordenDeSeleccion);
        }


    }
}
