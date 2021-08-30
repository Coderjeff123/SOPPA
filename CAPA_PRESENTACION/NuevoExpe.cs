using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;

namespace CAPA_PRESENTACION
{
    public partial class NuevoExpe : Form
    {
        public NuevoExpe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnremitir_Click(object sender, EventArgs e)
        {
            string estado = "";



            Nexpediente nexpediente = new Nexpediente();
            System.IO.MemoryStream memory = new System.IO.MemoryStream();
            pictureBox1.Image.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg);
            
            if (rbtnactivo.Checked == true)
            {
                estado = "A";
            }
            else
            {  
                estado = "I";
            }


            nexpediente.insertexpediente(txtnombre.Text, estado, memory.GetBuffer(), "001");

           

            RemisionN remisionN = new RemisionN();
            remisionN.insertremision(01, cmbxremitente.Text, txtmotivo.Text,dtmfecharemi.Value);

            limpiar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult resul = open.ShowDialog();
            if (resul == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        private void limpiar()
        {
            rbtnactivo.Checked = true;
            txtmotivo.Text = "";
            txtnombre.Text = "";
            dtmfecharemi.Value = DateTime.Now;
            cmbxremitente.Text = "";
            pictureBox1.Image = Properties.Resources.avatardefault_92824;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtnombre_Validated(object sender, EventArgs e)
        {
            if (txtnombre.Text.Trim() == "")
            {
                epError.SetError(txtnombre, "Intruzca un valor");
                txtnombre.Focus();
                btnremitir.Enabled = false;
            }
            else
            {
                epError.Clear();
                btnremitir.Enabled = true;
            }
        }

        private void txtmotivo_Validated(object sender, EventArgs e)
        {
            if (txtmotivo.Text.Trim() == "")
            {
                epError.SetError(txtmotivo, "Intruzca un valor");
                txtmotivo.Focus();
                btnremitir.Enabled = false;
            }
            else
            {
                epError.Clear();
                btnremitir.Enabled = true;
            }
        }

        private void pictureBox1_Validated(object sender, EventArgs e)
        {
            if (pictureBox1.Image==Properties.Resources.avatardefault_92824)
            {
                epError.SetError(pictureBox1,"Seleccione una imagen");
                pictureBox1.Focus();
                btnremitir.Enabled = false;
            }
            else
            {
                epError.Clear();
                btnremitir.Enabled = true;
            }
        }
    }
}
