﻿using System;
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
    public partial class IniciarConsulta : Form
    {
        public IniciarConsulta()
        {
            InitializeComponent();
        }

        Nexpediente dto = new Nexpediente();

        private void button1_Click(object sender, EventArgs e)
        {
            paneldegra21.Visible = false;
            dtaexpe.DataSource = dto.buscarexpedientecita(textBox1.Text);
            dtaexpe.Visible = true;
        }
    }
}
