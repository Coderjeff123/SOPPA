using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_DATOS;



namespace CAPA_NEGOCIO
{
    public class SeguimientoN
    {
        public static string insertseguimiento(string iD_Seguimiento, string iD_Consulta, DateTime fecha_inicio, DateTime fecha_final, string observaciones)
        {
            SeguimientoD datos = new SeguimientoD();
            datos.ID_Seguimiento1 = iD_Seguimiento;
            datos.ID_Consulta1 = iD_Consulta;
            datos.Fecha_inicio1 = fecha_inicio;
            datos.Fecha_final1 = fecha_final;
            datos.Observaciones1 = observaciones;

            return datos.insertseguimiento(datos);


        }

        public static string updateseguimientoO(string iD_Seguimiento,  string observaciones)
        {
            SeguimientoD datos = new SeguimientoD();
            datos.ID_Seguimiento1 = iD_Seguimiento;
     
            datos.Observaciones1 = observaciones;

            return datos.UpdateseguimientoO(datos);


        }

        public static string updateseguimientoF(string iD_Seguimiento, DateTime fecha_final)
        {
            SeguimientoD datos = new SeguimientoD();
            datos.ID_Seguimiento1 = iD_Seguimiento;
            datos.Fecha_final1 = fecha_final;
            

            return datos.UpdateseguimientoF(datos);


        }

        public static DataTable showS()
        {
            DataTable tableS = new DataTable();
            SeguimientoD datos = new SeguimientoD();
            tableS = datos.showS();
            return tableS;
        }




















    }
}
