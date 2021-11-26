using System;
using System.Collections.Generic;
using System.Text;

namespace PantallaPrincipal.Datos
{
    //Clase Curso para comboboxes
    public class Curso
    {
        //Constructor
        public Curso(string nombre)
        {
            Nombre = nombre;
        }

        //Nombre con getter y setter
        public string Nombre { get; set; }

        //Sobrecarga
        public override string ToString()
        {
            return Nombre + "";
        }
    }

}
