using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CAPA_DATOS
{
    public class Dexpediente
    {
        string ID_Expediente;
        string Nombre;
        string Estado;
        byte[] Foto;
        string Noexpediente;

        public Dexpediente() { }

        public Dexpediente(string iD_Expediente, string nombre, string estado, byte[] foto, string noexpediente)
        {
            ID_Expediente = iD_Expediente;
            Nombre = nombre;
            Estado = estado;
            Foto = foto;
            Noexpediente = noexpediente;
        }

        public string ID_Expediente1 { get => ID_Expediente; set => ID_Expediente = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public byte[] Foto1 { get => Foto; set => Foto = value; }
        public string Noexpediente1 { get => Noexpediente; set => Noexpediente = value; }

        public string insert(Dexpediente exp)
        {
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewE = new SqlCommand();
                SP_NewE.Connection = Conectar;
                SP_NewE.CommandText = "File_psico";
                SP_NewE.CommandType = CommandType.StoredProcedure;

                SqlParameter Expediente = new SqlParameter();
                Expediente.ParameterName = "@ID_Expediente";
                Expediente.SqlDbType = SqlDbType.Int;
                //Expediente.Size = 0;
                Expediente.Value = exp.ID_Expediente1;
                SP_NewE.Parameters.Add(Expediente);

                SqlParameter Nombre = new SqlParameter();
                Nombre.ParameterName = "@Nombre";
                Nombre.SqlDbType = SqlDbType.NVarChar;
                Nombre.Size = 50;
                Nombre.Value = exp.Nombre1;
                SP_NewE.Parameters.Add(Nombre);

                SqlParameter Estado = new SqlParameter();
                Estado.ParameterName = "@Estado";
                Estado.SqlDbType = SqlDbType.NVarChar;
                Estado.Size = 50;
                Estado.Value = exp.Estado1;
                SP_NewE.Parameters.Add(Estado);

                SqlParameter Foto = new SqlParameter();
                Nombre.ParameterName = "@ID_Expediente";
                Nombre.SqlDbType = SqlDbType.NVarChar;
                Nombre.Size = 50;
                Nombre.Value = exp.Nombre1;
                SP_NewE.Parameters.Add(Nombre);












                if (SP_NewE.ExecuteNonQuery() == 1)
                {
                    retorno = "Everything it's ok";
                }
                else
                {
                    retorno = "Houston tenemos un problema";
                }

            }
            catch (Exception e)
            {
                retorno = e.Message;
            }
            finally
            {
                //verificacion la conexion segun el caso cerramos si es necesario
                if (Conectar.State == ConnectionState.Open)
                {
                    Conectar.Close();
                }
            }
            return retorno;
        }

        public string Update(Dexpediente exp)
        {
            return "";
        }









    }






    }   



