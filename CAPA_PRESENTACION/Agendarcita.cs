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

        private void dtaagendar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Agendarcitahijo agen= Owner as Agendarcitahijo;
            agen.textnoex.Text = dtaagendar.CurrentRow.Cells[0].Value.ToString();
            agen.textId.Text = dtaagendar.CurrentRow.Cells[1].Value.ToString();
            agen.textnombre.Text = dtaagendar.CurrentRow.Cells[2].Value.ToString();
            agen.textestado.Text = dtaagendar.CurrentRow.Cells[3].Value.ToString();
        }

        private void dtaagendar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtaagendar_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Agendarcitahijo agen = Owner as Agendarcitahijo;
            agen.textnoex.Text = dtaagendar.CurrentRow.Cells[0].Value.ToString();
            agen.textId.Text = dtaagendar.CurrentRow.Cells[1].Value.ToString();
            agen.textnombre.Text = dtaagendar.CurrentRow.Cells[2].Value.ToString();
            agen.textestado.Text = dtaagendar.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
