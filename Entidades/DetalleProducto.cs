using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Entidades
{
    public class DetalleProducto
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public DetalleProducto(int idProducto, int cantidad)
        {
            IdProducto = idProducto;
            Cantidad = cantidad;
        }
    }
}
