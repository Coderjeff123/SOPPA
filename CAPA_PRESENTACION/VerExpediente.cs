using CAPA_NEGOCIO;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

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
            dtaexpe.Columns["Foto"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtaexpe.DataSource = data.buscarexpediente(textBox1.Text);
        }


        private void dtaexpe_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtaexpe.SelectedRows.Count > 0)
            {
                id.Text = dtaexpe.CurrentRow.Cells["ID_Expediente"].Value.ToString();
                txtestado.Text = dtaexpe.CurrentRow.Cells["Estado"].Value.ToString();
                byte[] imag = (byte[])dtaexpe.CurrentRow.Cells["Foto"].Value;
                MemoryStream ms = new MemoryStream(imag);
                pimagen.Image = Image.FromStream(ms);
            }

            if (txtestado.Text == "I")
            {
                btnbaja.Visible = false;
            }
            else
            {
                btnbaja.Visible = true;
            }

           
        }
        private void btnbaja_Click(object sender, EventArgs e)
        {
            if (dtaexpe.SelectedRows.Count > 0)
            {
                txtestado.Text = "I";
                Nexpediente expe = new Nexpediente();
                expe.Baja(id.Text, txtestado.Text);

            }
            mostrar();
            MessageBox.Show("Se ha dado de baja exitosamente");
        }
    }
}
