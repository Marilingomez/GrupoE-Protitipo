using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConsultaDisponibilidad
{
    internal class Inventario
    {
        public Inventario() { }

        public int IdDeposito { get; set; }
        public int IdCliente { get; set; }
        public int Pasillo { get; set; }
        public int Fila {  get; set; }
        public int Estante {  get; set; }
        public List<DetalleInventario> Productos { get; set; }

        public Inventario(int idDeposito, int idCliente, int pasillo, int fila, int estante, List<DetalleInventario> productos)
        {
            IdDeposito = idDeposito;
            IdCliente = idCliente;
            Pasillo = pasillo;
            Fila = fila;
            Estante = estante;
            Productos = productos;
        }

        public string obtenerUbicacion()
        {
            return "P" + Pasillo + "F" + Fila + "E" + Estante;
        }
    }
}
