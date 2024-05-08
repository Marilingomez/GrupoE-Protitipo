using System;

namespace GrupoE_Protitipos.Entidades
{
    internal class Deposito
    {
        public Deposito(int id, string ubicacion)
        {
            Id = id;
            Ubicacion = ubicacion.Trim();
        }

        public int Id { get; set; }
        public string Ubicacion { get; set; }
    }
}

