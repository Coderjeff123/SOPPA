using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class ConsultaN
    {
        public static string insertconsulta(string iD_Consulta, string iD_Cita, string actividades, string observaciones, string tipo)

        {
            ConsultaD datos = new ConsultaD();
            datos.ID_Consulta1 = iD_Consulta;
            datos.ID_Cita1 = iD_Cita;
            datos.Actividades1 = actividades;
            datos.Observaciones1 = observaciones;
            datos.Tipo1 = tipo;

            return datos.insertconsulta(datos);


        }

        public static string Updateconsulta(string iD_Consulta, string actividades, string observaciones, string tipo)

        {
            ConsultaD datos = new ConsultaD();
            datos.ID_Consulta1 = iD_Consulta;

            datos.Actividades1 = actividades;
            datos.Observaciones1 = observaciones;
            datos.Tipo1 = tipo;

            return datos.Updateconsulta(datos);


        }

        public static DataTable showc()
        {
            ConsultaD datos = new ConsultaD();
            return datos.showc();
        }

        public static DataTable buscarconsulta(string iD_Consulta)
        {
            ConsultaD datos = new ConsultaD();
            datos.ID_Consulta1 = iD_Consulta;
            return datos.buscarconsulta(datos);
        }


        public static DataTable buscarconsultaA(string iD_Cita)
        {
            ConsultaD datos = new ConsultaD();
            datos.ID_Cita1 = iD_Cita;
            return datos.buscarconsultaA(datos);
        }







    }
}
