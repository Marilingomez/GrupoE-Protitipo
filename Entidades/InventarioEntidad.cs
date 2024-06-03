using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Entidades
{
    public class InventarioEntidad
    {
        public int IdProducto { get; set; }
        public int Deposito { get; set; }
        public string CuitCliente { get; set; }
        public string Pasillo { get; set; }
        public string Fila {  get; set; }
        public int Estante { get; set; }
        public int Cantidad { get; set; }
    }
}
