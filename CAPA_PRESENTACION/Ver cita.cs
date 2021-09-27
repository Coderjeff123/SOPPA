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
    public partial class Ver_cita : Form
    {
        public Ver_cita()
        {
            InitializeComponent();
        }

        CitaN datos = new CitaN();

        private void Ver_cita_Load(object sender, EventArgs e)
        {
            dtacita.DataSource = datos.showct();
            btnposponer.Enabled = false;
        }

        private void dtacita_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnposponer.Enabled = true;
        }

        private void dtacita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
