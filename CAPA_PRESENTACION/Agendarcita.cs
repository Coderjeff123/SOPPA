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

        Nexpediente data1 = new Nexpediente();

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtaagendar.DataSource= data1.buscarexpediente(textagendar.Text);
            
        }

        private void dtaagendar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Agendarcita_Load(object sender, EventArgs e)
        {

        }








        /*   private void dtaagendar_CellClick(object sender, DataGridViewCellEventArgs e)
           {
               this.Hide();
               Agendarcitahijo agen = new Agendarcitahijo();
               agen.ShowDialog();
           }*/

        /* private void btnagendar_Click(object sender, EventArgs e)
         {
             Agendarcitahijo agend = Owner as Agendarcitahijo;
             //agend.textcodigo.text =  
         }*/





    }
}
