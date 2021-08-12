using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;


namespace CAPA_NEGOCIO
{
    public class Nexpediente
    {

        public static string insertexpediente(string iD_Expediente, string nombre, string estado, byte[] foto, string noexpediente)
        {

            Dexpediente datos = new Dexpediente();
            datos.ID_Expediente1 = iD_Expediente;
            datos.Nombre1 = nombre;
            datos.Estado1 = estado;
            datos.Foto1 = foto;
            datos.Noexpediente1 = noexpediente;

            return datos.insertexpediente(datos);


        }





    }
}
