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

namespace WPF_DATAB_INDING
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblacion> poblaciones = new List<Poblacion>
            {
                new Poblacion { nombreCiudad1 = "Guernica", temperatura1 = 30, nombreCiudad2 = "San Vicente", temperatura2 = 33, intervalo = 3 },
                new Poblacion { nombreCiudad1 = "Alejandro Korn", temperatura1 = 30, nombreCiudad2 = "Glew", temperatura2 = 34, intervalo = 4 },
                new Poblacion { nombreCiudad1 = "Lanus", temperatura1 = 28, nombreCiudad2 = "Moron", temperatura2 = 30, intervalo = 2 },
                new Poblacion { nombreCiudad1 = "Beccar", temperatura1 = 30, nombreCiudad2 = "Tigre", temperatura2 = 35, intervalo = 5 }
            };  

            LbxListaPoblaciones.ItemsSource = poblaciones;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LbxListaPoblaciones.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un item de la lista","Error",MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show(
                    (LbxListaPoblaciones.SelectedItem as Poblacion).nombreCiudad1 + " " +
                    (LbxListaPoblaciones.SelectedItem as Poblacion).temperatura1 + " grados , " +
                    (LbxListaPoblaciones.SelectedItem as Poblacion).nombreCiudad2 + " " +
                    (LbxListaPoblaciones.SelectedItem as Poblacion).temperatura2 + " grados"
                    );
            }
        }

        private void LbxListaPoblaciones_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(
                (LbxListaPoblaciones.SelectedItem as Poblacion).nombreCiudad1 + " " +
                (LbxListaPoblaciones.SelectedItem as Poblacion).temperatura1 + " grados , " +
                (LbxListaPoblaciones.SelectedItem as Poblacion).nombreCiudad2 + " " +
                (LbxListaPoblaciones.SelectedItem as Poblacion).temperatura2 + " grados"
                );
        }
    }
}
