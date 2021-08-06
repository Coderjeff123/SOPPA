using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class SeguimientoD
    {
        string ID_Seguimiento;
        string ID_Consulta;
        DateTime Fecha_inicio;
        DateTime Fecha_final;
        string Observaciones;

        public SeguimientoD() { }

        public SeguimientoD(string iD_Seguimiento1, string iD_Consulta1, DateTime fecha_inicio1, DateTime fecha_final1, string observaciones1)
        {
            ID_Seguimiento1 = iD_Seguimiento1;
            ID_Consulta1 = iD_Consulta1;
            Fecha_inicio1 = fecha_inicio1;
            Fecha_final1 = fecha_final1;
            Observaciones1 = observaciones1;
        }

        public string ID_Seguimiento1 { get => ID_Seguimiento; set => ID_Seguimiento = value; }
        public string ID_Consulta1 { get => ID_Consulta; set => ID_Consulta = value; }
        public DateTime Fecha_inicio1 { get => Fecha_inicio; set => Fecha_inicio = value; }
        public DateTime Fecha_final1 { get => Fecha_final; set => Fecha_final = value; }
        public string Observaciones1 { get => Observaciones; set => Observaciones = value; }


        public string insert(SeguimientoD exp)
        {
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand SP_NewS = new SqlCommand();
                SP_NewS.Connection = Conectar;
                SP_NewS.CommandText = "pcsi.Seguimiento";
                SP_NewS.CommandType = CommandType.StoredProcedure;

                SqlParameter Id_seguimiento = new SqlParameter();
                Id_seguimiento.ParameterName = "@ID_Seguimiento";
                Id_seguimiento.SqlDbType = SqlDbType.Int;
                //Id_seguimiento.Size = 50;
                Id_seguimiento.Value = exp.ID_Seguimiento1;
                SP_NewS.Parameters.Add(Id_seguimiento);

                SqlParameter Id_consulta = new SqlParameter();
                Id_consulta.ParameterName = "@ID_Consulta";
                Id_consulta.SqlDbType = SqlDbType.Int;
                //Id_seguimiento.Size = 50;
                Id_consulta.Value = exp.ID_Consulta1;
                SP_NewS.Parameters.Add(Id_consulta);

                SqlParameter fecha_inicio = new SqlParameter();
                fecha_inicio.ParameterName = "@ID_Seguimiento";
                fecha_inicio.SqlDbType = SqlDbType.DateTime;
                //Id_seguimiento.Size = 50;
                fecha_inicio.Value = exp.Fecha_inicio1;
                SP_NewS.Parameters.Add(fecha_inicio);

                SqlParameter fecha_final = new SqlParameter();
                fecha_final.ParameterName = "@ID_Seguimiento";
                fecha_final.SqlDbType = SqlDbType.DateTime;
                //Id_seguimiento.Size = 50;
                fecha_final.Value = exp.Fecha_final1;
                SP_NewS.Parameters.Add(fecha_final);

                SqlParameter Observacion = new SqlParameter();
                Observacion.ParameterName = "@Observaciones";
                Observacion.SqlDbType = SqlDbType.NVarChar;
                Observacion.Size = 3000;
                Observacion.Value = exp.Observaciones1;
                SP_NewS.Parameters.Add(Observacion);





                if (SP_NewS.ExecuteNonQuery() == 1)
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

        public string Update(SeguimientoD exp)
        {
            return "";
        }



















    }
}    
 