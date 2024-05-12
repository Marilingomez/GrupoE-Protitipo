namespace GrupoE_Protitipos.Entidades.Deposito
{
    public class Deposito
    {
        public Deposito(int id, string ubicacion)
        {
            Id = id;
            Ubicacion = ubicacion.Trim();
        }

        public int Id { get; set; }
        public string Ubicacion { get; set; }
        public int Capacidad { get; set; }
    }
}

