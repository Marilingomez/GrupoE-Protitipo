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
            CargaDatosIniciales();
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
            }

            // Actualizar detalles de productos
            ActualizarDetallesProductos();
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
            }

            // Actualizar detalles de productos
            ActualizarDetallesProductos();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (listProductos.Items.Count != 0)
            {
                MessageBox.Show("Debe seleccionar al menos una orden.");
            } else
            {
                System.Windows.Forms.ListView.ListViewItemCollection ordenes = ordenesSeleccionar.Items;
                List<int> idDeOrdenesPorActualizar = new();
                foreach (ListViewItem item in ordenes)
                {
                    idDeOrdenesPorActualizar.Add(int.Parse(item.SubItems[0].Text));
                }

                modelo.ActualizarEstadoDeOrdenes(idDeOrdenesPorActualizar);
                modelo.CrearOrdenDeSeleccion(idDeOrdenesPorActualizar);

                MessageBox.Show("La orden de selección se ha generado correctamente.");

                ordenesSeleccionar.Items.Clear();
                ordenesPreparar.Items.Clear();
                CargaDatosIniciales();
            }
        }
        private void ActualizarDetallesProductos()
        {
            listProductos.Items.Clear();

            //foreach (string orden in listSeleccionada.Items)
            //{
            //    MostrarDetallesProductos(orden);
            //}
        }

        private void CargaDatosIniciales()
        {
            List<OrdenDePreparacionEntidad> ordenes = modelo.ObtenerOrdenesDePreparacionPendientes();
            foreach (var orden in ordenes)
            {
                ListViewItem item = new ListViewItem(new string[] { orden.IdOrden.ToString(), orden.CuitCliente.ToString() });
                ordenesPreparar.Items.Add(item);
            }
        }
    }
}

