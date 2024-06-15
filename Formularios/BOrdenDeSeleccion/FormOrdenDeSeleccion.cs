using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.DataFormats;
using GrupoE_Protitipos.OrdenDeSeleccion;
using GrupoE_Protitipos.Entidades;

namespace GrupoE_Protitipos
{
    public partial class FormOrdenDeSeleccion : Form
    {
        OrdenDeSeleccionModelo modelo = new();
        public FormOrdenDeSeleccion()
        {
            InitializeComponent();
        }

        private void FormOrdenDeSeleccion_Load(object sender, EventArgs e)
        {
            List<string> depositos = modelo.ObtenerListaDeDepositos();
            foreach (var deposito in depositos)
            {
                depositoBox.Items.Add(deposito);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (ordenesPreparar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una orden.");
            } else
            {
                foreach (ListViewItem item in ordenesPreparar.SelectedItems)
                {
                    ordenesSeleccionar.Items.Add((ListViewItem)item.Clone());
                    ordenesPreparar.Items.Remove(item);
                }

                listProductos.Items.Clear();

                ActualizarDetallesProductos();

                depositoBox.Enabled = false;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (ordenesSeleccionar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una orden.");
            } else
            {
                foreach (ListViewItem item in ordenesSeleccionar.SelectedItems)
                {
                    ordenesPreparar.Items.Add((ListViewItem)item.Clone());
                    ordenesSeleccionar.Items.Remove(item);
                }

                listProductos.Items.Clear();

                ActualizarDetallesProductos();

                if (ordenesSeleccionar.Items.Count == 0) { depositoBox.Enabled = true; }
            }
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (listProductos.Items.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una orden.", "Error");
                return;
            }

            if (depositoBox.Enabled) {
                MessageBox.Show("Debe seleccionar al menos una orden.", "Error");
                return;
            }

            System.Windows.Forms.ListView.ListViewItemCollection ordenes = ordenesSeleccionar.Items;
            List<int> idDeOrdenesPorActualizar = new();
            foreach (ListViewItem item in ordenes)
            {
                idDeOrdenesPorActualizar.Add(int.Parse(item.SubItems[0].Text));
            }
            string nombreDeposito = depositoBox.Text;
            var productos = listProductos.Items;

            modelo.ActualizarEstadoDeOrdenes(idDeOrdenesPorActualizar);
            OrdenDeSeleccionEntidad orden = modelo.CrearOrdenDeSeleccion(idDeOrdenesPorActualizar, nombreDeposito, productos);
            modelo.ActualizarEstadoProductos(orden);

            MessageBox.Show("La orden de selección se ha generado correctamente.");

            ordenesSeleccionar.Items.Clear();
            ordenesPreparar.Items.Clear();
            depositoBox.Enabled = true;
            CargaDatos();
            
        }

        private void ActualizarDetallesProductos()
        {
            var lista = ordenesSeleccionar.Items;
            List<int> idOrdenes = new();

            foreach (ListViewItem item in lista)
            {
                string id = item.SubItems[0].Text;
                idOrdenes.Add(int.Parse(id));
            }

            List<DetalleOrdenDeSeleccion> detalleProductos = modelo.ObtenerProductosParaSeleccionarDeOrdenes(idOrdenes);

            foreach (var producto in detalleProductos)
            {
                string nombreProducto = modelo.ObtenerNombreProductoPorId(producto.IdProducto);

                ListViewItem item = new ListViewItem(new string[] { producto.Pasillo, producto.Fila, producto.Estante.ToString(), nombreProducto, producto.Cantidad.ToString() });
                listProductos.Items.Add(item);
            }
        }

        private void CargaDatos()
        {
            ordenesPreparar.Items.Clear();
            listProductos.Items.Clear();

            List<OrdenDePreparacionEntidad> ordenes = modelo.ObtenerOrdenesDePreparacionPendientesPorDeposito(depositoBox.Text);
            foreach (var orden in ordenes)
            {
                ListViewItem item = new ListViewItem(new string[] { orden.IdOrden.ToString(), orden.CuitCliente.ToString() });
                ordenesPreparar.Items.Add(item);
            }
        }

        private void depositoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaDatos();
        }
    }
}

