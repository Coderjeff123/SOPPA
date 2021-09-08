﻿using System;
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

            btnagen.Visible = false;
            for (int f = 1; f <= 96; f++)
            {
                dtacita.Rows.Add();
            }
            Cargarfecha2();
        }

        private void Cargarfecha2()
        {
            DateTime select = Calendaragenda.SelectionStart;
            Fechacita.Text = "Fecha selecionada:" + select.ToString("dd/MM/yy");
            string fechacita = select.Year.ToString() + select.Month.ToString() + select.Day.ToString();
            if (!File.Exists(fechacita))
            {
                StreamWriter archivo1 = new StreamWriter(fechacita);
                DateTime fecha = DateTime.Today;
                for (int f = 1; f <= 96; f++)
                {
                    archivo1.WriteLine(fecha.ToString("HH:mm"));
                    archivo1.WriteLine("");
                    fecha = fecha.AddMinutes(15);
                }
                archivo1.Close();
            }
            StreamReader archivo3 = new StreamReader(fechacita);
            int x = 0;
            while (!archivo3.EndOfStream)
            {
                string linea1 = archivo3.ReadLine();
                string linea2 = archivo3.ReadLine();
                dtacita.Rows[x].Cells[0].Value = linea1;
                dtacita.Rows[x].Cells[1].Value = linea2;

                x++;
            }
            archivo3.Close();
        }


        private void Calendaragenda_DateChanged(object sender, DateRangeEventArgs e)
        {
            Cargarfecha2();
        }

        
















        private void buttonpersolizado1_Click(object sender, EventArgs e)
        {
            paneldegra22.Visible = false;
           
        }

        private void paneldegra21_Click(object sender, EventArgs e)
        {
            paneldegra21.Visible = true;
        }

        private void paneldegra22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtaagendar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textnombre.Texts = dtaagendar.CurrentRow.Cells["Nombre"].Value.ToString();
            paneldegra22.Visible = true;
            buttonpersolizado1.Visible = false;
            btnagen.Visible = true;
        }

        private void buttonpersolizado2_Click(object sender, EventArgs e)
        {

        }

        private void btnagen_Click(object sender, EventArgs e)
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
