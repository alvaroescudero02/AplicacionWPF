using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PantallaPrincipal.Datos
{
    //Clase pregunta para poder cambiarla
    public class Pregunta : INotifyPropertyChanged
    {
        //Propiedades con getter y setter, además Respuesta tiene la propiedad para cambiarla
        public int N_pregunta { get; set; }
        private String respuesta;
        public string Respuesta
        {
            get { return respuesta; }
            set
            {
                this.respuesta = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Respuesta"));
            }
        }
        public bool Correcta { get; set; }
        public string Respuesta_correcta { get; set; }

        //Constructor de Pregunta
        public Pregunta(int n_pregunta, string respuesta, bool correcta, string respuesta_correcta)
        {
            this.N_pregunta = n_pregunta;
            this.respuesta = respuesta;
            this.Correcta = correcta;
            this.Respuesta_correcta = respuesta_correcta;
        }

        //Interfaz para poder cambiar el objeto
        public event PropertyChangedEventHandler PropertyChanged;

        //Sobrecarga
        public override string ToString()
        {
            return N_pregunta + " " + Respuesta + " " + Correcta + " " + Respuesta_correcta;
        }


    }
}
