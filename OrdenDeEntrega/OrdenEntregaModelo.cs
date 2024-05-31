using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.OrdenDeEntrega
{
    public class OrdenEntregaModelo
    {
        public List<OrdenDeEntrega> OrdenesDeEntrega = new List<OrdenDeEntrega>() { 
            new OrdenDeEntrega("1", "2333333", "2025/07/23", "1")
        };

        public void GuardarOrdenEntrega(OrdenDeEntrega orden) 
        {
            OrdenesDeEntrega.Add(orden);
        }
    }
    
}