using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_DATOS;


namespace CAPA_NEGOCIO
{
    public class CitaN
    {

        public  string insertcita(string iD_Cita1, string iD_Remision1, DateTime fecha1)
        {
            CitaD datos = new CitaD();
            datos.ID_Cita1 = iD_Cita1;
            datos.ID_Remision1 = iD_Remision1;
            datos.Fecha1 = fecha1;

            return datos.insertcita(datos);
        }

        public  string updatecita(string iD_Cita1, string iD_Remision1, DateTime fecha1)
        {
            CitaD datos = new CitaD();
            datos.ID_Cita1 = iD_Cita1;
            datos.ID_Remision1 = iD_Remision1;
            datos.Fecha1 = fecha1;

            return datos.Updatecita(datos);
        }

        public  DataTable showct()
        {
            DataTable tablec = new DataTable();
            CitaD datos = new CitaD();
            tablec = datos.showct();
            return tablec;
        }

        public  DataTable buscarcita(string iD_Cita)
        {
            CitaD datos = new CitaD();
            datos.ID_Cita1 = iD_Cita;
            return datos.buscarcita(datos);
        }















    }
}
