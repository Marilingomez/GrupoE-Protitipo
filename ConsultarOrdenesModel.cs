using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos
{
    internal class ConsultarOrdenesModel
    {  
        public List<orden> Ordenes { get; set; }

        public ConsultarOrdenesModel()
        {
            Ordenes = new List<orden>
            {
                new orden { NroOrden = 23, DNI = 17359842, Estado = "Recepción", Fecha = DateTime.Parse("4/05/2024") },
                new orden { NroOrden = 46, DNI = 32763267, Estado = "Preparación", Fecha = DateTime.Parse("15/04/2024") },
                new orden { NroOrden = 51, DNI = 25683564, Estado = "Selección", Fecha = DateTime.Parse("27/03/2024") },
                new orden { NroOrden = 15, DNI = 18056384, Estado = "Entrega", Fecha = DateTime.Parse("16/02/2024") },
                new orden { NroOrden = 68, DNI = 7468935, Estado = "Recepción", Fecha = DateTime.Parse("8/01/2024") },
                new orden { NroOrden = 37, DNI = 24863905, Estado = "Preparación", Fecha = DateTime.Parse("25/02/2024") },
                new orden { NroOrden = 49, DNI = 26853145, Estado = "Selección", Fecha = DateTime.Parse("23/03/2024") },

            };
        }

    }
}
