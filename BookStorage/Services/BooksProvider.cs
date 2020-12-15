using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BookStorage.Models;
namespace BookStorage.Services
{
    public class BooksProvider
    {
        private SqlConnection _connection;

        public BooksProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Book> GetAll()
        {
            List<Book> result = new List<Book>();

            try
            {
                _connection.Open();
                var cmd = new SqlCommand(
                    @" SELECT
                            [id],
                            [name],
                            [dateOfRelese],
                            [pages],
                            [fullNameAutor],
                            [genre]
                       FROM [Book]
                     ", _connection);
                using(var reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Book book = new Book
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            DateOfRelese = reader.GetDateTime(2),
                            Pages = reader.GetInt32(3),
                            FullNameAutor = reader.GetString(4),
                            Genre = reader.GetString(5)
                        };
                        result.Add(book);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }

        public bool Insert(Book data)
        {
            bool result = false;
            try
            {
                _connection.Open();
                var cmd = new SqlCommand(
                    @"INSERT INTO [Book]
                           ([name], [dateOfRelese], [pages], [fullNameAutor], [genre])
                      VALUES 
                           (@Name,@DateofRelese,@Pages,@FullNameAutor,@Genre)
                     ", _connection);
                cmd.Parameters.AddWithValue("@Name", data.Name);
                cmd.Parameters.AddWithValue("@DateOfRelese", data.DateOfRelese);
                cmd.Parameters.AddWithValue("@Pages", data.Pages);
                cmd.Parameters.AddWithValue("@FullNameAutor", data.FullNameAutor);
                cmd.Parameters.AddWithValue("@Genre", data.Genre);
                result = cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }
        
        public bool Update(Book data)
        {
            bool result = false;
            try
            {
                _connection.Open();
                var cmd = new SqlCommand(
                    @"  
                        UPDATE [Book]
                        SET
                            [name] = @Name,
                            [dateOfRelese] = @DateOfRelese,
                            [pages] = @Pages,
                            [fullNameAutor] = @FullNameAutor,
                            [genre] = @Genre
                        WHERE [id] =  @Id
                     ", _connection);
                cmd.Parameters.AddWithValue("@Name", data.Name);
                cmd.Parameters.AddWithValue("@DateOfRelese", data.DateOfRelese);
                cmd.Parameters.AddWithValue("@Pages", data.Pages);
                cmd.Parameters.AddWithValue("@FullNameAutor", data.FullNameAutor);
                cmd.Parameters.AddWithValue("@Genre", data.Genre);
                cmd.Parameters.AddWithValue("@Id", data.Id);
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
                    @"
                        DELETE FROM [Book]
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
