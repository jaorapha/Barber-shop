using MySql.Data.MySqlClient;

namespace interdisciplinar2.Models
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;

        protected DbConnection()
        {
            _connectionString = "server=localhost;database=barber_shop2;uid=root;pwd=jhon;";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}