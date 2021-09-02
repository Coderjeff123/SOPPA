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
    public partial class Agendarcitahijo : Form
    {
        public Agendarcitahijo()
        {
            InitializeComponent();
        }

        private void Agendarcitahijo_Load(object sender, EventArgs e)
        {
            for (int f = 1; f <= 96; f++)
            {
                dtacita.Rows.Add();
            }
           // Cargarfecha();
        }

       /* private void Cargarfecha()
        {
            DateTime select = dttcalender.MaxDate;
          //  Fecha.Text = "Fecha selecionada" + select.ToString("dd/MM/yy");
            string fecha = select.Year.ToString() + select.Month.ToString() + select.Day.ToString();
            if (!File.Exists(fecha))
            {
                StreamWriter archivo = new StreamWriter(fecha);
                DateTime fe = DateTime.Today;
                for (int f = 1; f <= 96; f++)
                {
                    archivo.WriteLine(fe.ToString("HH:mm"));
                    archivo.WriteLine("");
                    fe = fe.AddMinutes(15);
                }
                archivo.Close();
            }
            StreamReader archivo2 = new StreamReader(fecha);
            int x = 0;
            while (!archivo2.EndOfStream)
            {
                string linea1 = archivo2.ReadLine();
                string linea2 = archivo2.ReadLine();
                dttcalender.Rows[x].Cells[0].Value = linea1;
                x++;
            }
        }*/











    }
}
