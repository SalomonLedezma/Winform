namespace Mi_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            lblApellidoNombre.Text = txbApellido.Text + " " + txbNombre.Text;
        }
    }
}