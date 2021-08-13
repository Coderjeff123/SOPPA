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
        int Iduser;
        string nombre;
        float contraseña;

        public DLogin()
        {
        }

        public DLogin(int iduser1, string nombre, float contraseña)
        {
            Iduser1 = iduser1;
            Nombre = nombre;
            Contraseña = contraseña;
        }

        public int Iduser1 { get => Iduser; set => Iduser = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Contraseña { get => contraseña; set => contraseña = value; }

        public string INICIO(DLogin sesion)
        {
            string retorno = "";
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Conet.cnx;
                connection.Open();
                SqlCommand sql = new SqlCommand();
                sql.Connection = connection;
                sql.CommandText = "ShowU";
                sql.CommandType = CommandType.StoredProcedure;

                SqlParameter nombre = new SqlParameter();
                nombre.ParameterName = "@Nombre";
                nombre.SqlDbType = SqlDbType.NChar;
                nombre.Value = sesion.Nombre;
                sql.Parameters.Add(nombre);

                SqlParameter Contra = new SqlParameter();
                Contra.ParameterName = "@Contraseña";
                Contra.SqlDbType = SqlDbType.NChar;
                Contra.Value = sesion.contraseña;
                sql.Parameters.Add(Contra);

                if (sql.ExecuteNonQuery()==1)
                {
                    retorno = "Everithing its ok";
                }
                else
                {
                    retorno = "You have a problem";
                }

            }
            catch(Exception e)
            {
                retorno = e.Message;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return retorno;
        }
    }
}
