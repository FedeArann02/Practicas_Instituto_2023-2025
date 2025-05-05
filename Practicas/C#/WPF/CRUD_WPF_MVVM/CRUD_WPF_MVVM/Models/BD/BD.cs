using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CRUD_WPF_MVVM.Models;
using System.Windows;
using CRUD_WPF_MVVM.Views;

namespace CRUD_WPF_MVVM.Models.BD
{
    internal class BD
    {
        private readonly string _connectionString;
        public string Conexion => _connectionString;

        public BD()
        {
            _connectionString = @"Server=localhost; Database = USERSDB; Trusted_Connection = true";
        }

        internal ObservableCollection<UserModel> Get()
        {
            ObservableCollection<UserModel> listResult = new ObservableCollection<UserModel>();
            string query = "SELECT * FROM Usuarios";

            try
            {
                SqlConnection conexion = new SqlConnection(Conexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listResult.Add(new UserModel()
                    {
                        Id = (int)reader["idUser"],
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Email = reader["Email"].ToString(),
                        Password = reader["Contrasena"].ToString(),
                    });
                }

                reader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return listResult;
        }

        internal void Add(UserModel user)
        {
            string query = "INSERT INTO Usuarios VALUES(@Nombre, @Apellido, @Email, @Contrasena)";
            SqlConnection conexion = new SqlConnection(Conexion);
            conexion.Open();
            SqlTransaction transaction = conexion.BeginTransaction();

            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion, transaction);
                cmd.Parameters.AddWithValue("@Nombre", user.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", user.Apellido);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Contrasena", user.Password);

                cmd.ExecuteNonQuery();
                transaction.Commit();
                conexion.Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        internal void Delete(UserModel user)
        {
            MessageBoxResult dr = new MessageBoxResult();
            dr = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question);
            
            if (dr == MessageBoxResult.No)
            {
                
            }
            else
            {
                string query = "DELETE FROM Usuarios WHERE idUser = @id";
                SqlConnection conexion = new SqlConnection(Conexion);
                conexion.Open();
                SqlTransaction transaction = conexion.BeginTransaction();
                
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conexion, transaction);
                    cmd.Parameters.AddWithValue("@id", user.Id);

                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    conexion.Close();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        internal void Edit(UserModel user)
        {
            MessageBoxResult dr = new MessageBoxResult();
            dr = MessageBox.Show("¿Desea editar este registro?", "Editar", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (dr == MessageBoxResult.No)
            {
                
            }
            else
            {
                string query = "UPDATE Usuarios set Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Contrasena = @Contrasena WHERE idUser = @id";
                SqlConnection conexion = new SqlConnection(Conexion);
                conexion.Open();
                SqlTransaction transaction = conexion.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conexion, transaction);
                    cmd.Parameters.AddWithValue("@id", user.Id);
                    cmd.Parameters.AddWithValue("@Nombre", user.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", user.Apellido);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Contrasena", user.Password);

                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
