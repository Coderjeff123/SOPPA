using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class NLogin
    {
        public NLogin()
        {
        }

        public  string loginuser(string user, string pass)
        {
            DLogin dLogin = new DLogin();

            dLogin.Nombre = user;
            dLogin.Contraseña= pass;

            return dLogin.INICIO(dLogin);
        }

        public string very(string res)
        {
            DLogin login = new DLogin();
            res = login.Nombre;
            

            return login.secur(login);
        }
            
        
       }
    
}
