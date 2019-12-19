using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Npgsql;
using System.Windows.Forms;
using Masha_Course.Tables;

namespace Masha_Course.Repos {
    class ReposSubType {
        private Connection connection;
        public ReposSubType(Connection connection) {
            this.connection = connection;
        }

        public List<SubType> GetSubTypes() {
            SubType type;
            List<SubType> types = new List<SubType>();
            try {
                string QueryString =
                    "select type from subscription_type;";
                NpgsqlCommand Command =
                    new NpgsqlCommand(QueryString, connection.CreateConnection.connection); // Создаем команду из запроса и COnnection
                NpgsqlDataReader dataReader = Command.ExecuteReader(); // Вызываем команду, выполняем ее на стороне базы
                foreach (DbDataRecord dbDataRecord in dataReader) {
                    type = new SubType(
                        dbDataRecord["type"].ToString());
                    types.Add(type);
                }
                dataReader.Close();
            }
            catch (PostgresException ex) {
                MessageBox.Show("Ошибка базы данных \n" + Convert.ToString(ex));
            }
            return types;
        }
    }
}
