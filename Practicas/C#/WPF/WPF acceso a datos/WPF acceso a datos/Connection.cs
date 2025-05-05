using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WPF_acceso_a_datos
{
    public class Connection
    {
        public void Open()
        {
            try
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error: " + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Close() 
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
                _connection.Close();
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }

        private string _connectionString = @"Data source = localhost\SQLEXPRESS; Initial Catalog = SISTEMA_DE_VENTAS_DB; Integrated Security=True;";
        private SqlConnection _connection;

    }
}
