using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConsultaDisponibilidad
{
    internal class DetalleInventario
    {
        public DetalleInventario(int cantidad, string nombreProducto)
        {
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
        }

        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
