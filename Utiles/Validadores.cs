using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Utiles
{
    public static class Validadores
    {
        public static string EsNumero(string numero, string campo)
        {
            if (int.TryParse(numero, out int val))
            {
                return "";
            } else
            {
                return "El dato ingresado en el campo " + campo + " no es de tipo numerico.";
            }
        }

        public static string EstaVacio(string dato, string campo)
        {
            if (dato == "")
            {
                return "El campo " + campo + " no puede estar vacio.";
            } else
            {
                return "";
            }
        }
    }
}
