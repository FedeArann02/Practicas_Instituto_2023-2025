using CRUD_WPF_MVVM.Models;
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

namespace CRUD_WPF_MVVM.Views
{
    /// <summary>
    /// Lógica de interacción para RecordsView.xaml
    /// </summary>
    public partial class RecordsView : UserControl
    {
        public RecordsView()
        {
            InitializeComponent();
        }

        private void listUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listUsers.SelectedItem is UserModel selectedUser)
            {
                txtId.Text = selectedUser.Id.ToString();
                txtNombre.Text = selectedUser.Nombre;
                txtApellido.Text = selectedUser.Apellido;
                txtEmail.Text = selectedUser.Email;
                txtContrasena.Text = selectedUser.Password;
                btnEliminar.Visibility = Visibility.Visible;
                btnEditar.Visibility = Visibility.Visible;
            }
            else
            {
                btnEliminar.Visibility = Visibility.Hidden;
                btnEditar.Visibility = Visibility.Hidden;
            }
        }

    }
}
