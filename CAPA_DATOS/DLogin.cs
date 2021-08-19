using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CAPA_DATOS
{
    public class DLogin
    {
        string nombre;
        string contraseña;
        string very;

        public DLogin()
        {
        }

        public DLogin(string nombre, string contraseña, string very)
        {
            Nombre = nombre;
            Contraseña = contraseña;
            this.Very = very;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Very { get => very; set => very = value; }

        public string INICIO(DLogin sesion)
        {
            string retorno = "";
            SqlConnection conectar = new SqlConnection();
            try
            {
                conectar.ConnectionString = Conet.cnx;
                conectar.Open();

                SqlCommand splogin = new SqlCommand();
                splogin.Connection = conectar;
                splogin.CommandText = "psci.ShowU";
                splogin.CommandType = CommandType.StoredProcedure;

                SqlParameter nom = new SqlParameter();
                nom.ParameterName = "@Nombre";
                nom.SqlDbType = SqlDbType.NChar;
                nom.Value = sesion.Nombre;
                splogin.Parameters.Add(nom);

                SqlParameter con = new SqlParameter();
                con.ParameterName = "@Contraseña";
                con.SqlDbType = SqlDbType.NChar;
                con.Value = sesion.Contraseña;
                splogin.Parameters.Add(con);

                SqlDataReader sqlDataReader = splogin.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    retorno = "Everithing its ok";
                    
                }
                else
                {
                    retorno = "you have a problem";
                }
            }
            catch (Exception e)
            {
                retorno=e.Message;
            }
            finally
            {
                conectar.Close();
            }
           
           

            return retorno;
        }

        public string secur(DLogin ver)
        {
            string retorno = "";
            if (Nombre == "Admin")
            {
                retorno = "Admin";
            }
            if (Nombre == "Coordinador")
            {
                retorno = "Coordinador";
            }
            return retorno;
        }
       
    }
}
