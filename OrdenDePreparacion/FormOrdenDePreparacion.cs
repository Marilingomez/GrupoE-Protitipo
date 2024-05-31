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

        private void Confirmar_Click(object sender, EventArgs e)
        {
            //eliminar
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            //eliminar
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            // Obtener la fecha actual y asignarla al TextBox FechaBox
            FechaBox.Text = DateTime.Today.ToString("dd/MM/yyyy");
            // Inicializar el ID de la orden utilizando el método del modelo
            IdOrdenBox.Text = modelo.ObtenerSiguienteIdOrden().ToString();
        }

        private void OrdenesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lista
        }

       

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            var errores = new List<string>();
            if (!int.TryParse(this.FilaBox.Text, out var fila))
            {
                errores.Add("La fila debe ser numérica");
                MessageBox.Show("La fila debe ser numérica");
                return;
            }

            if (!int.TryParse(this.ColumnaBox.Text, out var columna))
            {
                errores.Add("La columna debe ser numérica");
                MessageBox.Show("La columna debe ser numérica");
                return;
            }

            if (!int.TryParse(this.CantidadBox.Text, out var cantidad))
            {
                errores.Add("La cantidad debe ser numérica");
                MessageBox.Show("La cantidad debe ser numérica");
                return;
            }

            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores));
                return;
            }


            // Crear una nueva instancia de OrdenDePreparacion
            var ordendepreparacion = new Ordendepreparacion
            {
                IdCliente = IdClienteBox.Text,
                FechaAlta = DateTime.Today,
                idproducto = IdProductoBox.Text,
                cantidad = cantidad,
                deposito = DepositoBox.Text,
                columna = columna,
                fila = fila
            };

            string error = modelo.Validar(ordendepreparacion);
            if (error == null)
            {
                MessageBox.Show("Todo Ok!");
            }
            else
            {
                MessageBox.Show(error);
            }

            // Crear un nuevo objeto para representar los datos ingresados
            var nuevoDetalle = new ListViewItem(new string[]
            {
                this.IdProductoBox.Text,
                cantidad.ToString(),
                this.DepositoBox.Text,
                 columna.ToString(),
                fila.ToString(),
                ordendepreparacion.FechaAlta.ToString("dd/MM/yyyy")
            });

            // Agregar el nuevo detalle a la lista visual
            DetallesList.Items.Add(nuevoDetalle);

            MessageBox.Show("Datos agregados correctamente a la lista.");

            // Limpiar los campos del formulario después de agregar el detalle
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
                    DetallesList.Items.RemoveAt(indiceSeleccionado);

                    MessageBox.Show("Detalle eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un detalle para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ConfirmarBoton_Click(object sender, EventArgs e)
        {
            // Verificar si hay detalles en la lista para confirmar
            if (DetallesList.Items.Count == 0)
            {
                MessageBox.Show("No hay detalles para confirmar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una nueva instancia de Ordendepreparacion
            var nuevaOrden = new Ordendepreparacion
            {
                IdCliente = IdClienteBox.Text,
                FechaAlta = DateTime.Today,
                idproducto = IdProductoBox.Text,
                DetalleOrdenes = new List<DetalleOrden>()
            };

            // Recorrer los detalles en DetallesList y agregarlos a la nueva orden
            foreach (ListViewItem item in DetallesList.Items)
            {
                int cantidad = int.Parse(item.SubItems[1].Text);
                string deposito = item.SubItems[2].Text;
                int columna = int.Parse(item.SubItems[3].Text);
                int fila = int.Parse(item.SubItems[4].Text);

                var detalle = new DetalleOrden
                {
                    IdProducto = item.SubItems[0].Text,
                    Cantidad = cantidad,
                    Deposito = deposito,
                    Columna = columna,
                    Fila = fila
                };

                nuevaOrden.DetalleOrdenes.Add(detalle);
            }

            // Validar la nueva orden antes de agregarla
            string errores = nuevaOrden.validar();
            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show(errores, "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Agregar la nueva orden al modelo o al repositorio de órdenes
            modelo.AgregarOrden(nuevaOrden); 

            // Limpiar los campos o la lista después de confirmar
            LimpiarCampos(); 

            MessageBox.Show("Orden confirmada y guardada correctamente.", "Confirmación");

            // Actualizar el ID de la orden para la próxima orden utilizando el método del modelo
            IdOrdenBox.Text = modelo.ObtenerSiguienteIdOrden().ToString();



        }

        private void LimpiarCampos()
        {
            // Limpiar los controles del formulario o la lista (ejemplo)
            IdClienteBox.Text = string.Empty;
            FechaBox.Text = DateTime.Today.ToString("dd/MM/yyyy");
            IdProductoBox.Text = string.Empty;
            DepositoBox.Text = string.Empty;
            FilaBox.Text = string.Empty;
            ColumnaBox.Text = string.Empty;
            CantidadBox.Text = string.Empty;
            DetallesList.Items.Clear();
        }

        private void LimpiarCamposAgregar()
        {
            // Limpiar solo los controles del formulario
            IdProductoBox.Text = string.Empty;
            DepositoBox.Text = string.Empty;
            FilaBox.Text = string.Empty;
            ColumnaBox.Text = string.Empty;
            CantidadBox.Text = string.Empty;
        }


    }
}
