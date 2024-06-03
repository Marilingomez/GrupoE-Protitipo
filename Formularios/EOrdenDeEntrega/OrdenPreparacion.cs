using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.OrdenDeEntrega
{
    public class OrdenPreparacion
    {
        public string IdOrden { get; set; }
        public string IdCliente { get; set; }
        public string IdProducto { get; set; }
        public string Cantidad { get; set; }
        public string Posicion { get; set; }


        public OrdenPreparacion(string IdOrden, string IdCliente, string IdProducto, string Cantidad, string Posicion)
        {
            this.IdOrden = IdOrden;
            this.IdCliente = IdCliente;
            this.IdProducto = IdProducto;
            this.Cantidad = Cantidad;
            this.Posicion = Posicion;

        }
    }
}