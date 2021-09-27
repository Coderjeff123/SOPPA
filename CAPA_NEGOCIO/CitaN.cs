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

        public  string insertcita(int iD_Remision1, DateTime fecha1,DateTime hora1)
        {
            CitaD datos = new CitaD();
            datos.ID_Remision1 = iD_Remision1;
            datos.Fecha1 = fecha1;
            datos.Hora1 = hora1;

            return datos.insertcita(datos);
        }

        public  string updatecita(int iD_Cita1, int iD_Remision1, DateTime fecha1)
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

        public  DataTable buscarcitas(string nombre)
        {
            DataTable table = new DataTable();
            CitaD datos = new CitaD();
            Dexpediente dato = new Dexpediente();
            dato.Nombre1 = nombre;
            table = datos.buscarcita(dato);
            return table;
            
        }


        public void ingresar(DateTime fecha1)
        {
           






        }












    }
}
