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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            ocultarmenu();
        }

        private void btncloseform_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        private void ocultarmenu()
        {
            panelsubmenucita.Visible = false;
            panelsubmenuconsulta.Visible = false;
            panelsubmenuexpe.Visible = false;
            panelsubmenuinformes.Visible = false;
        }

        private void btnresform_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnresform.Visible = false;
            btnmaxform.Visible = true;
           
        }

      

        private void btnmaxform_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaxform.Visible = false;
            btnresform.Visible = true;
        }

        private void btnminform_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ocultarsubmenu()
        {
            if (panelsubmenucita.Visible == true)
            {
                panelsubmenucita.Visible = false;
            }
            if (panelsubmenuconsulta.Visible == true)
            {
                panelsubmenuconsulta.Visible = false;
            }
            if (panelsubmenuexpe.Visible == true)
            {
                panelsubmenuexpe.Visible = false;
            }
            if (panelsubmenuinformes.Visible == true)
            {
                panelsubmenuinformes.Visible = false;
            }
        }

        private void mostrarsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnexpediente_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenuexpe);
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenuconsulta);
        }

        private void btncita_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenucita);
        }

        private void btninforme_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenuinformes);
        }
        private Form fomractive = null;
        private void abrirForm(Form formhijo)
        {
            if (fomractive != null)
            {
                fomractive.Close();
            }
            fomractive = formhijo;
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            panelFormhijo.Controls.Add(formhijo);
            panelFormhijo.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();
        }

        private void btnverexpe_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            abrirForm(new VerExpediente());
        }

        private void btnnuevoexpe_Click(object sender, EventArgs e)
        {
            ocultarmenu();
            abrirForm(new NuevoExpe());
        }
    }
    }
    
    

