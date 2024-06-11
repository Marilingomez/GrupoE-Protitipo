using GrupoE_Protitipos.Entidades;
using GrupoE_Protitipos.Utiles;

namespace GrupoE_Protitipos.ConsultaDisponibilidad
{
    public partial class FormConsultaDisponibilidad : Form
    {
        ConsultaDisponibilidadModelo modelo;
        public FormConsultaDisponibilidad()
        {
            InitializeComponent();
        }

        private void ConsultaDisponibilidad_Load(object sender, EventArgs e)
        {
            modelo = new ConsultaDisponibilidadModelo();

            // Carga desplegable deposito
            modelo.Depositos.ForEach(de => { desplegableDepositos.Items.Add(de.Provincia); });
            // desplegableDepositos.SelectedIndex = 1;

            // Carga desplegable cliente
            modelo.Clientes.ForEach(cl => { desplegableClientes.Items.Add(cl.NombreFantasia); });
            // desplegableClientes.SelectedIndex = 1;
        }

        private void ConsultaDisponibilidad_Closed(object sender, EventArgs e)
        {

        }

        private void ConsultarEspacio_Click(object sender, EventArgs e)
        {
            // Obtiene deposito
            string depositoSeleccionado = desplegableDepositos.Text;
            DepositoEntidad deposito = modelo.Depositos.Find(it => it.Provincia == depositoSeleccionado);

            // Obtiene cliente
            string clienteSeleccionado = desplegableClientes.Text;
            ClienteEntidad cliente = modelo.Clientes.Find(it => it.NombreFantasia == clienteSeleccionado);

            // Obtiene capacidad contratada por el cliente en el deposito
            //DetalleCapacidadContratada detalle = cliente.Lista.Find(de => de.IdDeposito == deposito.IdDeposito);

            // Obtiene inventario del cliente en el deposito
            //List<Inventario> inventarios = 
            //    modelo.Inventario.FindAll(inv => inv.IdCliente == cliente.Id && inv.IdDeposito == deposito.IdDeposito);

            // Determino capacidad contratada, usada y disponible y la disponibilizo en el formulario
            //int capacidadContratada = detalle.CantidadContratada;
            //int capacidadUsada = capacidadContratada - inventarios.Count();
            //int capacidadDisponible = capacidadContratada - capacidadUsada;

            int capacidadContratada = 50;
            int capacidadUsada = capacidadContratada - 100;
            int capacidadDisponible = capacidadContratada - capacidadUsada;

            espacioContratado.Text = capacidadContratada.ToString();
            espacioUtilizado.Text = capacidadUsada.ToString();
            espacioDisponible.Text = capacidadDisponible.ToString();

            // Completo el detalle de inventario
            //foreach (var espacio in inventarios)
            //{
            //    foreach (var producto in espacio.Productos)
            //    {
            //        ListViewItem item = new ListViewItem(espacio.obtenerUbicacion());
            //        item.SubItems.Add(producto.NombreProducto);
            //        item.SubItems.Add(producto.Cantidad.ToString());
            //        detalleStock.Items.Add(item);
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void desplegableDepositos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
