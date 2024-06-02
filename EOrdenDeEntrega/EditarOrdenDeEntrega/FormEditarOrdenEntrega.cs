namespace GrupoE_Protitipos.OrdenDeEntrega.EditarOrdenDeEntrega
{
    public partial class FormEditarOrdenEntrega : Form
    {

        public FormEditarOrdenEntrega()
        {
            InitializeComponent();
        }

        //public void MostrarOrdenes(List<OrdenSeleccionada> ordenes)
        //{
          //  foreach (var orden in ordenes)
            //{
              //  ListViewItem item = new ListViewItem(orden.ID);
                //item.SubItems.Add(orden.Cliente);
                //item.SubItems.Add(orden.Deposito);
                //item.SubItems.Add(orden.Fecha);
                //item.SubItems.Add(orden.Direccion);
                //item.SubItems.Add(orden.Notas);
                //EditarOrden.Items.Add(item);
            //}
        //}



        private void VolverBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditarOrden.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = EditarOrden.SelectedItems[0];


                IDtextE.Text = selectedItem.SubItems[0].Text;
                ClienteTextE.Text = selectedItem.SubItems[1].Text;
                FechaTextE.Text = selectedItem.SubItems[2].Text;
                DepositoTextE.Text = selectedItem.SubItems[3].Text;
                DireccionTextE.Text = selectedItem.SubItems[4].Text;
                NotasTextE.Text = selectedItem.SubItems[5].Text;

            }


        }

        

        private void EditarBotonE_Click(object sender, EventArgs e)
        {

            if (EditarOrden.SelectedItems.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(FechaTextE.Text))
                {
                    MessageBox.Show("Por favor ingrese la fecha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (string.IsNullOrWhiteSpace(DireccionTextE.Text))
                {
                    MessageBox.Show("Por favor ingrese la dirección de entrega.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                if (NotasTextE.Text.Length > 100)
                {
                    MessageBox.Show("Las notas no pueden exceder los 100 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ListViewItem selectedItem = EditarOrden.SelectedItems[0];


                IDtextE.Text = selectedItem.SubItems[0].Text;
                ClienteTextE.Text = selectedItem.SubItems[1].Text;
                FechaTextE.Text = selectedItem.SubItems[2].Text;
                DepositoTextE.Text = selectedItem.SubItems[3].Text;
                DireccionTextE.Text = selectedItem.SubItems[4].Text;
                NotasTextE.Text = selectedItem.SubItems[5].Text;



                selectedItem.SubItems[0].Text = IDtextE.Text;
                selectedItem.SubItems[1].Text = ClienteTextE.Text;
                selectedItem.SubItems[1].Text = FechaTextE.Text;
                selectedItem.SubItems[1].Text = DepositoTextE.Text;
                selectedItem.SubItems[1].Text = DireccionTextE.Text;
                selectedItem.SubItems[1].Text = NotasTextE.Text;

                MessageBox.Show("La orden se ha guardado correctamente");

            }
            else
            {
                MessageBox.Show("Por favor, selecciona una orden para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarBotonE_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = EditarOrden.SelectedItems[0];
            EditarOrden.Items.Remove(selectedItem);


            IDtextE.Clear();
            ClienteTextE.Clear();
            FechaTextE.Clear();
            DepositoTextE.Clear();
            DireccionTextE.Clear();
            NotasTextE.Clear();

        }
    }
}
    
