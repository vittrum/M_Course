using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Masha_Course.Tables;
using Npgsql;
using System.Data.Common;
using System.Windows.Forms;

namespace Masha_Course.Repos {
    class ReposClient {
        private Connection connection;
        public ReposClient(Connection connection) {
            this.connection = connection;
        }

        public List<Client> GetClients() {
            Client client;
            List<Client> clients = new List<Client>();
            try {
                string QueryString =
                    "select * from client;";
                NpgsqlCommand Command =
                    new NpgsqlCommand(QueryString, connection.CreateConnection.connection); // Создаем команду из запроса и COnnection
                NpgsqlDataReader dataReader = Command.ExecuteReader(); // Вызываем команду, выполняем ее на стороне базы
                foreach (DbDataRecord dbDataRecord in dataReader) {
                    client = new Client(
                        dbDataRecord["client_id"].ToString(),
                        dbDataRecord["first_name"].ToString(),
                        dbDataRecord["last_name"].ToString(),
                        dbDataRecord["patronymic"].ToString(),
                        dbDataRecord["phone_number"].ToString(),
                        dbDataRecord["email"].ToString());
                    clients.Add(client);
                }
                dataReader.Close();
            }
            catch (PostgresException ex) {
                MessageBox.Show("Ошибка базы данных \n" + Convert.ToString(ex));
            }
            return clients;
        }

        public void AddClient(string name, string lname, string patr, string phone, string mail) {
            try {
                string QueryString =
                    "select create_client (@name, @lname, @patr, @phone, @mail);";
                NpgsqlCommand Command =
                    new NpgsqlCommand(QueryString, connection.CreateConnection.connection);
                Command.Parameters.AddWithValue("@name", name); // Подстановка в строку значений
                Command.Parameters.AddWithValue("@lname", lname);
                Command.Parameters.AddWithValue("@patr", patr);
                Command.Parameters.AddWithValue("@phone", phone);
                Command.Parameters.AddWithValue("@mail", mail);
                
                try {
                    Command.ExecuteNonQuery(); // NonQuery = нас не интересует возвращаемое значение, потому nonquery
                }
                catch (PostgresException ex) {
                    MessageBox.Show("Проверьте корректность ввода pg.\n" + ex.Message);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Проверьте корректность ввода.\n " + ex.Message);
            }
        }

    }
}
