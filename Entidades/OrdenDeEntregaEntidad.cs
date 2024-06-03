using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Entidades
{
    public class OrdenDeEntregaEntidad
    {
        public int IdOrden { get; set; }
        public string CuitTransportista { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public DateTime FechaDeEntrega { get; set; }
        public int Deposito {  get; set; }
        public List<int> OrdenesDePreparacion { get; set; }
        public Estado Estado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni {  get; set; }

        public OrdenDeEntregaEntidad(int idOrden, string cuitTransportista, DateTime fechaDeCreacion, int deposito, List<int> ordenesDePreparacion)
        {
            IdOrden = idOrden;
            CuitTransportista = cuitTransportista;
            FechaDeCreacion = fechaDeCreacion;
            Deposito = deposito;
            OrdenesDePreparacion = ordenesDePreparacion;
            Estado = Estado.EnTransito;
        }
    }
}
