using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.OrdenDeEntrega
{
    public class OrdenSeleccionada
    {

        public List<OrdenSeleccionada> ordenes = new List<OrdenSeleccionada>();

        public string ID { get; set; }
        public string Cliente { get; set; }
        public string Fecha { get; set; }
        public string Deposito { get; set; }
        public string Direccion { get; set; }
        public string Notas { get; set; }


        public OrdenSeleccionada(string ID, string Cliente)
        {
            this.ID = ID;
            this.Cliente = Cliente;
        }
    }
}
