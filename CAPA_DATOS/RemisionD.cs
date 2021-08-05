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

        public RemisionD(string iD_Remision, string iD_Expediente, string remitente, string motivoRemision)
        {
            ID_Remision = iD_Remision;
            ID_Expediente1 = iD_Expediente;
            Remitente = remitente;
            MotivoRemision = motivoRemision;
        }

        public string ID_Remision1 { get => ID_Remision; set => ID_Remision = value; }
        public string ID_Expediente1 { get => ID_Expediente; set => ID_Expediente = value; }
        public string Remitente1 { get => Remitente; set => Remitente = value; }
        public string MotivoRemision1 { get => MotivoRemision; set => MotivoRemision = value; }


        public string insert(RemisionD exp)
        {
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewR = new SqlCommand();
                SP_NewR.Connection = Conectar;
                SP_NewR.CommandText = "pcsi.Remision";
                SP_NewR.CommandType = CommandType.StoredProcedure;

                SqlParameter Id_remision = new SqlParameter();
                Id_remision.ParameterName = "@ID_Remision";
                Id_remision.SqlDbType = SqlDbType.Int;
                //Id_remision.Size = 50;
                Id_remision.Value = exp.ID_Remision1;
                SP_NewR.Parameters.Add(Id_remision);

                SqlParameter Id_expediente = new SqlParameter();
                Id_expediente.ParameterName = "@ID_Remision";
                Id_expediente.SqlDbType = SqlDbType.Int;
                //Id_remision.Size = 50;
                Id_expediente.Value = exp.ID_Expediente1;
                SP_NewR.Parameters.Add(Id_expediente);

                SqlParameter remitente = new SqlParameter();
                remitente.ParameterName = "@Remitente";
                remitente.SqlDbType = SqlDbType.NVarChar;
                remitente.Size = 30;
                remitente.Value = exp.Remitente1;
                SP_NewR.Parameters.Add(remitente);

                SqlParameter motivo = new SqlParameter();
                motivo.ParameterName = "@ID_Remision";
                motivo.SqlDbType = SqlDbType.NVarChar;
                motivo.Size = 100;
                Id_expediente.Value = exp.ID_Expediente1;
                SP_NewR.Parameters.Add(motivo);




                if (SP_NewR.ExecuteNonQuery() == 1)
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
