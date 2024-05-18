using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.OrdenDePreparacion
{
    internal class OrdenDePreparacionModelo
    {
        public List<OrdenPreparacion> Ordenes { get; set; }


        public OrdenDePreparacionModelo()
        {

            // Constructor para inicializar la lista de detalles


            Ordenes = new List<OrdenPreparacion>
        {
           new OrdenPreparacion
            {
                ID = 10001,
                Cliente = 222,
                Detalles = new List<DetalleOrdenDePreparacion>
                {
                    new DetalleOrdenDePreparacion { Producto = "E5409", Cantidad = 10 },
                    new DetalleOrdenDePreparacion { Producto = "A2399", Cantidad = 5 }
                }
            },
            new OrdenPreparacion
            {
                ID = 10002,
                Cliente = 223,
                Detalles = new List<DetalleOrdenDePreparacion>
                {
                    new DetalleOrdenDePreparacion { Producto = "E4992", Cantidad = 8 },
                    new DetalleOrdenDePreparacion { Producto = "C9927", Cantidad = 3 }
                }
            },
             new OrdenPreparacion
            {
                ID = 10003,
                Cliente = 224,
                Detalles = new List<DetalleOrdenDePreparacion>
                {
                    new DetalleOrdenDePreparacion { Producto = "E4992", Cantidad = 50 },
                    new DetalleOrdenDePreparacion { Producto = "C9927", Cantidad = 48 }
                }
            },
              new OrdenPreparacion
            {
                ID = 10004,
                Cliente = 225,
                Detalles = new List<DetalleOrdenDePreparacion>
                {
                    new DetalleOrdenDePreparacion { Producto = "E4992", Cantidad = 29 },
                    new DetalleOrdenDePreparacion { Producto = "C9927", Cantidad = 33 }
                }
            },
               new OrdenPreparacion
            {
                ID = 10005,
                Cliente = 226,
                Detalles = new List<DetalleOrdenDePreparacion>
                {
                    new DetalleOrdenDePreparacion { Producto = "E4992", Cantidad = 10 },
                    new DetalleOrdenDePreparacion { Producto = "C9927", Cantidad = 99 }
                }
            },
        };
        }
    }
}
