namespace GrupoE_Protitipos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnEstadoOrdenes_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultarOrdenes();
            formulario.Show();
        }
    }
}
