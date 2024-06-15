using GrupoE_Protitipos.Almacenes;
using GrupoE_Protitipos.ConfirmarOrdenDeEntrega;
using GrupoE_Protitipos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.OrdenDeEntrega
{
    public class OrdenDeEntregaModelo
    {
        public List<OrdenDeEntregaEntidad> OrdenesDeEntrega = OrdenesDeEntregaAlmacen.ObtenerOrdenes();
        public List<OrdenDePreparacionEntidad> OrdenesDePreparacion = 
            OrdenDePreparacionAlmacen.ObtenerOrdenesPorEstado(OrdenDePreparacionEstado.Preparada);

        public void CrearOrdenDeEntrega(int idOrden, string nombreTransportista, DateTime fecha, string deposito, List<int> ordenesDePreparacion) 
        {
            int idDeposito = DepositoAlmacen.ObtenerIdDeDepositoPorNombre(deposito);
            string cuitTransportista = TransportistaAlmacen.ObtenerCuitTransportistaPorNombre(nombreTransportista);

            OrdenDeEntregaEntidad ordenDeEntrega = new OrdenDeEntregaEntidad(idOrden, cuitTransportista, fecha, idDeposito, ordenesDePreparacion);

            OrdenesDeEntregaAlmacen.AgregarOrden(ordenDeEntrega);
        }

        public int ObtenerNuevoIdOrdenesDeEntrega()
        {
            return OrdenesDeEntrega.Last().IdOrden + 1;
        }

        public void ActualizarOrdenesHaciaPorDespachar(List<int> ordenes)
        {
            foreach (var orden in ordenes)
            {
                ActualizarOrdenDePreparacionHaciaPorDespachar(orden);
            }
        }

        public void ActualizarOrdenDePreparacionHaciaPorDespachar(int id)
        {
            OrdenDePreparacionAlmacen.ActualizarEstadoPorId(id, OrdenDePreparacionEstado.PorDespachar);
        }

        public string ValidacionesParaGenerarOrdenDeEntrega(int items, string deposito)
        {
            string errores = "";

            if (items == 0)
            {
                errores += "No ha seleccionado ninguna Orden de Preparación para generar la Orden de Entrega." + Environment.NewLine;
            }

            if (deposito == "")
            {
                errores += "El deposito no puede estar vacio." + Environment.NewLine;
            }

            return errores;
        }

        public List<string> ObtenerDepositos()
        {
            List<DepositoEntidad> depositos = DepositoAlmacen.ObtenerDepositos();
            List<string> nombreDepositos = new List<string>();

            foreach (var deposito in depositos)
            {
                nombreDepositos.Add(deposito.Provincia);
            }

            return nombreDepositos;
        }

        public List<string> ObtenerTransportistas()
        {
            List<TransportistaEntidad> transportistas = TransportistaAlmacen.ObtenerTransportistas();
            List<string> nombreTransportistas = new List<string>();

            foreach (var transportista in transportistas)
            {
                nombreTransportistas.Add(transportista.NombreFantasia);
            }

            return nombreTransportistas;
        }

        public List<OrdenDePreparacionEntidad> ObtenerOrdenesPorNombreDeposito(
            string depositoNombre, 
            OrdenDePreparacionEstado estado
            )
        {
            int idDeposito = DepositoAlmacen.ObtenerIdDeDepositoPorNombre(depositoNombre);
            return OrdenDePreparacionAlmacen.ObtenerOrdenesPorIdDepositoAndEstado(idDeposito, estado);
        }

        public bool ValidacionSobreTransportista(ListView.ListViewItemCollection items)
        {
            List<string> transportistas = new();

            foreach (ListViewItem item in items)
            {
                string nombreTransportista = item.SubItems[3].Text;
                transportistas.Add(nombreTransportista);
            }

            return TieneElementosDistintos(transportistas);
        }

        public static bool TieneElementosDistintos<T>(List<T> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                return false; // Considerar lista vacía o nula como no distinta
            }

            T primerElemento = lista[0];
            foreach (T elemento in lista)
            {
                if (!EqualityComparer<T>.Default.Equals(primerElemento, elemento))
                {
                    return true;
                }
            }

            return false;
        }

        public string ObtenerNombreTransportistaPorId(int idTransportista)
        {
            return TransportistaAlmacen.ObtenerNombrePorId(idTransportista);
        }
    }
}