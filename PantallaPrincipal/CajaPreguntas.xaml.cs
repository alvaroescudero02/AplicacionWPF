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
    /// Lógica de interacción para CajaPreguntas.xaml
    /// </summary>
    
    //Clase caja de preguntas donde se hacen los cuestionarios
    public partial class CajaPreguntas : Window
    {
        public CajaPreguntas()
        {
            InitializeComponent();
        }

        //Botones para pasar a los resultados de la pregunta
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Respuestas rp = new Respuestas();
            rp.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Respuestas rp = new Respuestas();
            rp.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Respuestas rp = new Respuestas();
            rp.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Respuestas rp = new Respuestas();
            rp.Show();
        }
    }
}
