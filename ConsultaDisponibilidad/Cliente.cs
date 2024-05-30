using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConsultaDisponibilidad
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<DetalleCapacidadContratada> Lista { get; set; }
        public Cliente(int id, string name, List<DetalleCapacidadContratada> lista)
        {
            Id = id;
            Name = name;
            Lista = lista;
        }
    }
}
