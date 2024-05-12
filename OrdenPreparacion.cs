using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos
{
    internal class OrdenPreparacion
    {
        public int ID { get; set; }
        public int Cliente { get; set; }
        public string? Estado { get; set; }

        public List<DetalleOrdenDePreparacion> Detalles { get; set; } // Detalles de la orden

        public OrdenPreparacion()
        {

            Detalles = new List<DetalleOrdenDePreparacion>();

        }
    }
}
