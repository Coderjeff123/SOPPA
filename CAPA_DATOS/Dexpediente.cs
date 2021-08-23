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
      
        string Nombre;
        string Estado;
        byte[] Foto;
        string Noexpediente;

        public Dexpediente() { }

        /*public Dexpediente(string iD_Expediente, string nombre, string estado, byte[] foto, string noexpediente)
        {
            ID_Expediente = iD_Expediente;
            Nombre = nombre;
            Estado = estado;
            Foto = foto;
            Noexpediente = noexpediente;
        }*/

        public Dexpediente( string nombre1, string estado1, byte[] foto1, string noexpediente1)
        {
            
            Nombre1 = nombre1;
            Estado1 = estado1;
            Foto1 = foto1;
            Noexpediente1 = noexpediente1;
        }

        
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public byte[] Foto1 { get => Foto; set => Foto = value; }
        public string Noexpediente1 { get => Noexpediente; set => Noexpediente = value; }

        public string insertexpediente(Dexpediente expE)
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
                SP_NewEX.CommandText = "psci.SP_NewE";
                SP_NewEX.CommandType = CommandType.StoredProcedure;

                SqlParameter Nombre = new SqlParameter();
                Nombre.ParameterName = "@Nombre";
                Nombre.SqlDbType = SqlDbType.NVarChar;
                Nombre.Size = 50;
                Nombre.Value = expE.Nombre1;
                SP_NewEX.Parameters.Add(Nombre);

                SqlParameter Estado = new SqlParameter();
                Estado.ParameterName = "@Estado";
                Estado.SqlDbType = SqlDbType.NChar;
                Estado.Value = expE.Estado1;
                SP_NewEX.Parameters.Add(Estado);

                SqlParameter Foto = new SqlParameter();
                Foto.ParameterName = "@Foto";
                Foto.SqlDbType = SqlDbType.Image;
                //Nombre.Size = 50;
                Foto.Value = expE.Foto1;
                SP_NewEX.Parameters.Add(Foto);

                SqlParameter Noexpediente = new SqlParameter();
                Noexpediente.ParameterName = "@NoExpediente";
                Noexpediente.SqlDbType = SqlDbType.NVarChar;
                Noexpediente.Size = 8;
                Noexpediente.Value = expE.Noexpediente1;
                SP_NewEX.Parameters.Add(Noexpediente);

                SqlDataReader sqlDataReader = SP_NewEX.ExecuteReader();


                if(sqlDataReader.HasRows)
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

        public string Updatexpediente(Dexpediente expE)
        {
            return "";
        }









    }






    }   



