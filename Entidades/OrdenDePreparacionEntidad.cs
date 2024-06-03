using GrupoE_Protitipos.OrdenDePreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Entidades
{
    public class OrdenDePreparacionEntidad
    {
        public int IdOrden {  get; set; }
        public string CuitCliente { get; set; }
        public DateTime FechaAlta { get; set; }
        public Prioridad Prioridad { get; set; }
        public OrdenDePreparacionEstado Estado { get; set; }
        public List<DetalleOrdenDePreparacion> DetalleOrdenes { get; set; }
    }
}
