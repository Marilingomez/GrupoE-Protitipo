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
        public DetalleProductoDisponibilidad Disponibilidad { get; set; }
        public DetalleProducto(int idProducto, DetalleProductoDisponibilidad disponibilidad)
        {
            IdProducto = idProducto;
            Disponibilidad = disponibilidad;
        }

        public DetalleProducto() { }

        public DetalleProducto Clonar()
        {
            return new DetalleProducto
            {
                IdProducto = IdProducto,
                Disponibilidad = Disponibilidad.Clonar(),
            };
        }
    }
}
