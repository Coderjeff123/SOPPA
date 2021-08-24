using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAPA_DATOS;


namespace CAPA_NEGOCIO
{
    public class Nexpediente
    {

        public string insertexpediente(string id_Expediente, string nombre, string estado, byte[] foto, string noexpediente)
        {

            Dexpediente datos = new Dexpediente();
            datos.ID_Expediente1 = id_Expediente;
            datos.Nombre1 = nombre;
            datos.Estado1 = estado;
            datos.Foto1 = foto;
            datos.Noexpediente1 = noexpediente;

            return datos.insertexpediente(datos);


        }

        public string UpdateDexpediente(string id_Expediente, string nombre, string estado, byte[] foto)
        {

            Dexpediente datos = new Dexpediente();
            datos.ID_Expediente1 = id_Expediente;
            datos.Nombre1 = nombre;
            datos.Estado1 = estado;
            datos.Foto1 = foto;
            

            return datos.UpdateDexpediente(datos);


        }

        public static DataTable showEX()
        {
            Dexpediente datos = new Dexpediente();
            return datos.showEX();
        }

        public static DataTable buscarexpediente()
        {
            Dexpediente datos = new Dexpediente();
            return datos.buscarexpediente(datos);
        }


    }
}
