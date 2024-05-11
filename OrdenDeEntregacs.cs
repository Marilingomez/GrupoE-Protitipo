using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoE_Protitipos
{
    public partial class OrdenDeEntregacs : Form
    {
        private List<OrdenSeleccionada> ordenes = new List<OrdenSeleccionada>();
        OrdenEntregaModelo modelo = new();
        List<OrdenSeleccionada> ordenesSeleccionadas = new();
        List<ListViewItem> itemsSeleccionados = new List<ListViewItem>();
        public OrdenDeEntregacs()
        {
            InitializeComponent();
        }

        private void OrdenDeEntregacs_Load(object sender, EventArgs e)
        {
            ordenesSeleccionadas.Add(new OrdenSeleccionada("100001", "230000001"));
            ordenesSeleccionadas.Add(new OrdenSeleccionada("100002", "270000002"));
            ordenesSeleccionadas.Add(new OrdenSeleccionada("100003", "300000008"));
            ordenesSeleccionadas.Add(new OrdenSeleccionada("100004", "201111114"));
            ordenesSeleccionadas.Add(new OrdenSeleccionada("100005", "309999994"));

            foreach (var ordenseleccionada in ordenesSeleccionadas)
            {
                var fila = new ListViewItem();

                fila.Text = ordenseleccionada.ID;
                fila.SubItems.Add(ordenseleccionada.Cliente);
                OrdenSeleccionadaList.Items.Add(fila);
            }
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in OrdenEntrega.SelectedItems)
            {
                OrdenEntrega.Items.Remove(item);
                OrdenSeleccionadaList.Items.Add((ListViewItem)item.Clone());
            }

            IDtext.Clear();
            ClienteText.Clear();
            
        }

        private void VolverBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void SeleccionarBoton_Click(object sender, EventArgs e)
        {


            if (OrdenSeleccionadaList.SelectedItems.Count > 0)
            {

                foreach (ListViewItem item in OrdenSeleccionadaList.SelectedItems)
                {
                    OrdenEntrega.Items.Add((ListViewItem)item.Clone());


                    itemsSeleccionados.Add(item);
                }


                foreach (ListViewItem item in itemsSeleccionados)
                {
                    OrdenSeleccionadaList.Items.Remove(item);
                }


                itemsSeleccionados.Clear();
            }
        }

     

        private void OrdenEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdenEntrega.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = OrdenEntrega.SelectedItems[0];

                string id = selectedItem.SubItems[0].Text;
                string cliente = selectedItem.SubItems[1].Text;

                IDtext.Text = id;
                ClienteText.Text = cliente;

            }
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            Form formEditarOrdenDeEntrega = new EditarOrdenEntrega();
            formEditarOrdenDeEntrega.Show();
        }


        private void GenerarBoton_Click(object sender, EventArgs e)
        {
            if (OrdenEntrega.Items.Count > 0)
            {
                
                if (string.IsNullOrWhiteSpace(FechaText.Text))
                {
                    MessageBox.Show("Por favor ingrese la fecha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                if (!DateTime.TryParseExact(FechaText.Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out _))
                {
                    MessageBox.Show("Por favor ingrese una fecha en formato válido (DD-MM-YYYY).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(DireccionText.Text))
                {
                    MessageBox.Show("Por favor ingrese la dirección de entrega.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                if (Notastext.Text.Length > 100)
                {
                    MessageBox.Show("Las notas no pueden exceder los 100 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string id = IDtext.Text;
                string cliente = ClienteText.Text;
                string fecha = FechaText.Text;
                string deposito = DepositoText.Text;
                string direccion = DireccionText.Text;
                string notas = Notastext.Text;

                OrdenSeleccionada nuevaOrden = new OrdenSeleccionada(id, cliente)
                {
                    Fecha = fecha,
                    Deposito = deposito,
                    Direccion = direccion,
                    Notas = notas
                };

                
                ordenes.Add(nuevaOrden);

                MessageBox.Show("La orden se ha generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                IDtext.Clear();
                ClienteText.Clear();
                FechaText.Clear();
                DepositoText.Clear();
                DireccionText.Clear();
                Notastext.Clear();

                OrdenEntrega.Items.Clear();
            }
            else
            {
                MessageBox.Show("No hay órdenes seleccionadas para generar la orden de entrega.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarBoton_Click(object sender, EventArgs e)
        {
            EditarOrdenEntrega formularioEditar = new EditarOrdenEntrega();

            
            formularioEditar.MostrarOrdenes(ordenes);
            formularioEditar.Show();


        }
    }
    }

