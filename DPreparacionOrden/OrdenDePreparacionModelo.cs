using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.DPreparacionOrden
{
    public class OrdenDePreparacionModelo
    {
        private List<OrdenDePreparacionEntidad> OrdenesDePreparacion = new List<OrdenDePreparacionEntidad>() { 
            new OrdenDePreparacionEntidad(1, 250, Prioridad.Alta, OrdenDePreparacionEstado.Seleccionada, new List<DetalleProductos>() { 
                new DetalleProductos(1, 20), 
                new DetalleProductos(2, 18),
                new DetalleProductos(3, 4)
            }),
            new OrdenDePreparacionEntidad(2, 345, Prioridad.Media, OrdenDePreparacionEstado.Seleccionada, new List<DetalleProductos>() {
                new DetalleProductos(5, 20),
                new DetalleProductos(6, 18),
                new DetalleProductos(7, 4)
            }),
            new OrdenDePreparacionEntidad(3, 45, Prioridad.Baja, OrdenDePreparacionEstado.Seleccionada, new List<DetalleProductos>() {
                new DetalleProductos(8, 20),
                new DetalleProductos(9, 18),
                new DetalleProductos(10, 4)
            }),
            new OrdenDePreparacionEntidad(4, 346, Prioridad.Media, OrdenDePreparacionEstado.Seleccionada, new List<DetalleProductos>() {
                new DetalleProductos(11, 20),
                new DetalleProductos(12, 18),
                new DetalleProductos(13, 4)
            }),
            new OrdenDePreparacionEntidad(5, 111, Prioridad.Baja, OrdenDePreparacionEstado.Seleccionada, new List<DetalleProductos>() {
                new DetalleProductos(14, 20),
                new DetalleProductos(15, 18),
                new DetalleProductos(16, 4)
            }),
            new OrdenDePreparacionEntidad(6, 321, Prioridad.Baja, OrdenDePreparacionEstado.Seleccionada, new List<DetalleProductos>() {
                new DetalleProductos(17, 20),
                new DetalleProductos(18, 18),
                new DetalleProductos(19, 4)
            }),
            new OrdenDePreparacionEntidad(7, 321, Prioridad.Baja, OrdenDePreparacionEstado.Preparada, new List<DetalleProductos>() {
                new DetalleProductos(20, 20),
                new DetalleProductos(21, 18),
                new DetalleProductos(22, 4)
            })
        };

        public List<OrdenDePreparacionEntidad> ObtenerOrdenesDePreparacionFiltradasPorEstado(OrdenDePreparacionEstado estado)
        {
            return OrdenesDePreparacion.FindAll(odp => odp.Estado == estado);
        }

        public OrdenDePreparacionEntidad ObtenerOrdenPorId(int idOrden)
        {
            return OrdenesDePreparacion.Find(odp => odp.IdOrden == idOrden);
        }

        public void ActualizarEstadoPorId(int idOrden, OrdenDePreparacionEstado estado)
        {
            int index = OrdenesDePreparacion.FindIndex(odp => odp.IdOrden == idOrden);
            OrdenesDePreparacion[index].Estado = estado;
        }
    }
}
