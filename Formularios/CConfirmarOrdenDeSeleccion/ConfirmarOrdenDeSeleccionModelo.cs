using GrupoE_Protitipos.Almacenes;
using GrupoE_Protitipos.Entidades;
using GrupoE_Protitipos.OrdenDeSeleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConfirmarOrdenDeSeleccion
{
    public class ConfirmarOrdenDeSeleccionModelo
    {

        public void FinalizarOrdenDeSeleccion(int idOrden)
        {
            OrdenesDeSeleccionAlmacen.FinalizarOrdenPorIdOrden(idOrden);
        }

        public List<OrdenDeSeleccionEntidad> ObtenerOrdenesEnTransitoPorDeposito(string nombreDeposito)
        {
            int idDeposito = DepositoAlmacen.ObtenerIdDeDepositoPorNombre(nombreDeposito);

            return OrdenesDeSeleccionAlmacen.ObtenerOrdenesEnEstadoEnTransitoPorDeposito(idDeposito);
        }

        public void ActualizarOrdenesDePreparacion(int idOrdenDeSeleccion)
        {
            OrdenDeSeleccionEntidad ordenDeSeleccion = OrdenesDeSeleccionAlmacen.ObtenerOrdenPorId(idOrdenDeSeleccion);

            foreach (var idOrdenPreparacion in ordenDeSeleccion.OrdenesDePreparacion)
            {
                ActualizarOrdenDePreparacionHaciaSeleccionada(idOrdenPreparacion);
            }
        }

        public void ActualizarOrdenDePreparacionHaciaSeleccionada(int idOrden)
        {
            OrdenDePreparacionAlmacen.ActualizarEstadoPorId(idOrden, OrdenDePreparacionEstado.Seleccionada);
        }

        public OrdenDeSeleccionEntidad ObtenerOrdenDeSeleccionPorId(int idOrden)
        {
            return OrdenesDeSeleccionAlmacen.ObtenerOrdenPorId(idOrden);
        }

        public List<string> ObtenerListaDeDepositos()
        {
            return DepositoAlmacen.ObtenerNombreDepositos();
        }

        public string ObtenerNombreDeProductoPorId(int idProducto)
        {
            return ProductoAlmacen.ObtenerProductoPorId(idProducto).Descripcion;
        }

        public void GenerarBajaDeProductos(ListView.ListViewItemCollection productos, string nombreDeposito)
        {
            int idDeposito = DepositoAlmacen.ObtenerIdDeDepositoPorNombre(nombreDeposito);

            foreach (ListViewItem producto in productos)
            {
                int idProducto = ProductoAlmacen.ObtenerIdPorDescripcion(producto.SubItems[0].Text);
                int cantidad = int.Parse(producto.SubItems[1].Text);
                string pasillo = producto.SubItems[2].Text;
                string fila = producto.SubItems[3].Text;
                int estante = int.Parse(producto.SubItems[4].Text);

                InventarioAlmacen.BajaDeProducto(idDeposito, pasillo, fila, estante, idProducto, cantidad);
            }
        }
    }
}
