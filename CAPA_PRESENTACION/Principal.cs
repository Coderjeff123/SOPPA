using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using CAPA_NEGOCIO;


namespace CAPA_PRESENTACION
{
    public partial class Principal : Form
    {
        NLogin permisos = new NLogin();
        public Principal()
        {
            InitializeComponent();
            ocultarmenu();
            if (permisos.anymetoth() == "Coordinador")
            {
                btncon.Visible = false;
                btncita.Visible = false;
                btnexpe.Visible = false;
            }

        }

       

      
       
     
        private void btncloseform_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            this.StartPosition = FormStartPosition.CenterScreen;

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

        private void btnverconsulta_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            abrirForm(new VerConsulta());
        }

        private void btncon_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenuconsulta);

        }

        private void btncita_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenucita);
        }

        private void btnexpe_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenuexpe);
        }

        private void btncon_MouseHover(object sender, EventArgs e)
        {
            btncon.BackColor = Color.Aqua;
        }

        private void btncon_MouseLeave(object sender, EventArgs e)
        {
            btncon.BackColor = Color.Transparent;
        }


        private void btncita_MouseHover(object sender, EventArgs e)
        {
            btncita.BackColor = Color.Aqua;
        }

        private void btncita_MouseLeave(object sender, EventArgs e)
        {
            btncita.BackColor = Color.Transparent;
        }

      
        private void btnexpe_MouseHover(object sender, EventArgs e)
        {
            btnexpe.BackColor = Color.Aqua;
        }

        private void btnexpe_MouseLeave(object sender, EventArgs e)
        {
            btnexpe.BackColor = Color.Transparent;
        }

        private void btninforme_MouseHover(object sender, EventArgs e)
        {
            btninforme.BackColor = Color.Aqua;
        }

        private void btninforme_MouseLeave(object sender, EventArgs e)
        {
            btninforme.BackColor = Color.Transparent;
        }

        private void btnverconsulta_MouseHover(object sender, EventArgs e)
        {
            btnverconsulta.BackColor = Color.Aquamarine;
        }

        private void btnverconsulta_MouseLeave(object sender, EventArgs e)
        {
            btnverconsulta.BackColor = Color.Transparent;
        }

        private void btniniciarconsulta_MouseHover(object sender, EventArgs e)
        {
            btniniciarconsulta.BackColor = Color.Aquamarine;
        }

        private void btniniciarconsulta_MouseLeave(object sender, EventArgs e)
        {
            btniniciarconsulta.BackColor = Color.Transparent;
        }

        private void btnvercitas_MouseHover(object sender, EventArgs e)
        {
            btnvercitas.BackColor = Color.Aquamarine;
        }

        private void btnvercitas_MouseLeave(object sender, EventArgs e)
        {
            btnvercitas.BackColor = Color.Transparent;
        }

        private void btnagendarcitas_MouseHover(object sender, EventArgs e)
        {
            btnagendarcitas.BackColor = Color.Aquamarine;
        }

        private void btnagendarcitas_MouseLeave(object sender, EventArgs e)
        {
            btnagendarcitas.BackColor = Color.Transparent;
        }

        private void btnverexpe_MouseHover(object sender, EventArgs e)
        {
            btnverexpe.BackColor = Color.Aquamarine;
        }

        private void btnverexpe_MouseLeave(object sender, EventArgs e)
        {
            btnverexpe.BackColor = Color.Transparent;
        }

        private void btnnuevoexpe_MouseHover(object sender, EventArgs e)
        {
            btnnuevoexpe.BackColor = Color.Aquamarine;
        }

        private void btnnuevoexpe_MouseLeave(object sender, EventArgs e)
        {
            btnnuevoexpe.BackColor = Color.Transparent;
        }

        private void btnverinformes_MouseHover(object sender, EventArgs e)
        {
            btnverinformes.BackColor = Color.Aquamarine;
        }

        private void btnverinformes_MouseLeave(object sender, EventArgs e)
        {
            btnverinformes.BackColor = Color.Transparent;
        }

        private void btngenerarinfo_MouseHover(object sender, EventArgs e)
        {
            btngenerarinfo.BackColor = Color.Aquamarine;
        }

        private void btngenerarinfo_MouseLeave(object sender, EventArgs e)
        {
            btngenerarinfo.BackColor = Color.Transparent;
        }

        private void btniniciarconsulta_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            abrirForm(new IniciarConsulta());
        }

  

        private void paneldegradado2_MouseDown_1(object sender, MouseEventArgs e)
        {
        }

        private void btnagendarcitas_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            abrirForm(new Agendarcita());
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            for(int f = 1; f <= 96; f++)
            {
                dtaactividad.Rows.Add();                
            }
            Cargarfecha();
        }

        private void Cargarfecha()
        {
            DateTime select = monthCalendar1.SelectionStart;
            Fecha.Text = "Fecha selecionada" + select.ToString("dd/MM/yy");
            string fecha = select.Year.ToString() + select.Month.ToString() + select.Day.ToString();
            if (!File.Exists(fecha))
            {
                StreamWriter archivo = new StreamWriter(fecha);
                DateTime fe = DateTime.Today;
                for(int f = 1; f <= 96; f++)
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
                dtaactividad.Rows[x].Cells[0].Value = linea1;
                x++;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Cargarfecha();
        }

        private void dtaactividad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnvercitas_Click(object sender, EventArgs e)
        {
            abrirForm(new Ver_cita());
        }

        private void Congf_Click(object sender, EventArgs e)
        {
            
            if (opc.Visible == false)
            {
                opc.Visible = true;
            }
            else
            {
                opc.Visible = false;
            }
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Formcierre formcierre = new Formcierre();
            formcierre.ShowDialog();
            Login login = new Login();
            login.Show();
        }

        private void btncambiarcon_Click(object sender, EventArgs e)
        {
            Cambiar_contraseña cambiar = new Cambiar_contraseña();
            cambiar.Show();
        }
    }
} 
    

