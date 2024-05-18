using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConsultaDisponibilidad
{
    internal class ConsultaDisponibilidadModelo
    {
        public List<Deposito> Depositos = new List<Deposito>
    {
        new Deposito(1, "Buenos Aires", 3000),
        new Deposito(1, "San Luis", 2000),
        new Deposito(1, "Mendoza", 3500),
        new Deposito(1, "Cordoba", 1500),
    };
    }
}
