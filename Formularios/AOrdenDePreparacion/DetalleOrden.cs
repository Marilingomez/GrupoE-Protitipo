namespace GrupoE_Protitipos.OrdenDePreparacion
{
    public class DetalleOrden
    {
        public string IdProducto { get; internal set; }
        public int Cantidad { get; internal set; }
        public string Deposito { get; internal set; }
        public int Columna { get; internal set; }
        public int Fila { get; internal set; }

        public string validar()
        {
            List<string> mensajesError = new List<string>();

            if (string.IsNullOrWhiteSpace(IdProducto))
            {
                mensajesError.Add("El ID del producto no puede estar vacío.");
            }

            if (Cantidad <= 0)
            {
                mensajesError.Add("La cantidad debe ser mayor que cero.");
            }

            if (string.IsNullOrWhiteSpace(Deposito))
            {
                mensajesError.Add("El depósito no puede estar vacío.");
            }

            if (Columna <= 0)
            {
                mensajesError.Add("La columna debe ser un número positivo.");
            }

            if (Fila <= 0)
            {
                mensajesError.Add("La fila debe ser un número positivo.");
            }

            return string.Join(Environment.NewLine, mensajesError);
        }
    }
}