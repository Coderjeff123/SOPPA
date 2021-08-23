using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class RemisionN
    {
        public static string insertremision(string iD_Remision, string iD_Expediente, string remitente, string motivoRemision)
        {
            RemisionD datos = new RemisionD();
            datos.ID_Remision1 = iD_Remision;
            datos.ID_Expediente1 = iD_Expediente;
            datos.Remitente1 = remitente;
            datos.MotivoRemision1 = motivoRemision;

            return datos.insertremision(datos);


        }

        public static string updateremision(string iD_Remision, string iD_Expediente, string remitente, string motivoRemision)
        {
            RemisionD datos = new RemisionD();
            datos.ID_Remision1 = iD_Remision;
            datos.ID_Expediente1 = iD_Expediente;
            datos.Remitente1 = remitente;
            datos.MotivoRemision1 = motivoRemision;

            return datos.Updateremision(datos);


        }

        public static DataTable showR()
        {
            RemisionD datos = new RemisionD();
            return datos.showR();
        }
















    }
}
