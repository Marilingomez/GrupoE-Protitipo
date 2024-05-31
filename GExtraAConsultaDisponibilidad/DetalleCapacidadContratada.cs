using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConsultaDisponibilidad
{
    internal class DetalleCapacidadContratada
    {
        public int IdDeposito { get; set; }
        public int CantidadContratada { get; set; }
        public DetalleCapacidadContratada(int idDeposito, int cantidadContratada) { 
            IdDeposito = idDeposito;
            CantidadContratada = cantidadContratada;
        }
    }
}
