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

        public void CrearOrdenDeEntrega(int idOrden, string cuitTransportista, DateTime fecha, string deposito, List<int> ordenesDePreparacion) 
        {
            int idDeposito = DepositoAlmacen.ObtenerIdDeDepositoPorNombre(deposito);

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

        public string ValidacionesParaGenerarOrdenDeEntrega(int items, string deposito, string cuitTransportista)
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

            if (cuitTransportista == "")
            {
                errores += "El Cuit del Transportista no puede estar vacio." + Environment.NewLine;
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

        public List<OrdenDePreparacionEntidad> ObtenerOrdenesPorNombreDeposito(string depositoNombre)
        {
            int idDeposito = DepositoAlmacen.ObtenerIdDeDepositoPorNombre(depositoNombre);
            return OrdenDePreparacionAlmacen.ObtenerOrdenesPorIdDeposito(idDeposito);
        }
    }
}