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
        public string CuitCliente { get; set; }
        public Estado Estado { get; set; }
        public List<int> OrdenesDePreparacion { get; set; }
        public List<DetalleOrdenDeSeleccion> DetalleProductos { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public DateTime FechaDeEntrega { get; set; }
    }
}
