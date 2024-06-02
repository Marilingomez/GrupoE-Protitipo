using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.DPreparacionOrden
{
    public class DetalleProductos
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }

        public DetalleProductos(int idProducto, int cantidad)
        {
            IdProducto = idProducto;
            Cantidad = cantidad;
        }
    }
}
