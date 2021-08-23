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
            Nexpediente nexpediente = new Nexpediente();
            System.IO.MemoryStream memory = new System.IO.MemoryStream();
            pictureBox1.Image.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg);
            nexpediente.insertexpediente("01", txtnombre.Text, "A",memory.GetBuffer(), "");
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

        
    }
}
