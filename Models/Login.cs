using MySql.Data.MySqlClient;

namespace interdisciplinar2.Models
{
    public class Login : DbConnection
    {
        public bool AuthenticateUser(string userName, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                MySqlDataReader reader = null;

                using (MySqlCommand command = new MySqlCommand($"SELECT barbers.full_name, barbers.`password` FROM barbers WHERE barbers.full_name = @NomeBarbeiro AND barbers.`password` = @SenhaBarbeiro;", connection))
                {
                    command.Parameters.AddWithValue("@NomeBarbeiro", userName);
                    command.Parameters.AddWithValue("@SenhaBarbeiro", password);

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string user = reader.GetString("full_name");

                        string userPassword = reader.GetString("password");

                        if (userName == user && password == userPassword)
                        {
                            return true;
                        }
                    }
                    reader.Close();
                }
            }
            return false;
        }
    }
}