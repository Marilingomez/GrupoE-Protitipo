using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrupoE_Protitipos.Entidades;

namespace GrupoE_Protitipos.DPreparacionOrden
{
    public class OrdenDePreparacionEntidadNoUsar
    {
        public int IdOrden { get; set; }
        public int IdCliente { get; set; }
        public Prioridad Prioridad { get; set; }
        public OrdenDePreparacionEstado Estado { get; set; }
        public List<DetalleProductos> DetalleProductos { get; set; }



        public OrdenDePreparacionEntidadNoUsar(
            int idOrden, 
            int idCliente, 
            Prioridad prioridad, 
            OrdenDePreparacionEstado estado,
            List<DetalleProductos> listaDetalleProductos
            )
        {
            IdOrden = idOrden;
            IdCliente = idCliente;
            Prioridad = prioridad;
            Estado = estado;
            DetalleProductos = listaDetalleProductos;
        }
    }
}
