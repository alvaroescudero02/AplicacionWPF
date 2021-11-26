using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PantallaPrincipal.Datos
{
    //Clase Libro para poder cambiarla, clonarla y que valide
    public class Libro : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        //Titulo con getter, setter y propiedad para cambiarlo
        private String titulo;
        private String Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Título"));
            }
        }

        //Autor con getter, setter y propiedad para cambiarlo
        private String autor;
        private String Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Autor"));
            }
        }

        //Fecha con getter, setter y propiedad para cambiarlo
        private DateTime fechaEntrada;
        private DateTime FechaEntrada
        {
            get
            {
                return fechaEntrada;
            }
            set
            {
                fechaEntrada = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("FechaEntrada"));
            }
        }

        //Interfaz del error para validar
        public string Error
        {
            get { return ""; }
        }

        //Interfaz para implementar las validaciones
        public string this[string columnName] 
        {
            get
            {
                string result = "";
                if (columnName == "Título")
                {
                    if (string.IsNullOrEmpty(titulo))
                        result = "Debe introducir el título";
                }
                if (columnName == "Autor")
                {
                    if (string.IsNullOrEmpty(autor))
                        result = "Debe introducir el autor";
                }
                return result;
            }
        }

        //Constructor vacío de libro
        public Libro()
        {
            this.fechaEntrada = DateTime.Now;
        }

        //Constructor de libro
        public Libro(String titulo, String autor, DateTime fechaEntrada)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.fechaEntrada = fechaEntrada;
        }

        //Interfaz para poder cambiar el objeto
        public event PropertyChangedEventHandler PropertyChanged;

        //Interfaz para clonar el objeto
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
