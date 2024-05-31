using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConfirmarOrdenDeSeleccion
{
    public class DetalleOrdSeleccion
    {
        public int IdProducto { get; set; }
        public int Deposito { get; set; }
        public int Fila {  get; set; }
        public int Pasillo { get; set; }
        public int Cantidad { get; set; }

        public DetalleOrdSeleccion(int idProducto, int deposito, int fila, int columna, int cantidad)
        {
            IdProducto = idProducto;
            Deposito = deposito;
            Fila = fila;
            Pasillo = columna;
            Cantidad = cantidad;
        }

        public string ObtenerUbicacion()
        {
            return "P" + Pasillo + "F" + Fila;
        }
    }
}
