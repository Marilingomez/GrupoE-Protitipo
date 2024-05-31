using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConfirmarOrdenDeSeleccion
{
    public class OrdSeleccion
    {
        public int IdOrden { get; set; }
        public int IdCliente { get; set; }
        public string Estado { get; set; }
        public List<int> OrdenesDePreparacion { get; set; }
        public List<DetalleOrdSeleccion> DetalleProductos { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public DateTime FechaDeEntrega { get; set; }

        public OrdSeleccion(int idOrden, int idCliente, string estado, DateTime fechaDeCreacion, List<int> ordenesDePreparacion, List<DetalleOrdSeleccion> detalleProductos)
        {
            IdOrden = idOrden;
            IdCliente = idCliente;
            Estado = estado;
            FechaDeCreacion = fechaDeCreacion;
            OrdenesDePreparacion = ordenesDePreparacion;
            DetalleProductos = detalleProductos;
        }
    }
}
