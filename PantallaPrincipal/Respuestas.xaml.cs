using PantallaPrincipal.Datos;
using PantallaPrincipal.Logica;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
    /// Lógica de interacción para Respuestas.xaml
    /// </summary>
    
    //Pantalla de Respuestas con una tabla
    public partial class Respuestas : Window
    {
        //Lista para los datos de la tabla
        public ObservableCollection<Pregunta> ListaPreguntas { get; set; }

        //Constructor con los datos de la tabla
        public Respuestas()
        {
            InitializeComponent();
            ListaPreguntas = new ObservableCollection<Pregunta>();
            ListaPreguntas.Add(new Pregunta(0, "No hay todavía", false, "No hay todavía"));
            ListaPreguntas.Add(new Pregunta(1, "No hay todavía", false, "No hay todavía"));
            this.DataContext = this;
        }

        //Botón para modificar la tabla
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListaPreguntas.ElementAt(1).Respuesta = "Sigue sin haber preguntas";
        }

        //Botones para cambiar de pantallas
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CajaPreguntas cp = new CajaPreguntas();
            cp.Show();
        }

        //Al pasar el ratón por encima del botón le cambia el texto
        private void Button_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            bt_modificar.Content = "Modificame";
        }
    }
}
