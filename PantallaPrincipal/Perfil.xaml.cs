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
    /// Lógica de interacción para Perfil.xaml
    /// </summary>
    
    //Pantalla Perfil donde vess tus datos como usuario
    public partial class Perfil : Window
    {
        
        public Perfil()
        {
            InitializeComponent();
        }

        //Botones para ir a otras pantallas
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Inicio_sesion iss = new Inicio_sesion();
            iss.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
