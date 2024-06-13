using GrupoE_Protitipos.ConsultaDisponibilidad;
using GrupoE_Protitipos.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.Almacenes
{
    public static class InventarioAlmacen
    {
        private static List<InventarioEntidad> inventarios = new();

        static InventarioAlmacen()
        {
            if (File.Exists(@"Datos/inventarios.json"))
            {
                var contenido = File.ReadAllText(@"Datos/inventarios.json");
                inventarios = JsonConvert.DeserializeObject<List<InventarioEntidad>>(contenido);
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(inventarios);
            File.WriteAllText(@"Datos/inventarios.json", contenido);
        }

        public static List<InventarioEntidad> ObtenerInventarios() { return inventarios; }

        public static int ObtenerCantidadDeProductoPorClienteYDeposito(string cuitCliente, int idProducto, int idDeposito)
        {
            return inventarios
                .Where(i => i.CuitCliente == cuitCliente && i.Deposito == idDeposito)
                .SelectMany(i => i.Productos)
                .Where(p => p.IdProducto == idProducto)
                .Sum(p => p.Disponibilidad.Disponible);
        }

        public static void GenerarPrereservaDeProducto(string cuitCliente, int idProducto, int idDeposito, int cantidad)
        {
            int contador = cantidad;
            List<InventarioEntidad> posicionesConDisponibilidad = 
                ObtenerPosicionesConDisponibilidadDeProducto(idProducto, idDeposito, cantidad, cuitCliente);

            foreach (var posicion in posicionesConDisponibilidad)
            {
                int index = inventarios.IndexOf(posicion);
                int productoIndex = posicion.Productos.FindIndex(p => p.IdProducto == idProducto);

                if (posicion.Productos[productoIndex].Disponibilidad.Disponible > contador)
                {
                    inventarios[index].GeneraPrereserva(idProducto, contador);
                    inventarios[index].CancelaDisponible(idProducto, contador);
                    break;
                } else
                {
                    int disponibilidad = inventarios[index].Productos[productoIndex].Disponibilidad.Disponible;
                    inventarios[index].GeneraPrereserva(idProducto, disponibilidad);
                    inventarios[index].CancelaDisponible(idProducto, disponibilidad);
                    contador -= disponibilidad;
                }
            }
        }

        public static void CancelarPrereservaDeProducto(string cuitCliente, int idProducto, int idDeposito, int cantidad)
        {
            int contador = cantidad;
            List<InventarioEntidad> posicionesConPrereserva =
                ObtenerPosicionesConPrereservaDeProducto(idProducto, idDeposito, cantidad, cuitCliente);

            foreach (var posicion in posicionesConPrereserva)
            {
                int index = inventarios.IndexOf(posicion);
                int productoIndex = posicion.Productos.FindIndex(p => p.IdProducto == idProducto);

                if (posicion.Productos[productoIndex].Disponibilidad.Prereservado > contador)
                {
                    inventarios[index].CancelaPrereserva(idProducto, contador);
                    inventarios[index].GeneraDisponible(idProducto, contador);
                    break;
                }
                else
                {
                    int prereserva = inventarios[index].Productos[productoIndex].Disponibilidad.Prereservado;
                    inventarios[index].CancelaPrereserva(idProducto, prereserva);
                    inventarios[index].GeneraDisponible(idProducto, prereserva);
                    contador -= prereserva;
                }
            }
        }

        private static List<InventarioEntidad> ObtenerPosicionesConDisponibilidadDeProducto(
            int idProducto,
            int idDeposito, 
            int cantidad,
            string cuitCliente
            )
        {
            return inventarios.Where(
                i => i.Productos.Any(
                    p => p.IdProducto == idProducto && p.Disponibilidad.Disponible > 0
                    ) && i.CuitCliente == cuitCliente && i.Deposito == idDeposito
                ).ToList();
        }

        private static List<InventarioEntidad> ObtenerPosicionesConPrereservaDeProducto(
            int idProducto,
            int idDeposito,
            int cantidad,
            string cuitCliente
            )
        {
            return inventarios.Where(
                i => i.Productos.Any(
                    p => p.IdProducto == idProducto && p.Disponibilidad.Prereservado > 0
                    ) && i.CuitCliente == cuitCliente && i.Deposito == idDeposito
                ).ToList();
        }
    }
}
