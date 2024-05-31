using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConfirmarOrdenDeEntrega
{
    public class ConfirmarOrdenDeEntregaModelo
    {
        private List<OrdEntrega> OrdenesDeEntrega = new List<OrdEntrega>() { 
            new OrdEntrega(1, 30504, 25, "En transito"),
            new OrdEntrega(2, 30505, 26, "Finalizada"),
            new OrdEntrega(3, 30506, 27, "En transito")
        };

        public void FinalizarOrdenDeEntrega(int idOrden)
        {
            int index = OrdenesDeEntrega.FindIndex(ode => ode.IdOrden == idOrden);
            OrdenesDeEntrega[index].Estado = "Finalizada";
            OrdenesDeEntrega[index].FechaDeEntrega = new DateTime();
        }

        public List<OrdEntrega> ObtenerOrdenesDeEntrega() { return OrdenesDeEntrega; }
    }
}
