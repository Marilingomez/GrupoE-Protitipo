using GrupoE_Protitipos.Almacenes;
using GrupoE_Protitipos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoE_Protitipos.ConsultaDisponibilidad
{
    internal class ConsultaDisponibilidadModelo
    {
        //public List<Deposito> Depositos = new List<Deposito>
        //{
        //    new Deposito(1, "Buenos Aires", 3000),
        //    new Deposito(2, "San Luis", 2000),
        //    new Deposito(3, "Mendoza", 3500),
        //    new Deposito(4, "Cordoba", 1500),
        //};

        public List<DepositoEntidad> Depositos = DepositoAlmacen.ObtenerDepositos();

        //public List<Cliente> Clientes = new List<Cliente>
        //{
        //    new Cliente(
        //        1,
        //        "cliente 1",
        //        new List<DetalleCapacidadContratada>() {
        //            new DetalleCapacidadContratada(1, 90),
        //            new DetalleCapacidadContratada(2, 190),
        //            new DetalleCapacidadContratada(3, 40)
        //        }
        //    ),
        //    new Cliente(
        //        2, 
        //        "cliente 2",
        //        new List<DetalleCapacidadContratada>() {
        //            new DetalleCapacidadContratada(2, 10),
        //            new DetalleCapacidadContratada(4, 40)
        //        }
        //    ),
        //    new Cliente(
        //        3, 
        //        "cliente 3",
        //        new List<DetalleCapacidadContratada>() {
        //            new DetalleCapacidadContratada(3, 110)
        //        }
        //    )
        //};

        public List<ClienteEntidad> Clientes = ClienteAlmacen.ObtenerClientes();

        public List<Inventario> Inventario = new List<Inventario>()
        {
            new Inventario(1, 1, 1, 1, 1, new List<DetalleInventario>()
            {
                new DetalleInventario(10, "Remeras"),
                new DetalleInventario(5, "Pantalones")
            }),
            new Inventario(1, 1, 1, 1, 2, new List<DetalleInventario>()
            {
                new DetalleInventario(50, "Remeras"),
                new DetalleInventario(6, "Pantalones")
            }),new Inventario(1, 1, 1, 2, 1, new List<DetalleInventario>()
            {
                new DetalleInventario(75, "Remeras"),
                new DetalleInventario(10, "Pantalones")
            })
        };
    }
}
