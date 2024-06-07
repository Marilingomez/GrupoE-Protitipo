using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Entidades
{
    public class ClienteEntidad
    {
        public int IdCliente {  get; set; }
        public string CuitCliente { get; set; }
        public string NombreFantasia { get; set; }
        public Prioridad Prioridad { get; set; }
    }
}
