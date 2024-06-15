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

        public static string ValidarListaConDatos(int items, string campo)
        {
            if (items != 0)
            {
                return "";
            } else
            {
                return "El listado " + campo + " no puede estar vacio.";
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

        public static string EsNegativoOCero(int dato, string campo)
        {
            if (dato < 1)
            {
                return "El campo " + campo + " debe ser igual a 1 o superior.";
            } else
            {
                return "";
            }
        }

        public static string EsDni(string dato, string campo)
        {
            string errores = "";

            errores += EsNumero(dato, campo);
            if (errores != "")
            {
                return errores;
            }

            errores += EsNegativoOCero(int.Parse(dato), campo);
            if (errores != "")
            {
                return errores;
            }

            if (dato.Length != 8 && dato.Length != 7)
            {
                return "El campo " + campo + " debe ser un DNI de 7 u 8 cifras.";
            }
            else
            {
                return "";
            }
        }
    }
}
