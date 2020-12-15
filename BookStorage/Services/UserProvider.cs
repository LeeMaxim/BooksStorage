using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BookStorage.Models;
namespace BookStorage.Services
{
    public class UserProvider
    {
        private SqlConnection _connection;

        public UserProvider(SqlConnection connection)
        {
            _connection = connection;
        }


        public User Get(string login)
        {
            User result = null;

            try
            {
                _connection.Open();
                var cmd = new SqlCommand(
                    @" SELECT * FROM [User]
                       WHERE [login] = @Login
                     ", _connection);

                cmd.Parameters.AddWithValue("@Login", login);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User
                        {
                            Id = reader.GetInt32(0),
                            Role = reader.GetString(1),
                            Login = reader.GetString(2),
                            Password = reader.GetString(3)
                        };
                        result = user;
                    }
                }
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }
        public bool Insert(User data)
        {
            bool result = false;
            try
            {
                _connection.Open();
                var cmd = new SqlCommand(
                    @" INSERT INTO [User] 
                            ([role],[login],[password])
                       VALUES 
                            (@Role, @Login, @Password)
                     ", _connection);
                cmd.Parameters.AddWithValue("@Role", data.Role);
                cmd.Parameters.AddWithValue("@Login", data.Login);
                cmd.Parameters.AddWithValue("@Password", data.Password);
                result = cmd.ExecuteNonQuery() > 0;

            }
            finally
            {
                _connection.Close();
            }
            return result;
        }
        public bool Update(int id, User data)
        {
            bool result = false;
            try
            {
                _connection.Open();
                var cmd = new SqlCommand(
                    @" UPDATE [User]
                       SET 
                          [role] = @Role,
                          [login] = @Login,
                          [password] = @Password
                       WHERE [id] = @Id
                     ", _connection);
                cmd.Parameters.AddWithValue("@Role", data.Role);
                cmd.Parameters.AddWithValue("@Login", data.Login);
                cmd.Parameters.AddWithValue("@Password", data.Password);
                cmd.Parameters.AddWithValue("@Id", id);
                result = cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }
        public bool Delete(int id)
        {
            bool result = false;
            try
            {
                _connection.Open();
                var cmd = new SqlCommand(
                    @" DELETE FROM [User]
                       WHERE [id] = @Id
                     ", _connection);
                cmd.Parameters.AddWithValue("@Id", id);
                result = cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }
    }
    
}
