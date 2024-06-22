using GrupoE_Protitipos.Almacenes;
using GrupoE_Protitipos.Entidades;
using GrupoE_Protitipos.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConfirmarOrdenDeEntrega
{
    public class ConfirmarOrdenDeEntregaModelo
    {
        public List<OrdenDeEntregaEntidad> ObtenerOrdenesDeEntregaEnTransito()
        {
            return OrdenesDeEntregaAlmacen.ObtenerOrdenesEnEstadoEnTransito();
        }

        public void FinalizarOrdenDeEntrega(int idOrden)
        {
            OrdenesDeEntregaAlmacen.FinalizarOrdenPorIdOrden(idOrden);
        }

        public void FinalizarOrdenDePreparacion(int idOrdenDeEntrega)
        {
            OrdenDeEntregaEntidad ordenDeEntrega = OrdenesDeEntregaAlmacen.ObtenerOrdenPorId(idOrdenDeEntrega);

            foreach (var orden in ordenDeEntrega.OrdenesDePreparacion)
            {
                ActualizarOrdenDePreparaciónHaciaDespachado(orden);
            }
        }

        private void ActualizarOrdenDePreparaciónHaciaDespachado(int idOrden)
        {
            OrdenDePreparacionAlmacen.ActualizarEstadoPorId(idOrden, OrdenDePreparacionEstado.Despachada);
        }

        public string ValidarDatos(string nombre, string apellido, string dni)
        {
            string errores = "";

            errores += Validadores.EsNombre(nombre, "Nombre") + Environment.NewLine;
            errores += Validadores.EsNombre(apellido, "Apellido") + Environment.NewLine;
            errores += Validadores.EsDni(dni, "DNI");

            return errores;
        }
    }
}
