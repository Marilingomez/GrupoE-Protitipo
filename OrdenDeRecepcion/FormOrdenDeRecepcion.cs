using GrupoE_Protitipos.Recepcion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoE_Protitipos
{
    public partial class FormOrdenDeRecepcion : Form
    {
        public FormOrdenDeRecepcion()
        {
            InitializeComponent();
        }

        private void VolverOrdenRecepBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CrearOrdenRecepBtn_Click(object sender, EventArgs e)
        {
            Form CrearOrdenDeRecepcion = new FormCrearOrdenDeRecepcion();
            CrearOrdenDeRecepcion.Show();
        }


        public void ConfirmarOrdenRecepBtn_Click(object sender, EventArgs e)
        {
            Form ConfirmarOrdenDeRecepcion = new FormConfirmarOrdenDeRecepcion();
            ConfirmarOrdenDeRecepcion.Show();
        }
    }
}
