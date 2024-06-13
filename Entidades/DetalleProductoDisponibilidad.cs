using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Entidades
{
    public class DetalleProductoDisponibilidad
    {
        public int Disponible {  get; set; }
        public int Prereservado { get; set; }
        public int Reservado { get; set; }

        public void AumentaDisponible(int cantidad)
        {
            Disponible += cantidad;
        }

        public void DisminuyeDisponible(int cantidad)
        {
            Disponible -= cantidad;
        }

        public void AumentaPrereservado(int cantidad)
        {
            Prereservado += cantidad;
        }

        public void DisminuyePrereservado(int cantidad)
        {
            Prereservado -= cantidad;
        }

        public void AumentaReservado(int cantidad)
        {
            Reservado += cantidad;
        }

        public void DisminuyePreservado(int cantidad)
        {
            Reservado -= cantidad;
        }
    }
}
