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
    public partial class Login : Form
    {
        string retorno= "Everithing its ok";
        public Login()
        {
            InitializeComponent();
        }

        public string nombre;

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "User")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
                nombre = txtuser.Text;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "User";
                txtuser.ForeColor = Color.Blue;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
                txtpass.ForeColor = Color.Blue;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "User")
            {
                if (txtpass.Text !="Pass") 
                {
                    NLogin nLogin = new NLogin();
                    string validation =nLogin.loginuser(txtuser.Text, txtpass.Text);

                    if (validation == retorno )
                    {
                        this.Hide();
                        Formwelcome formwelcome = new Formwelcome();
                        formwelcome.ShowDialog();
                        Principal principal = new Principal();
                        principal.Show();
                        
                    }
                    else msgError("Usuario incorrecto");
                    
                       
                    
                }
                else msgError("Please enter password");



            }
            else msgError("Please enter User");
        }
        private void msgError(string msg)
        {
            lblerror.Text="  " + msg;
            lblerror.Visible = true;
        }
        
    }
}
