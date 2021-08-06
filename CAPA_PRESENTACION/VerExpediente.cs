using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class VerExpediente : Form
    {
        public VerExpediente()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            panelinfo.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panelinfo.Visible = false;
        }
    }
}
