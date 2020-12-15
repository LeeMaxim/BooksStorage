using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BookStorage.Services
{
    public class StorageContext
    {
        public UserProvider userProvider { get; private set; }
        public BooksProvider booksProvider { get; private set; }
        public AutorisationProvider AutorisationProvider { get; set; }

        public StorageContext()
        {
            var connection = CreateConnection();
            userProvider = new UserProvider(connection);
            AutorisationProvider = new AutorisationProvider(userProvider);
            booksProvider = new BooksProvider(connection);
        }


        public SqlConnection CreateConnection()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = @"DESKTOP-CBJQR0G",
                InitialCatalog = "BooksStorage",
                IntegratedSecurity = true
            };

            var stringConnection = builder.ToString();

            return new SqlConnection(stringConnection);
        }
    }
}
