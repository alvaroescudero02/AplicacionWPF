using PantallaPrincipal.Datos;
using PantallaPrincipal.Logica;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PantallaPrincipal
{
    /// <summary>
    /// Lógica de interacción para DialogoLibro.xaml
    /// </summary>
    
    //Clase DialogoLibro para poder añadir o modificar los libros de la tabla
    public partial class DialogoLibro : Window
    {

        private Libros libros;
        public Libro libro;
        private int posicion;
        private Boolean modificar;
        private int errores;

        //Constructor del DialogoLibro que no se modifica
        public DialogoLibro(Libros libros)
        {
            InitializeComponent();
            this.libros = libros;
            libro = new Libro();
            this.DataContext = libro;
            modificar = false;
        }

        //Constructor del DialogoLibro que sí se modifica
        public DialogoLibro(Libros libros, Libro lmodificar, int posicion)
        {
            InitializeComponent();
            this.libros = libros;
            this.libro = lmodificar;
            this.posicion = posicion;
            this.DataContext = libro;
            modificar = true;
        }

        //Botón para cancelar la acción
        private void bt_cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Botón de aceptar para modificar o añadir un libro
        private void bt_aceptar_Click(object sender, RoutedEventArgs e)
        {
            if (modificar)
                libros.modificarLibro(libro, posicion);
            else
                libros.anyadirLibro(libro);

            this.Close();
        }

        //Método para aplicar las validaciones a la pantalla, además de cancelar el uso del botón aceptar si hay un error
        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                errores++;
            else
                errores--;

            if (errores == 0)
                bt_aceptar.IsEnabled = true;
            else
                bt_aceptar.IsEnabled = false;
        }
    }
}
