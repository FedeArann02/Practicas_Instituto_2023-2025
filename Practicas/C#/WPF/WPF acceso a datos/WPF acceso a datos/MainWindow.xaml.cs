using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace WPF_acceso_a_datos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListarArticulos();
        }

        public void ListarArticulos()
        {
            string query = "SELECT * FROM ARTICULO";
            conn.Open();
            

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn.GetConnection()))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                ListaArticulos.DisplayMemberPath = "Descripcion";
                ListaArticulos.SelectedValuePath = "Cod_articulo";
                ListaArticulos.ItemsSource = dt.DefaultView;
            }

            conn.Close();
        }

        public void EliminarArticulos()
        {
            StringBuilder query = new StringBuilder();
            query.AppendLine("DELETE from STOCK WHERE Cod_articulo = @Cod");
            query.AppendLine("DELETE from ARTICULO WHERE Cod_articulo = @Cod");
            conn.Open();

            SqlCommand cmd = new SqlCommand(query.ToString(), conn.GetConnection());

            cmd.Parameters.AddWithValue("@Cod", ListaArticulos.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Articulo eliminado correctamente");

            conn.Close();
            ListarArticulos();
        }


        Connection conn = new Connection();

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            EliminarArticulos();
        }
    }
}
