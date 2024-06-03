using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConfirmarOrdenDeEntrega
{
    public class OrdEntrega
    {
        public int IdOrden {  get; set; }
        public int CuitTransportista { get; set; }
        public int CuitCliente { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public DateTime FechaDeEntrega { get; set; }
        public string Estado { get; set; }

        public OrdEntrega(int idOrden, int cuitTransportista, int cuitCliente, string estado)
        {
            IdOrden = idOrden;
            CuitTransportista = cuitTransportista;
            CuitCliente = cuitCliente;
            Estado = estado;
        }
    }
}
