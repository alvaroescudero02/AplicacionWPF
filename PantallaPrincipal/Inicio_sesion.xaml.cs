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
    /// Lógica de interacción para Inicio_sesion.xaml
    /// </summary>
    
    //Pantalla Inicio de Sesión para poder entrar
    public partial class Inicio_sesion : Window
    {
        public Inicio_sesion()
        {
            InitializeComponent();
        }

        //Botones para pasar a otras pantallas
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registro rs = new Registro();
            rs.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
