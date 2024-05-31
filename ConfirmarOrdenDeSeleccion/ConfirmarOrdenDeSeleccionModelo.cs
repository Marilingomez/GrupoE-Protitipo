using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConfirmarOrdenDeSeleccion
{
    public class ConfirmarOrdenDeSeleccionModelo
    {
        public List<OrdSeleccion> OrdenesDeSeleccion = new List<OrdSeleccion>()
        {
            new OrdSeleccion(
                1,
                1, 
                "En transito",
                new DateTime(2024, 5, 23),
                new List<int>() {1, 2, 3},
                new List<DetalleOrdSeleccion>()
                {
                    new DetalleOrdSeleccion(1, 1, 1, 1, 10)
                }
            ),
            new OrdSeleccion(
                2,
                2,
                "En transito",
                new DateTime(2024, 5, 18),
                new List<int>() {4},
                new List<DetalleOrdSeleccion>()
                {
                    new DetalleOrdSeleccion(2, 1, 2, 1, 18)
                }
            ),
            new OrdSeleccion(
                3,
                3,
                "Finalizada",
                new DateTime(2024, 5, 24),
                new List<int>() {4},
                new List<DetalleOrdSeleccion>()
                {
                    new DetalleOrdSeleccion(3, 1, 2, 1, 18)
                }
            )
        };

        public void FinalizarOrdenDeSeleccion(int idOrden)
        {
            int index = OrdenesDeSeleccion.FindIndex(ods => ods.IdOrden == idOrden);
            OrdenesDeSeleccion[index].Estado = "Finalizada";
            OrdenesDeSeleccion[index].FechaDeEntrega = new DateTime();
        }

        public List<OrdSeleccion> ObtenerOrdenesEnTransito()
        {
            return OrdenesDeSeleccion.FindAll(ods => ods.Estado == "En transito");
        }
    }
}
