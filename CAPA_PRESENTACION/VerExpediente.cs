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
            dtaexpe.DataSource = data.buscarexpediente(textver.Text);
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
                btnbaja.Enabled = false;
            }
            else
            {
                btnbaja.Enabled = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
                System.IO.MemoryStream memory = new System.IO.MemoryStream();
               pimagen.Image.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg);
                Nexpediente expe = new Nexpediente();
                expe.UpdateDexpediente(id.Text, memory.GetBuffer());
            MessageBox.Show("Se ha dado cambiado la imagen exitosamente exitosamente");

            mostrar();
        }

     

        private void pimagen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult result = open.ShowDialog();

            if (result == DialogResult.OK)
            {
                pimagen.Image = Image.FromFile(open.FileName);
            }

            mostrar();
        }

        private void dtaexpe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
