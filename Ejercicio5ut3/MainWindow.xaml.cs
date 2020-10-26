using System.Windows;
using System.Windows.Controls;

namespace Ejercicio5ut3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string textoAnterior = texto.Text;
            texto.Text = textoAnterior+(sender as Button).Tag.ToString();
        }
    }
}
