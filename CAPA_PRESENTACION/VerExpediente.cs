using CAPA_NEGOCIO;
using System;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class VerExpediente : Form
    {
        public VerExpediente()
        {
            InitializeComponent();
        }

        Nexpediente data = new Nexpediente();

        private void VerExpediente_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void mostrar()
        {
            dtaexpe.DataSource = data.showEX();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtaexpe.DataSource = data.buscarexpediente(textBox1.Text);
        }
    }
}
