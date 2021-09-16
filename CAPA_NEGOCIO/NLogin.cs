using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using CAPA_DATOS.usercache;

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

     

        public string anymetoth()
        {
            string retorno;
            if (USERcache.Nombre == Cargos.Administrador)
            {
                retorno = "Admin";
            }
            else 
            {
                retorno = "Coordinador"; 
            }

            return retorno;

        }
    }
    
}
