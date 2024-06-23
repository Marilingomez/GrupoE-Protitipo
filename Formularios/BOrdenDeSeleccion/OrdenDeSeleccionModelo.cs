using GrupoE_Protitipos.Almacenes;
using GrupoE_Protitipos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.OrdenDeSeleccion
{
    public class OrdenDeSeleccionModelo
    {
        public List<OrdenDePreparacionEntidad> ObtenerOrdenesDePreparacionPendientesPorDeposito(string deposito)
        {
            int idDeposito = DepositoAlmacen.ObtenerIdDeDepositoPorNombre(deposito);

            return OrdenDePreparacionAlmacen.ObtenerOrdenesPorIdDepositoAndEstado(idDeposito, OrdenDePreparacionEstado.Pendiente);
        }

        public void ActualizarEstadoDeOrdenes(List<int> ordenes)
        {
            foreach (var orden in ordenes)
            {
                ActualizarEstadoDeOrdenHaciaEnSeleccion(orden);
            }
        }

        private void ActualizarEstadoDeOrdenHaciaEnSeleccion(int idOrden)
        {
            OrdenDePreparacionAlmacen.ActualizarEstadoPorId(idOrden, OrdenDePreparacionEstado.EnSeleccion);
        }

        public OrdenDeSeleccionEntidad CrearOrdenDeSeleccion(
            List<int> ordenesDePreparacion, 
            string nombreDeposito,
            ListView.ListViewItemCollection productos
            )
        {
            int idNuevaOrden = OrdenesDeSeleccionAlmacen.ObtenerIdParaNuevaOrden();
            int idDeposito = DepositoAlmacen.ObtenerIdDeDepositoPorNombre(nombreDeposito);
            List<DetalleOrdenDeSeleccion> detalleProductos = ConvertirProductos(productos);

            OrdenDeSeleccionEntidad ordenDeSeleccion = new OrdenDeSeleccionEntidad(
                idNuevaOrden,
                Estado.EnTransito,
                ordenesDePreparacion,
                DateTime.Now,
                idDeposito,
                detalleProductos
                );

            OrdenesDeSeleccionAlmacen.AgregarOrden(ordenDeSeleccion);

            return ordenDeSeleccion;
        }

        public List<DetalleOrdenDeSeleccion> ObtenerProductosParaSeleccionarDeOrdenes(List<int> idOrdenes)
        {
            List<DetalleOrdenDePreparacion> listaDetalleOrdenPrep = new();

            foreach (var idOrden in idOrdenes)
            {
                OrdenDePreparacionEntidad orden = OrdenDePreparacionAlmacen.ObtenerOrdenPorId(idOrden);
                foreach (var producto in orden.DetalleOrdenes)
                {
                    listaDetalleOrdenPrep.Add( producto );
                }
            }

            List<DetalleOrdenDePreparacion> detalleAgrupado = AgruparAndSumar(listaDetalleOrdenPrep);

            List<InventarioEntidad> inventarios = new();

            foreach (var item in detalleAgrupado)
            {
                inventarios.AddRange(InventarioAlmacen.ObtenerInventariosAcumulados(item.IdProducto, item.Cantidad));
            }

            List<DetalleOrdenDeSeleccion> detalleProductos = new();

            foreach (var inventario in inventarios)
            {
                foreach (var producto in inventario.Productos)
                {
                    detalleProductos.Add(new DetalleOrdenDeSeleccion(
                        producto.IdProducto,
                        producto.Disponibilidad.Reservado,
                        inventario.Pasillo,
                        inventario.Fila,
                        inventario.Estante
                        )
                    );
                }
            }

            return detalleProductos;
        }

        private List<DetalleOrdenDePreparacion> AgruparAndSumar(List<DetalleOrdenDePreparacion> detalles)
        {
            return detalles.
                GroupBy(d => d.IdProducto)
                .Select(dt => new DetalleOrdenDePreparacion
                {
                    IdProducto = dt.Key,
                    Cantidad = dt.Sum(x => x.Cantidad)
                })
                .ToList();
        }

        public List<string> ObtenerListaDeDepositos()
        {
            List<DepositoEntidad> depositos = DepositoAlmacen.ObtenerDepositos();
            List<string> listaDepositos = new();

            foreach (var deposito in depositos)
            {
                listaDepositos.Add(deposito.Provincia);
            }

            return listaDepositos;
        }

        public string ObtenerNombreProductoPorId(int id)
        {
            return ProductoAlmacen.ObtenerProductoPorId(id).Descripcion;
        }

        private List<DetalleOrdenDeSeleccion> ConvertirProductos(ListView.ListViewItemCollection productos)
        {
            List<DetalleOrdenDeSeleccion> productosConvertidos = new();

            foreach (ListViewItem producto in productos)
            {
                int idProducto = ProductoAlmacen.ObtenerIdPorDescripcion(producto.SubItems[3].Text);
                int cantidad = int.Parse(producto.SubItems[4].Text);
                string pasillo = producto.SubItems[0].Text;
                string fila = producto.SubItems[1].Text;
                int estante = int.Parse(producto.SubItems[2].Text);

                productosConvertidos.Add(new DetalleOrdenDeSeleccion(idProducto, cantidad, pasillo, fila, estante));
            }

            return productosConvertidos;
        }

        public void ActualizarEstadoProductos(OrdenDeSeleccionEntidad orden)
        {
            foreach (DetalleOrdenDeSeleccion producto in orden.DetalleProductos)
            {
                InventarioAlmacen.GenerarSeleccionDeProducto(
                    orden.Deposito,
                    producto.Pasillo,
                    producto.Fila,
                    producto.Estante,
                    producto.IdProducto,
                    producto.Cantidad
                    );
            }
        }

        public string ObtenerNombrePorCuit(string cuitCliente)
        {
            return ClienteAlmacen.ObtenerClientePorCuit(cuitCliente).NombreFantasia;
        }
    }
}

