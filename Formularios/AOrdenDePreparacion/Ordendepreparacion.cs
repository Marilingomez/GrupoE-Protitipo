namespace GrupoE_Protitipos.OrdenDePreparacion
{
    internal class Ordendepreparacion
    {

        public string IdOrden { get; set; }
        public string IdCliente { get; internal set; }
        public DateTime FechaAlta { get; set; }
        public string idproducto { get; internal set; }
        public int cantidad { get; internal set; }
        public string deposito { get; internal set; }
        public int columna { get; internal set; }
        public int fila { get; internal set; }
        public List<DetalleOrden> DetalleOrdenes { get; internal set; }

        internal string validar()
        {
            List<string> mensajesError = new List<string>();


            if (string.IsNullOrWhiteSpace(IdCliente))
            {
                mensajesError.Add("El ID del cliente no puede estar vacío.");
            }

            //if (string.IsNullOrWhiteSpace(idproducto))
            //{
            //    mensajesError.Add("El ID del producto no puede estar vacío.");
            //}

            // Verificar si la lista de detalles está inicializada y tiene elementos
            if (DetalleOrdenes != null && DetalleOrdenes.Any())
            {
                foreach (var detalle in DetalleOrdenes)
                {
                    string errorDetalle = detalle.validar();
                    if (!string.IsNullOrEmpty(errorDetalle))
                    {
                        mensajesError.Add(errorDetalle);
                    }
                }
            }

            return mensajesError.Any() ? string.Join(Environment.NewLine, mensajesError) : null;
        }



    }
}