using GrupoE_Protitipos.ConsultarOrdenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.OrdenDePreparacion
{
    internal class OrdenDePreparacionModelo

    {
        private List<Ordendepreparacion> ordenes = new List<Ordendepreparacion>();
        private int siguienteIdOrden = 1;

        internal string Validar (Ordendepreparacion ordendepreparacion)
        {
            string error = ordendepreparacion.validar();
            if(error != null)
            {

                return error;
            }

            return null;
            
        }
        public string ObtenerSiguienteIdOrden()
        {
            return siguienteIdOrden.ToString();
        }

        public void IncrementarSiguienteIdOrden()
        {
            siguienteIdOrden++;
        }
        internal void AgregarOrden(Ordendepreparacion nuevaOrden)
        {
            nuevaOrden.IdOrden = ObtenerSiguienteIdOrden();
            ordenes.Add(nuevaOrden);
            IncrementarSiguienteIdOrden();
        }

    }
}
