using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.OrdenDeEntrega
{
    public class OrdenEntregaModelo
    {
        public List<OrdenDeEntrega> OrdenesPreparacion = new List<OrdenDeEntrega>();

        public void GuardarOrdenEntrega(OrdenDeEntrega orden) 
        {
            OrdenesPreparacion.Add(orden);
        }
    }
    
}