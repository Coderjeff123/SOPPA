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

        public Dexpediente(string iD_Expediente1, string nombre1, string estado1, byte[] foto1, string noexpediente1)
        {
            ID_Expediente1 = iD_Expediente1;
            Nombre1 = nombre1;
            Estado1 = estado1;
            Foto1 = foto1;
            Noexpediente1 = noexpediente1;
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
                SqlCommand SP_NewEX = new SqlCommand();
                SP_NewEX.Connection = Conectar;
                SP_NewEX.CommandText = "SP_NewE";
                SP_NewEX.CommandType = CommandType.StoredProcedure;

                SqlParameter Expediente = new SqlParameter();
                Expediente.ParameterName = "@ID_Expediente";
                Expediente.SqlDbType = SqlDbType.Int;
                //Expediente.Size = 0;
                Expediente.Value = exp.ID_Expediente1;
                SP_NewEX.Parameters.Add(Expediente);

                SqlParameter Nombre = new SqlParameter();
                Nombre.ParameterName = "@Nombre";
                Nombre.SqlDbType = SqlDbType.NVarChar;
                Nombre.Size = 50;
                Nombre.Value = exp.Nombre1;
                SP_NewEX.Parameters.Add(Nombre);

                SqlParameter Estado = new SqlParameter();
                Estado.ParameterName = "@Estado";
                Estado.SqlDbType = SqlDbType.NChar;
                Estado.Size = 10;
                Estado.Value = exp.Estado1;
                SP_NewEX.Parameters.Add(Estado);

                SqlParameter Foto = new SqlParameter();
                Foto.ParameterName = "@Foto";
                Foto.SqlDbType = SqlDbType.Image;
                //Nombre.Size = 50;
                Foto.Value = exp.Foto1;
                SP_NewEX.Parameters.Add(Foto);

                SqlParameter Noexpediente = new SqlParameter();
                Estado.ParameterName = "@NoExpediente";
                Estado.SqlDbType = SqlDbType.NVarChar;
                Estado.Size = 8;
                Estado.Value = exp.Noexpediente1;
                SP_NewEX.Parameters.Add(Noexpediente);




                if (SP_NewEX.ExecuteNonQuery() == 1)
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



