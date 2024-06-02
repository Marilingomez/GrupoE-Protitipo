using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.DPreparacionOrden
{
    public enum OrdenDePreparacionEstado
    {
        Pendiente,
        EnSeleccion,
        Seleccionada,
        Preparada,
        PorDespachar,
        Despachada
    }
}
