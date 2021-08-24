using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class CitaD
    {
        string ID_Cita;
        string ID_Remision;
        DateTime Fecha;

        public CitaD(){}

        public CitaD(string iD_Cita1, string iD_Remision1, DateTime fecha1)
        {
            ID_Cita1 = iD_Cita1;
            ID_Remision1 = iD_Remision1;
            Fecha1 = fecha1;
        }

        public string ID_Cita1 { get => ID_Cita; set => ID_Cita = value; }
        public string ID_Remision1 { get => ID_Remision; set => ID_Remision = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }


        public string insertcita(CitaD expCt)
        {
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_Newcita = new SqlCommand();
                sp_Newcita.Connection = Conectar;
                sp_Newcita.CommandText = "psci.SP_NewCi";
                sp_Newcita.CommandType = CommandType.StoredProcedure;

                SqlParameter Cita = new SqlParameter();
                Cita.ParameterName = "@ID_Cita";
                Cita.SqlDbType = SqlDbType.Int;
                //Cita.Size = 0;
                Cita.Value = expCt.ID_Cita1;
                sp_Newcita.Parameters.Add(Cita);

                SqlParameter Id_remision = new SqlParameter();
                Id_remision.ParameterName = "@ID_Remision";
                Id_remision.SqlDbType = SqlDbType.Int;
                //Id_remision.Size = 50;
                Id_remision.Value = expCt.ID_Remision1;
                sp_Newcita.Parameters.Add(Id_remision);


                SqlParameter fecha = new SqlParameter();
                fecha.ParameterName = "@Fecha";
                fecha.SqlDbType = SqlDbType.DateTime;
                //Id_seguimiento.Size = 50;
                fecha.Value = expCt.Fecha1;
                sp_Newcita.Parameters.Add(fecha);

                SqlDataReader sqlDataReader = sp_Newcita.ExecuteReader();

                if (sqlDataReader.HasRows)
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

        public string Updatecita(CitaD expCt)
        {
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_Newcita = new SqlCommand();
                sp_Newcita.Connection = Conectar;
                sp_Newcita.CommandText = "psci.SP_UpdateCi";
                sp_Newcita.CommandType = CommandType.StoredProcedure;

                SqlParameter Cita = new SqlParameter();
                Cita.ParameterName = "@ID_Cita";
                Cita.SqlDbType = SqlDbType.Int;
                //Cita.Size = 0;
                Cita.Value = expCt.ID_Cita1;
                sp_Newcita.Parameters.Add(Cita);

                SqlParameter Id_remision = new SqlParameter();
                Id_remision.ParameterName = "@ID_Remision";
                Id_remision.SqlDbType = SqlDbType.Int;
                //Id_remision.Size = 50;
                Id_remision.Value = expCt.ID_Remision1;
                sp_Newcita.Parameters.Add(Id_remision);


                SqlParameter fecha = new SqlParameter();
                fecha.ParameterName = "@Fecha";
                fecha.SqlDbType = SqlDbType.DateTime;
                //Id_seguimiento.Size = 50;
                fecha.Value = expCt.Fecha1;
                sp_Newcita.Parameters.Add(fecha);





                if (sp_Newcita.ExecuteNonQuery() == 1)
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


        public DataTable showct()
        {

            DataTable showcita = new DataTable("cita");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_Newcita = new SqlCommand();
                sp_Newcita.Connection = Conectar;
                sp_Newcita.CommandText = "psci.SP_ShowCi";
                sp_Newcita.CommandType = CommandType.StoredProcedure;




                SqlDataAdapter adartar = new SqlDataAdapter(sp_Newcita);
                adartar.Fill(showcita);



                if (sp_Newcita.ExecuteNonQuery() == 1)
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
            return showcita;


        }


        public DataTable buscarcita(CitaD expCt)
        {

            DataTable showcita = new DataTable("cita");
            string retorno = "";
            SqlConnection Conectar = new SqlConnection();
            try
            {
                //Asignamos la cadena de conexión
                Conectar.ConnectionString = Conet.cnx;
                Conectar.Open();
                SqlCommand sp_Newcita = new SqlCommand();
                sp_Newcita.Connection = Conectar;
                sp_Newcita.CommandText = "psci.SP_BuscarCT";
                sp_Newcita.CommandType = CommandType.StoredProcedure;

                SqlParameter Cita = new SqlParameter();
                Cita.ParameterName = "@ID_Cita";
                Cita.SqlDbType = SqlDbType.Int;
                //Cita.Size = 0;
                Cita.Value = expCt.ID_Cita1;
                sp_Newcita.Parameters.Add(Cita);




                SqlDataAdapter adartar = new SqlDataAdapter(sp_Newcita);
                adartar.Fill(showcita);



                if (sp_Newcita.ExecuteNonQuery() == 1)
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
            return showcita;


        }
















    }
}
