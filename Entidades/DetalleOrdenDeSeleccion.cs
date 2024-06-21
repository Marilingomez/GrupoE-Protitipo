using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Entidades
{
    public class DetalleOrdenDeSeleccion
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public string Pasillo { get; set; }
        public string Fila { get; set; }
        public int Estante { get; set; }

        public DetalleOrdenDeSeleccion(int idProducto, int cantidad, string pasillo, string fila, int estante)
        {
            IdProducto = idProducto;
            Cantidad = cantidad;
            Pasillo = pasillo;
            Fila = fila;
            Estante = estante;
        }
    }
}
