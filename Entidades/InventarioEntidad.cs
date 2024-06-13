using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Entidades
{
    public class InventarioEntidad
    {
        public int IdInventario {  get; set; }
        public int Deposito { get; set; }
        public string Pasillo { get; set; }
        public string Fila {  get; set; }
        public int Estante { get; set; }
        public string CuitCliente { get; set; }
        public List<DetalleProducto> Productos { get; set; }

        public void GeneraPrereserva(int idProducto, int cantidad)
        {
            int productoIndex = Productos.FindIndex(p => p.IdProducto == idProducto);
            Productos[productoIndex].Disponibilidad.AumentaPrereservado(cantidad);
        }

        public void CancelaDisponible(int idProducto, int cantidad)
        {
            int productoIndex = Productos.FindIndex(p => p.IdProducto == idProducto);
            Productos[productoIndex].Disponibilidad.DisminuyeDisponible(cantidad);
        }

        public void CancelaPrereserva(int idProducto, int cantidad)
        {
            int productoIndex = Productos.FindIndex(p => p.IdProducto == idProducto);
            Productos[productoIndex].Disponibilidad.DisminuyePrereservado(cantidad);
        }

        public void GeneraDisponible(int idProducto, int cantidad)
        {
            int productoIndex = Productos.FindIndex(p => p.IdProducto == idProducto);
            Productos[productoIndex].Disponibilidad.AumentaDisponible(cantidad);
        }
    }
}
