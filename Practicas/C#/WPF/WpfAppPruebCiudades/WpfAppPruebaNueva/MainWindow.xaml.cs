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

namespace WpfAppPruebaNueva
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ListCiudades = new List<Ciudades>()
            {
                new Ciudades{ NombreCiudad = "Alejandro Korn"},
                new Ciudades{ NombreCiudad = "San vicente"},
                new Ciudades{ NombreCiudad = "Guernica"},
                new Ciudades{ NombreCiudad = "Glew"}
            };

            cmbCiudades.ItemsSource = ListCiudades;
        }

        private void cbxPaises_Checked(object sender, RoutedEventArgs e)
        {

            CheckBox[] cbxs = new CheckBox[] {chkbx1, chkbx2, chkbx3, chkbx4};

            foreach (CheckBox cbx in cbxs)
            {
               cbx.IsChecked = true;
            }
        }

        private void cbxPaises_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox[] cbxs = new CheckBox[] { chkbx1, chkbx2, chkbx3, chkbx4 };

            foreach (CheckBox cbx in cbxs)
            {
                cbx.IsChecked = false;
            }
        }

        private void IndividualChecked(object sender, RoutedEventArgs e)
        {
            CheckBox[] cbxs = new CheckBox[] { chkbx1, chkbx2, chkbx3, chkbx4 };
            bool ActiveAll = false;

            foreach (CheckBox cbx in cbxs)
            {

                if (chkbx1.IsChecked == false && chkbx2.IsChecked == false && chkbx3.IsChecked == false && chkbx4.IsChecked == false) cbxPaises.IsChecked = false;
                else if (cbx.IsChecked == true) ActiveAll = true;
                else
                {
                    ActiveAll = false;
                    cbxPaises.IsChecked = null;
                    break;
                }
            }

            if (ActiveAll) cbxPaises.IsChecked = true;

        }


        List<Ciudades> ListCiudades = new List<Ciudades>();

    }

    public class Ciudades
    {
        public string NombreCiudad { get; set; }
    }
}
