﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;


namespace CAPA_NEGOCIO
{
    public class Nexpediente
    {

        public string insertexpediente( string nombre, string estado, byte[] foto, string noexpediente)
        {

            Dexpediente datos = new Dexpediente();
            datos.Nombre1 = nombre;
            datos.Estado1 = estado;
            datos.Foto1 = foto;
            datos.Noexpediente1 = noexpediente;

            return datos.insertexpediente(datos);


        }





    }
}
