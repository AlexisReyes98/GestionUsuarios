namespace GestionUsuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            GestionClientes ventanaClientes = new GestionClientes();
            ventanaClientes.ShowDialog();
        }
    }
}