using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrupoE_Protitipos.Almacenes;
using GrupoE_Protitipos.Entidades;

namespace GrupoE_Protitipos.DPreparacionOrden
{
    public class OrdenDePreparacionModelo
    {
        private List<OrdenDePreparacionEntidad> OrdenesDePreparacion = OrdenDePreparacionAlmacen.ObtenerOrdenes();

        public List<OrdenDePreparacionEntidad> ObtenerOrdenesDePreparacionSeleccionadas()
        {
            return OrdenDePreparacionAlmacen.ObtenerOrdenesPorEstado(OrdenDePreparacionEstado.Seleccionada);
        }

        public OrdenDePreparacionEntidad ObtenerOrdenPorId(int idOrden)
        {
            return OrdenDePreparacionAlmacen.ObtenerOrdenPorId(idOrden);
        }

        public void ActualizarEstadoHaciaPreparado(int idOrden)
        {
            OrdenDePreparacionAlmacen.ActualizarEstadoPorId(idOrden, OrdenDePreparacionEstado.Preparada);
        }

        public string ObtenerNombreDeProductoPorId(int idProducto)
        {
            return ProductoAlmacen.ObtenerProductoPorId(idProducto).Descripcion;
        }
    }
}
