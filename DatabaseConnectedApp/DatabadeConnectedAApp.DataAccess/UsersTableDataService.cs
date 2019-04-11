using DatabaseConnectedApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabadeConnectedAApp.DataAccess
{
    public class UsersTableDataService
    {
        private readonly string _connectionString;

        public UsersTableDataService()
        {
            _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ГалеевР\source\repos\DatabaseConnectedApp\DatabadeConnectedAApp.DataAccess\Database.mdf;Integrated Security=True";
        }

        public List<User> GetAllUsers()
        {
            var data = new List<User>();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand ())
            {
                try
                {
                    connection.Open();
                    command.CommandText = "select * from Users";

                    var sqlDataReader = command.ExecuteReader();
                    while(sqlDataReader.Read())
                    {
                        int id = (int)sqlDataReader["Id"];
                        string login = sqlDataReader["Login"].ToString();
                        string password = sqlDataReader["Password"].ToString();
                        data.Add(new User
                        {
                            Id = id,
                            Login = login,
                            Password = password
                        });
                    }
                    sqlDataReader.Close();
                }
                catch (SqlException exeption)
                {
                    //TODO обработка решений
                    throw;
                }
                catch (Exception exeptoin)
                {
                    //TODO обработка решений
                    throw;
                }
            }
            return data;
        }
        public void AddUser(User user)
        {

        }
        public void DeleteUserById(int id)
        {

        }
        public void UpdateUser(User user)
        {

        }
          
    }
}
