namespace GrupoE_Protitipos.ConsultaDisponibilidad
{
    public class Deposito
    {
        public Deposito(int id, string ubicacion, int capacidad)
        {
            Id = id;
            Ubicacion = ubicacion.Trim();
            Capacidad = capacidad;
        }

        public int Id { get; set; }
        public string Ubicacion { get; set; }
        public int Capacidad { get; set; }
    }
}

