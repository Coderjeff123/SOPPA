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

        public string insertexpediente(string nombre, string estado, byte[] foto, string noexpediente)
        {

            Dexpediente datos = new Dexpediente();
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

        public  DataTable showEX()
        {
            DataTable tabla = new DataTable();
            Dexpediente datos = new Dexpediente();
            tabla = datos.showEX();
            return tabla;
            
        }

        public DataTable buscarexpediente( string nombre)
        {
            DataTable table = new DataTable();
            Dexpediente datos = new Dexpediente();
            datos.Nombre1 = nombre;
            table = datos.buscarexpediente(datos);
            return table;

        }

        public string Baja(string ID, string estado)
        {
            Dexpediente datos = new Dexpediente();
            datos.ID_Expediente1 = ID;
            datos.Estado1 = estado;
           return datos.baja(datos);
        }

        public DataTable mostrarfoto(string id)
        {
            DataTable tabla = new DataTable();
            Dexpediente datos = new Dexpediente();
            datos.ID_Expediente1 = id;
            tabla =datos.mostrarfoto(datos);
            return tabla;
        }


    }
}
