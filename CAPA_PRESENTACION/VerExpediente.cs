﻿using System;
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

        private void btncerrarform_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}