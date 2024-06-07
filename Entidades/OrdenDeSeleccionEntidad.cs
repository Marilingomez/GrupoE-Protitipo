using GrupoE_Protitipos.DPreparacionOrden;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Entidades
{
    public class OrdenDeSeleccionEntidad
    {
        public int IdOrden {  get; set; }
        public Estado Estado { get; set; }
        public List<int> OrdenesDePreparacion { get; set; }
        public List<DetalleOrdenDeSeleccion> DetalleProductos { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public DateTime FechaDeEntrega { get; set; }

        public OrdenDeSeleccionEntidad(int idOrden, Estado estado, List<int> ordenesDePreparacion, DateTime fechaDeCreacion)
        {
            IdOrden = idOrden;
            Estado = estado;
            OrdenesDePreparacion = ordenesDePreparacion;
            DetalleProductos = new List<DetalleOrdenDeSeleccion>();
            FechaDeCreacion = fechaDeCreacion;
        }
    }
}
