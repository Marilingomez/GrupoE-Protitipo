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

        public static void GenerarReservaDeProducto(string cuitCliente, int idProducto, int idDeposito, int cantidad)
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
                    inventarios[index].GeneraReserva(idProducto, contador);
                    inventarios[index].CancelaPrereserva(idProducto, contador);
                    break;
                }
                else
                {
                    int disponibilidad = inventarios[index].Productos[productoIndex].Disponibilidad.Prereservado;
                    inventarios[index].GeneraReserva(idProducto, disponibilidad);
                    inventarios[index].CancelaPrereserva(idProducto, disponibilidad);
                    contador -= disponibilidad;
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

        public static List<InventarioEntidad> ObtenerInventariosAcumulados(int idProducto, int cantidad)
        {
            List<InventarioEntidad> nuevaLista = new();
            foreach (var item in inventarios)
            {
                nuevaLista.Add(item.Clonar());
            }

            // Filtrar y ordenar
            var filtradoYOrdenado = nuevaLista
                .Select(i => new InventarioEntidad
                {
                    Deposito = i.Deposito,
                    Pasillo = i.Pasillo,
                    Fila = i.Fila,
                    Estante = i.Estante,
                    CuitCliente = i.CuitCliente,
                    Productos = i.Productos.Where(p => p.IdProducto == idProducto).ToList()
                })
                .Where(i => i.Productos.Count > 0)
                .OrderBy(i => i.Pasillo)
                .ThenBy(i => i.Fila)
                .ThenBy(i => i.Estante)
                .ToList();

            // Acumular la cantidad de Reservado
            List<InventarioEntidad> resultado = new List<InventarioEntidad>();
            int acumulado = 0;

            foreach (var inv in filtradoYOrdenado)
            {
                int reservadoTotal = inv.Productos.Sum(p => p.Disponibilidad.Reservado);
                acumulado += reservadoTotal;

                if (acumulado > cantidad)
                {
                    // Ajustar el último objeto para que la sumatoria de Reservado sea igual a Cantidad
                    int diferencia = acumulado - cantidad;
                    inv.Productos.First(p => p.IdProducto == idProducto).Disponibilidad.Reservado -= diferencia;
                    resultado.Add(inv);
                    break;
                }
                else
                {
                    resultado.Add(inv);
                }
            }

            return resultado;
        }

        public static void GenerarSeleccionDeProducto(int idDeposito, string pasillo, string fila, int estante, int idProducto, int cantidad)
        {
            int index = inventarios.FindIndex(i => i.Deposito == idDeposito && i.Pasillo == pasillo && i.Fila == fila && i.Estante == estante);

            inventarios[index].GeneraSeleccionado(idProducto, cantidad);
            inventarios[index].CancelaReserva(idProducto, cantidad);
        }

        public static void BajaDeProducto(int idDeposito, string pasillo, string fila, int estante, int idProducto, int cantidad)
        {
            int index = inventarios.FindIndex(i => i.Deposito == idDeposito && i.Pasillo == pasillo && i.Fila == fila && i.Estante == estante);

            inventarios[index].BajaProducto(idProducto, cantidad);
            EliminarProductosVacios();
        }

        private static void EliminarProductosVacios()
        {
            foreach (var inventario in inventarios)
            {
                inventario.Productos.RemoveAll(p =>
                    p.Disponibilidad.Disponible == 0 &&
                    p.Disponibilidad.Prereservado == 0 &&
                    p.Disponibilidad.Reservado == 0 &&
                    p.Disponibilidad.Seleccionado == 0);
            }
        }
    }
}
