using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class RemisionD
    {

        int ID_Expediente;
        string Remitente;
        string MotivoRemision;
        DateTime fecha;

        public RemisionD() { }

        public RemisionD(int iD_Expediente1, string remitente1, string motivoRemision1, DateTime fecha)
        {
            
            ID_Expediente2 = iD_Expediente1;
            Remitente1 = remitente1;
            MotivoRemision1 = motivoRemision1;
            Fecha = fecha;
        }

        
        
        public string Remitente1 { get => Remitente; set => Remitente = value; }
        public string MotivoRemision1 { get => MotivoRemision; set => MotivoRemision = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int ID_Expediente2 { get => ID_Expediente; set => ID_Expediente = value; }

        public string insertremision(RemisionD expR)
        {
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewRe = new SqlCommand();
                SP_NewRe.Connection = Conectar;
                SP_NewRe.CommandText = "psci.SP_NewR";
                SP_NewRe.CommandType = CommandType.StoredProcedure;

                

                SqlParameter Id_expediente = new SqlParameter();
                Id_expediente.ParameterName = "@ID_Expediente";
                Id_expediente.SqlDbType = SqlDbType.Int;
                //Id_remision.Size = 50;
                Id_expediente.Value = expR.ID_Expediente2;
                SP_NewRe.Parameters.Add(Id_expediente);

                SqlParameter remitente = new SqlParameter();
                remitente.ParameterName = "@Remitente";
                remitente.SqlDbType = SqlDbType.NVarChar;
                remitente.Size = 30;
                remitente.Value = expR.Remitente1;
                SP_NewRe.Parameters.Add(remitente);

                SqlParameter motivo = new SqlParameter();
                motivo.ParameterName = "@MotivoRemision";
                motivo.SqlDbType = SqlDbType.NVarChar;
                motivo.Size = 100;
                motivo.Value = expR.MotivoRemision;
                SP_NewRe.Parameters.Add(motivo);

                SqlParameter Fecha = new SqlParameter();
                Fecha.ParameterName = "@Fecha";
                Fecha.SqlDbType = SqlDbType.DateTime;
                Fecha.Value = expR.Fecha;
                SP_NewRe.Parameters.Add(Fecha);
                

                SqlDataReader dataReader = SP_NewRe.ExecuteReader();


                if (dataReader.HasRows)
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

        public string Updateremision(RemisionD expR)
        {
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewRe = new SqlCommand();
                SP_NewRe.Connection = Conectar;
                SP_NewRe.CommandText = "SP_UpdateR";
                SP_NewRe.CommandType = CommandType.StoredProcedure;

               

                SqlParameter Id_expediente = new SqlParameter();
                Id_expediente.ParameterName = "@ID_Remision";
                Id_expediente.SqlDbType = SqlDbType.Int;
                //Id_remision.Size = 50;
                Id_expediente.Value = expR.ID_Expediente2;
                SP_NewRe.Parameters.Add(Id_expediente);

                SqlParameter remitente = new SqlParameter();
                remitente.ParameterName = "@Remitente";
                remitente.SqlDbType = SqlDbType.NVarChar;
                remitente.Size = 30;
                remitente.Value = expR.Remitente1;
                SP_NewRe.Parameters.Add(remitente);

                SqlParameter motivo = new SqlParameter();
                motivo.ParameterName = "@ID_Remision";
                motivo.SqlDbType = SqlDbType.NVarChar;
                motivo.Size = 100;
                motivo.Value = expR.MotivoRemision1;
                SP_NewRe.Parameters.Add(motivo);






                if (SP_NewRe.ExecuteNonQuery() == 1)
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

        public DataTable showR()
        {

            DataTable showremision = new DataTable("remision");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewRe = new SqlCommand();
                SP_NewRe.Connection = Conectar;
                SP_NewRe.CommandText = "SP_ShowR";
                SP_NewRe.CommandType = CommandType.StoredProcedure;




                SqlDataAdapter adartar = new SqlDataAdapter(SP_NewRe);
                adartar.Fill(showremision);



                if (SP_NewRe.ExecuteNonQuery() == 1)
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
            return showremision;


        }

        /*public DataTable buscarremision(RemisionD expR)
        {

            DataTable showremision = new DataTable("remision");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewRe = new SqlCommand();
                SP_NewRe.Connection = Conectar;
                SP_NewRe.CommandText = "SP_BuscarCT";
                SP_NewRe.CommandType = CommandType.StoredProcedure;


                




                SqlDataAdapter adartar = new SqlDataAdapter(SP_NewRe);
                adartar.Fill(showremision);



                if (SP_NewRe.ExecuteNonQuery() == 1)
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
            return showremision;


        }*/






    }
}
