using PantallaPrincipal.Datos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    
    //Pantalla Registro para poder registrarse
    public partial class Registro : Window
    {
        //Lista de Cursos para el combobox
        public List<Curso> Cursos { get; set; }

        //Constructor con los datos del combobox
        public Registro()
        {
            
            InitializeComponent();
            Cursos = new List<Curso>();
            Cursos.Add(new Curso("1ºPrimaria"));
            Cursos.Add(new Curso("2ºPrimaria"));
            Cursos.Add(new Curso("3ºPrimaria"));
            Cursos.Add(new Curso("4ºPrimaria"));
            Cursos.Add(new Curso("5ºPrimaria"));
            Cursos.Add(new Curso("6ºPrimaria"));
            Cursos.Add(new Curso("1ºESO"));
            Cursos.Add(new Curso("2ºESO"));
            Cursos.Add(new Curso("3ºESO"));
            Cursos.Add(new Curso("4ºESO"));
            Cursos.Add(new Curso("1ºBachillerato"));
            Cursos.Add(new Curso("2ºBachillerato"));
            this.DataContext = this;
        }

        //Botones para ir a otras pantallas
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
