﻿using GrupoE_Protitipos.OrdenDeRecepcion.ConfirmarOrdenDeRecepcion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoE_Protitipos.Recepcion
{
    public partial class FormConfirmarOrdenDeRecepcion : Form
    {
        ConfirmarOrdenDeRecepcionModelo modelo;
        public FormConfirmarOrdenDeRecepcion()
        {
            InitializeComponent();
        }

        private void ProductoAingresarbtn_Click(object sender, EventArgs e)
        {

        }

        private void CrearOrdenBtn_Click(object sender, EventArgs e)
        {

        }

        private void VolverOrdenRecepBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrdenSeleccionadaList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}