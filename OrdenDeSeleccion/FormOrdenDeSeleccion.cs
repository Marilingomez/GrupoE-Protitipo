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

namespace GrupoE_Protitipos
{
    public partial class FormOrdenDeSeleccion : Form
    {
        public FormOrdenDeSeleccion()
        {
            InitializeComponent();
            LoadDataFromFile(@"../../../InfoPrecargada/maestroOrdenesPreparacion.txt");
            
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }
        private void LoadDataFromFile(string filePath)
        {
            try
            {
                // Leer todas las líneas del archivo de texto
                string[] lines = File.ReadAllLines(filePath);

                // Agregar cada línea al ListBox
                foreach (string line in lines)
                {
                    listBox1.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el ListBox de detalles
            listOrden.Items.Clear();

            // Obtener el índice del elemento seleccionado en el ListBox principal
            int selectedIndex = listBox1.SelectedIndex;

            // Verificar si se seleccionó un elemento válido
            if (selectedIndex >= 0 && selectedIndex < listBox1.Items.Count)
            {
                // Obtener el detalle del elemento seleccionado
                string selectedItem = listBox1.Items[selectedIndex].ToString();
                string detail = ObtenerDetalle(selectedItem); // Método que obtiene los detalles, deberás implementarlo

                // Mostrar el detalle en el ListBox de detalles
                listOrden.Items.Add(detail);
            }
        }


        // Método para obtener los detalles del elemento seleccionado
        private string ObtenerDetalle(string selectedItem)
        {
            try
            {
                // Ruta de la carpeta de detalles
                string detallesFolder = @"../../../InfoPrecargada/DetalleOrdenesPreparacion";
                // Construir la ruta del archivo de detalle
                string detalleFilePath = Path.Combine(detallesFolder, selectedItem + ".txt"); // Suponiendo que los archivos de detalle tienen el mismo nombre que los elementos seleccionados en el primer ListBox

                // Verificar si el archivo de detalle existe
                if (File.Exists(detalleFilePath))
                {
                    // Leer todas las líneas del archivo de detalle
                    string[] lines = File.ReadAllLines(detalleFilePath);

                    // Limpiar ListBox de detalles
                    listOrden.Items.Clear();

                    // Agregar cada línea del archivo como un elemento separado en el ListBox
                    foreach (string line in lines)
                    {
                        this.listOrden.Items.Add(line);
                    }

                    // Devolver un mensaje vacío (ya que los detalles se han agregado al ListBox)
                    return "";
                }
                else
                {
                    return "No se encontraron detalles para: " + selectedItem;
                }
            }
            catch (Exception ex)
            {
                return "Error al obtener detalles: " + ex.Message;
            }
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los datos ingresados en los TextBox
            string dato1 = textBox1.Text;
            string dato2 = textBox2.Text;
            string dato3 = textBox3.Text;

            // Crear una cadena con los datos ingresados
            string datosCombinados = $"{dato1}, {dato2}, {dato3}";

            // Agregar los datos combinados a la ListBox2
            listBox2.Items.Add(datosCombinados);

            // Limpiar los TextBox para el próximo ingreso
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado en la ListBox
            if (listBox2.SelectedIndex != -1)
            {
                // Eliminar el elemento seleccionado de la ListBox
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún elemento para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardar los datos de la listBox2 en un archivo .txt
                string maestroOrdenesSeleccionadasFilePath = @"../../../InfoPrecargada/maestroOrdenesSeleccionadas.txt";
                File.WriteAllLines(maestroOrdenesSeleccionadasFilePath, listBox2.Items.Cast<string>());

                // Eliminar el elemento en maestroOrdenesPreparación que coincida con el elemento en textBox1
                string elementoAEliminar = textBox1.Text;
                string maestroOrdenesPreparacionFilePath = @"../../../InfoPrecargada/maestroOrdenesPreparacion.txt";
                string[] lineas = File.ReadAllLines(maestroOrdenesPreparacionFilePath);
                List<string> nuevasLineas = new();
                // List<string> nuevasLineas = new List<string>();
                foreach (string linea in lineas)
                {
                    if (!linea.Equals(elementoAEliminar))
                    {
                        nuevasLineas.Add(linea);
                    }
                }
                File.WriteAllLines(maestroOrdenesPreparacionFilePath, nuevasLineas);

                // Mostrar un mensaje de éxito
                MessageBox.Show("La orden de selección se ha generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al finalizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregar_Click_1(object sender, EventArgs e)
        {
            // Obtener los datos ingresados en los TextBox
            string dato1 = textBox1.Text;
            string dato2 = textBox2.Text;
            string dato3 = textBox3.Text;

            // Crear una cadena con los datos ingresados
            string datosCombinados = $"{dato1}, {dato2}, {dato3}";

            // Agregar los datos combinados a la ListBox2
            listBox2.Items.Add(datosCombinados);

            // Limpiar los TextBox para el próximo ingreso
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado en la ListBox
            if (listBox2.SelectedIndex != -1)
            {
                // Eliminar el elemento seleccionado de la ListBox
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún elemento para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonFinalizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Guardar los datos de la listBox2 en un archivo .txt
                string maestroOrdenesSeleccionadasFilePath = @"../../../InfoPrecargada/maestroOrdenesSeleccionadas.txt";
                File.WriteAllLines(maestroOrdenesSeleccionadasFilePath, listBox2.Items.Cast<string>());

                // Eliminar el elemento en maestroOrdenesPreparación que coincida con el elemento en textBox1
                string elementoAEliminar = textBox1.Text;
                string maestroOrdenesPreparacionFilePath = @"../../../InfoPrecargada/maestroOrdenesPreparacion.txt";
                string[] lineas = File.ReadAllLines(maestroOrdenesPreparacionFilePath);
                List<string> nuevasLineas = new();
                // List<string> nuevasLineas = new List<string>();
                foreach (string linea in lineas)
                {
                    if (!linea.Equals(elementoAEliminar))
                    {
                        nuevasLineas.Add(linea);
                    }
                }
                File.WriteAllLines(maestroOrdenesPreparacionFilePath, nuevasLineas);

                // Mostrar un mensaje de éxito
                MessageBox.Show("La orden de selección se ha generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al finalizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

