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
    /// Lógica de interacción para Tabla.xaml
    /// </summary>
    
    //Clase Tabla con Libros
    public partial class Tabla : Window
    {
        private Libros libros;

        public Tabla()
        {
            InitializeComponent();
            libros = new Libros();
            dg_libros.DataContext = libros;
        }

        //Botón para acceder a DialogoLibro
        private void mi_nuevo_Click(object sender, RoutedEventArgs e)
        {
            DialogoLibro dl = new DialogoLibro(libros);
            dl.Show();
        }

        //Botón para modificar la tabla
        private void bt_modificar_Click(object sender, RoutedEventArgs e)
        {
            if (dg_libros.SelectedIndex != -1)
            {
                Libro libro = (Libro)dg_libros.SelectedItem;
                DialogoLibro dl = new DialogoLibro(libros, (Libro)libro.Clone(), dg_libros.SelectedIndex);
                dl.Show();
            }
            
        }
    }
}
