using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrupoE_Protitipos.Entidades;
using GrupoE_Protitipos.OrdenDeEntrega;
using GrupoE_Protitipos.OrdenDePreparacion;

namespace GrupoE_Protitipos
{
    public partial class FormOrdenDePreparacion : Form
    {
        OrdenDePreparacionModelo modelo = new();

        public FormOrdenDePreparacion()
        {
            InitializeComponent();
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            // Obtener la fecha actual y asignarla al TextBox FechaBox
            FechaBox.Text = DateTime.Today.ToString("dd/MM/yyyy");
            // Inicializar el ID de la orden utilizando el método del modelo
            IdOrdenBox.Text = modelo.ObtenerNuevoId().ToString();

            List<string> depositos = modelo.ObtenerListaDeDepositos();
            foreach (var deposito in depositos)
            {
                DepositoBox.Items.Add(deposito);
            }

            List<string> clientes = modelo.ObtenerListaDeCliente();
            foreach (var cliente in clientes)
            {
                ClienteBox.Items.Add(cliente);
            }

            List<string> productos = modelo.ObtenerListaDeProductos();
            foreach (var producto in productos)
            {
                productoBox.Items.Add(producto);
            }
        }

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            string erroresDeCampos = modelo.ValidarCampos(ClienteBox.Text, DepositoBox.Text);
            if(erroresDeCampos.Trim() != "")
            {
                MessageBox.Show(erroresDeCampos, "Error");
                return;
            }

            string errores = modelo.ValidarDatosProducto(CantidadBox.Text, productoBox.Text);
            if (errores.Trim() != "")
            {
                MessageBox.Show(errores, "Error");
                return;
            }

            string detalleError = modelo.ValidarExistenciaDeProducto(
                ClienteBox.Text,
                productoBox.Text,
                int.Parse(CantidadBox.Text),
                DepositoBox.Text
                );
            if (detalleError.Trim() != "")
            {
                MessageBox.Show("No hay existencias de los productos indicados para la orden solicitada. Detalle:" + Environment.NewLine +
                    detalleError
                    , "Error");
                return;
            }

            var nuevoDetalle = new ListViewItem(new string[]
            {
                modelo.ObtenerIdDelProductoPorNombre(productoBox.Text).ToString(),
                productoBox.Text,
                CantidadBox.Text.ToString()
            });

            DetallesList.Items.Add(nuevoDetalle);
            modelo.PrereservaDeProducto(
                ClienteBox.Text,
                DepositoBox.Text,
                int.Parse(CantidadBox.Text),
                productoBox.Text
                );

            MessageBox.Show("Datos agregados correctamente a la lista.");

            VerificarBloqueoDeCampos();
            LimpiarCamposAgregar();
        }

        private void SalirBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (DetallesList.SelectedItems.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indiceSeleccionado = DetallesList.SelectedIndices[0];

                // Mostrar un mensaje de confirmación
                var confirmacion = MessageBox.Show("¿Estás seguro que deseas eliminar este detalle?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    // Eliminar la fila seleccionada del ListView
                    ListViewItem item = DetallesList.SelectedItems[0];
                    DetallesList.Items.RemoveAt(indiceSeleccionado);

                    modelo.CancelarPrereservaDeProducto(
                        ClienteBox.Text, 
                        DepositoBox.Text,
                        int.Parse(item.SubItems[2].Text),
                        int.Parse(item.SubItems[0].Text)
                        );

                    MessageBox.Show("Detalle eliminado correctamente.");

                    VerificarBloqueoDeCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un detalle para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ConfirmarBoton_Click(object sender, EventArgs e)
        {
            var errores = modelo.ValidarDatosOrden(DetallesList.Items.Count, DepositoBox.Text, ClienteBox.Text);

            if (errores.Trim() != "")
            {
                MessageBox.Show(errores, "Error");
                return;
            }

            modelo.CrearNuevaOrdenDePreparacion(
                    IdOrdenBox.Text,
                    ClienteBox.Text,
                    FechaBox.Text,
                    DepositoBox.Text,
                    DetallesList.Items
                    );

            LimpiarCampos();

            MessageBox.Show("Orden confirmada y guardada correctamente.", "Confirmación");

            VerificarBloqueoDeCampos();
        }

        private void LimpiarCampos()
        {
            ClienteBox.SelectedIndex = -1;
            FechaBox.Text = DateTime.Today.ToString("dd/MM/yyyy");
            productoBox.SelectedIndex = -1;
            DepositoBox.SelectedIndex = -1;
            CantidadBox.Text = string.Empty;
            DetallesList.Items.Clear();
            IdOrdenBox.Text = modelo.ObtenerNuevoId().ToString();
        }

        private void LimpiarCamposAgregar()
        {
            // Limpiar solo los controles del formulario
            productoBox.SelectedIndex = -1;
            CantidadBox.Text = "";
        }

        private void VerificarBloqueoDeCampos()
        {
            if (DetallesList.Items.Count > 0)
            {
                DepositoBox.Enabled = false;
                ClienteBox.Enabled = false;
            } else
            {
                DepositoBox.Enabled = true;
                ClienteBox.Enabled = true;
            }
        }
    }
}
