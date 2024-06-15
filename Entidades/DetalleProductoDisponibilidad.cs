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
        public int Seleccionado { get; set; }

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

        public void DisminuyeReservado(int cantidad)
        {
            Reservado -= cantidad;
        }

        public void AumentaSeleccionado(int cantidad)
        {
            Seleccionado += cantidad;
        }

        public void DisminuyeSeleccionado(int cantidad)
        {
            Seleccionado -= cantidad;
        }

        public DetalleProductoDisponibilidad Clonar()
        {
            return new DetalleProductoDisponibilidad
            {
                Disponible = Disponible,
                Prereservado = Prereservado,
                Reservado = Reservado
            };
        }
    }
}
