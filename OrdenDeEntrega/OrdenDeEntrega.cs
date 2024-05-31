using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.OrdenDeEntrega
{
    public class OrdenDeEntrega
    {
        //lista nueva
        public List<OrdenPreparacion> ordenes = new List<OrdenPreparacion>();

        public string ID { get; set; }
        public string TransportistaCUIT { get; set; }
        public string Fecha { get; set; }
        public string Deposito { get; set; }
        


        public OrdenDeEntrega(string ID, string TransportistaCUIT, string Fecha, string Deposito)
        {
            this.ID = ID;
            this.TransportistaCUIT = TransportistaCUIT;
            this.Fecha = Fecha;
            this.Deposito = Deposito;
            


        }
    }
}
