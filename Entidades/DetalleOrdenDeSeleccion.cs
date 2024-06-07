using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Entidades
{
    public class DetalleOrdenDeSeleccion
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int Deposito { get; set; }
        public int Pasillo { get; set; }
        public int Fila { get; set; }
        public int Estante { get; set; }

        public string ObtenerUbicacion()
        {
            return "P" + Pasillo + " - F" + Fila + " - E" + Estante;
        }
    }
}
