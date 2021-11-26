using PantallaPrincipal.Datos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PantallaPrincipal.Logica
{
    //Clase Libros que funciona como lógica de negocio
    public class Libros
    {
        //Lista de Libros con constructor
        public ObservableCollection<Libro> listaLibros { get; set; }

        public Libros()
        {
            listaLibros = new ObservableCollection<Libro>();
            listaLibros.Add(new Libro("Un título", "Autor", DateTime.Now));
        }

        //Método para añadir libros a la lista
        public void anyadirLibro(Libro libro)
        {
            listaLibros.Add(libro);
        }

        //Método para cambiiar los libros
        public void modificarLibro(Libro libro, int posicion)
        {
            listaLibros[posicion] = libro;
        }
    }
}
