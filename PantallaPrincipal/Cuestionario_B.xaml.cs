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
    /// Lógica de interacción para Cuestionario_B.xaml
    /// </summary>
    
    //Clase Cuestionarios de Bachillerato para seleccionar cuestionarios de Bachillerato
    public partial class Cuestionario_B : Window
    {
        public Cuestionario_B()
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
            Cuestionarios_E ce = new Cuestionarios_E();
            ce.Show();
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
    }
}
