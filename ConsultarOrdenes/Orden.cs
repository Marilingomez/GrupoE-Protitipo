using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConsultarOrdenes
{
    internal class Orden
    {
        public int NroOrden { get; set; }
        public int DNI { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }

    }
}
