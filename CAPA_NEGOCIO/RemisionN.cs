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
        public string insertremision( int iD_Expediente, string remitente, string motivoRemision, DateTime Fecha)
        {
            RemisionD datos = new RemisionD();
            
            datos.ID_Expediente2 = iD_Expediente;
            datos.Remitente1 = remitente;
            datos.MotivoRemision1 = motivoRemision;
            datos.Fecha = Fecha;

            return datos.insertremision(datos);


        }

        public static string updateremision(int iD_Expediente, string remitente, string motivoRemision)
        {
            RemisionD datos = new RemisionD();
            
            datos.ID_Expediente2 = iD_Expediente;
            datos.Remitente1 = remitente;
            datos.MotivoRemision1 = motivoRemision;

            return datos.Updateremision(datos);


        }

        public static DataTable showR()
        {
            DataTable tableR = new DataTable();
            RemisionD datos = new RemisionD();
            tableR = datos.showR();
            return tableR;
        }
















    }
}
