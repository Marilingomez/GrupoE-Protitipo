using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Entidades
{
    public class DetalleProductoDisponibilidad
    {
        public int Disponible {  get; set; }
        public int Precomprometico { get; set; }
        public int Comprometido { get; set; }
    }
}
