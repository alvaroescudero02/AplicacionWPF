using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PantallaPrincipal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    //Pantalla Principal
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Botones para ir a otras pantallas
        private void bt_perfil_Click(object sender, RoutedEventArgs e)
        {
            Perfil pf = new Perfil();
            pf.ShowDialog();
        }

        private void bt_cuest1_Click(object sender, RoutedEventArgs e)
        {
            CajaPreguntas cp = new CajaPreguntas();
            cp.Show();
        }

        private void bt_cuest2_Click(object sender, RoutedEventArgs e)
        {
            CajaPreguntas cp = new CajaPreguntas();
            cp.Show();
        }

        private void bt_cuest3_Click(object sender, RoutedEventArgs e)
        {
            CajaPreguntas cp = new CajaPreguntas();
            cp.Show();
        }

        private void bt_cuest4_Click(object sender, RoutedEventArgs e)
        {
            CajaPreguntas cp = new CajaPreguntas();
            cp.Show();
        }

        private void bt_cuest5_Click(object sender, RoutedEventArgs e)
        {
            CajaPreguntas cp = new CajaPreguntas();
            cp.Show();
        }

        private void bt_cuest6_Click(object sender, RoutedEventArgs e)
        {
            CajaPreguntas cp = new CajaPreguntas();
            cp.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cuestionarios_P cp = new Cuestionarios_P();
            cp.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Cuestionarios_E ce = new Cuestionarios_E();
            ce.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Cuestionario_B cb = new Cuestionario_B();
            cb.Show();
        }
    }
}
