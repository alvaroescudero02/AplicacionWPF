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
    /// Lógica de interacción para Cuestionarios_E.xaml
    /// </summary>

    //Clase Cuestionarios de ESO para seleccionar cuestionarios de ESO
    public partial class Cuestionarios_E : Window
    {
        public Cuestionarios_E()
        {
            InitializeComponent();
        }

        //Botones para poder ir a otras pantallas
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Perfil pf = new Perfil();
            pf.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Cuestionarios_P cp = new Cuestionarios_P();
            cp.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Cuestionario_B cb = new Cuestionario_B();
            cb.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CajaPreguntas cp = new CajaPreguntas();
            cp.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            CajaPreguntas cp = new CajaPreguntas();
            cp.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            CajaPreguntas cp = new CajaPreguntas();
            cp.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            CajaPreguntas cp = new CajaPreguntas();
            cp.Show();
        }
    }
}
