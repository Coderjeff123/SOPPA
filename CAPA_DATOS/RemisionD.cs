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
        string ID_Remision;
        string ID_Expediente;
        string Remitente;
        string MotivoRemision;

        public RemisionD() { }

        public RemisionD(string iD_Remision1, string iD_Expediente1, string remitente1, string motivoRemision1)
        {
            ID_Remision1 = iD_Remision1;
            ID_Expediente1 = iD_Expediente1;
            Remitente1 = remitente1;
            MotivoRemision1 = motivoRemision1;
        }

        public string ID_Remision1 { get => ID_Remision; set => ID_Remision = value; }
        public string ID_Expediente1 { get => ID_Expediente; set => ID_Expediente = value; }
        public string Remitente1 { get => Remitente; set => Remitente = value; }
        public string MotivoRemision1 { get => MotivoRemision; set => MotivoRemision = value; }


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
                SP_NewRe.CommandText = "SP_NewR";
                SP_NewRe.CommandType = CommandType.StoredProcedure;

                SqlParameter Id_remision = new SqlParameter();
                Id_remision.ParameterName = "@ID_Remision";
                Id_remision.SqlDbType = SqlDbType.Int;
                //Id_remision.Size = 50;
                Id_remision.Value = expR.ID_Remision1;
                SP_NewRe.Parameters.Add(Id_remision);

                SqlParameter Id_expediente = new SqlParameter();
                Id_expediente.ParameterName = "@ID_Remision";
                Id_expediente.SqlDbType = SqlDbType.Int;
                //Id_remision.Size = 50;
                Id_expediente.Value = expR.ID_Expediente1;
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
                Id_expediente.Value = expR.ID_Expediente1;
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

        public string Updateremision(RemisionD expR)
        {
            return "";
        }
    }
}
