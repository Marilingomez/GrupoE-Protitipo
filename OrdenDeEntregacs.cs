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

namespace GrupoE_Protitipos
{
    public partial class OrdenDeEntregacs : Form
    {
        OrdenEntregaModelo modelo=new();
        public OrdenDeEntregacs()
        {
            InitializeComponent();
        }

        private void OrdenDeEntregacs_Load(object sender, EventArgs e)
        {
            modelo = new();
            foreach(var ordenseleccionada in modelo.OrdenSeleccionadas)
            {
                var fila = new ListViewItem();
               
                fila.Text = ordenseleccionada.ID;
                fila.SubItems.Add(ordenseleccionada.Cliente);
                OrdenSeleccionadaList.Items.Add(fila);
            }
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {

        }

        private void VolverBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ConfirmarSeleccionBoton_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeleccionarBoton_Click(object sender, EventArgs e)
        {

        }

        private void IDtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrdenSeleccionadaList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
