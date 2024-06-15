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

        public void GeneraReserva(int idProducto, int cantidad)
        {
            int productoIndex = Productos.FindIndex(p => p.IdProducto == idProducto);
            Productos[productoIndex].Disponibilidad.AumentaReservado(cantidad);
        }

        public void CancelaReserva(int idProducto, int cantidad)
        {
            int productoIndex = Productos.FindIndex(p => p.IdProducto == idProducto);
            Productos[productoIndex].Disponibilidad.DisminuyeReservado(cantidad);
        }

        public void GeneraSeleccionado(int idProducto, int cantidad)
        {
            int productoIndex = Productos.FindIndex(p => p.IdProducto == idProducto);
            Productos[productoIndex].Disponibilidad.AumentaSeleccionado(cantidad);
        }

        public void BajaProducto(int idProducto, int cantidad)
        {
            int productoIndex = Productos.FindIndex(p => p.IdProducto == idProducto);
            Productos[productoIndex].Disponibilidad.DisminuyeSeleccionado(cantidad);
        }

        public InventarioEntidad Clonar()
        {
            List<DetalleProducto> lista = new();
            foreach (var item in Productos)
            {
                lista.Add(item.Clonar());
            }

            return new InventarioEntidad
            {
                IdInventario = IdInventario,
                Deposito = Deposito,
                Pasillo = Pasillo,
                Fila = Fila,
                Estante = Estante,
                CuitCliente = CuitCliente,
                Productos = lista
            };
        }
    }
}
