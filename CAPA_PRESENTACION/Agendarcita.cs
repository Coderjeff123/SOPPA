using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CAPA_NEGOCIO;

namespace CAPA_PRESENTACION
{
    public partial class Agendarcita : Form
    {
    
        public Agendarcita()
        {
            InitializeComponent();

        }

        Nexpediente data = new Nexpediente();





        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtaagendar.DataSource= data.buscarexpediente(textagendar.Text);
        }

        private void dtaagendar_Load(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void dtaagendar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }



    }
}
