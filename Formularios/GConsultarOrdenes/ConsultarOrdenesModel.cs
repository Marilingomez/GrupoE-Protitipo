using GrupoE_Protitipos.Almacenes;
using GrupoE_Protitipos.Entidades;
using GrupoE_Protitipos.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConsultarOrdenes
{
    public class ConsultarOrdenesModel
    {
        public List<OrdenDePreparacionEntidad> ObtenerOrdenesDePreparacionPorEstado(string estado)
        {
            OrdenDePreparacionEstado status = 
                (OrdenDePreparacionEstado)Enum.Parse(typeof(OrdenDePreparacionEstado), estado);
            return OrdenDePreparacionAlmacen.ObtenerOrdenesPorEstado(status);
        }

        public List<string> ObtenerClientes()
        {
            List<ClienteEntidad> clientes = ClienteAlmacen.ObtenerClientes();
            List<string> nombreClientes = new List<string>();

            foreach (var cliente in clientes)
            {
                nombreClientes.Add(cliente.NombreFantasia);
            }

            return nombreClientes;
        }

        public List<OrdenDePreparacionEntidad> ObtenerOrdenesFiltradas(string idOrden, string nombreCliente, string estado)
        {
            List<OrdenDePreparacionEntidad> ordenes = OrdenDePreparacionAlmacen.ObtenerOrdenes();

            var lista = ordenes.AsEnumerable();

            if (idOrden != "")
            {
                lista = lista.Where(o => o.IdOrden == int.Parse(idOrden));
            }

            if (nombreCliente != "Todos")
            {
                string cuitCliente = ClienteAlmacen.ObtenerCuitPorNombre(nombreCliente);
                lista = lista.Where(o => o.CuitCliente == cuitCliente);
            }

            if (estado != "Todos")
            {
                OrdenDePreparacionEstado status =
                    (OrdenDePreparacionEstado)Enum.Parse(typeof(OrdenDePreparacionEstado), estado);
                lista = lista.Where(o => o.Estado == status);
            }

            return lista.ToList();
        }

        public string ValidarDatos(string idOrden, string nombreCliente, string estado)
        {
            string errores = "";

            if(idOrden != "")
            {
                if (!int.TryParse(idOrden, out var numero))
                {
                    errores += "El id de la orden debe ser de tipo númerico." + Environment.NewLine;
                } else
                {
                    if (numero < 1)
                    {
                        errores += "El id de la orden debe ser igual a 1 o superior." + Environment.NewLine;
                    }
                }
            }

            errores += Validadores.EstaVacio(nombreCliente, "Cliente") + Environment.NewLine;
            errores += Validadores.EstaVacio(estado, "Estado");

            return errores;
        }
    }
}
