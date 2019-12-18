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
    class ReposPositions {
        private Connection connection;
        public ReposPositions(Connection connection) {
            this.connection = connection;
        }

        public List<Positions> GetPositionsNames() {
            Positions position;
            List<Positions> positions = new List<Positions>();
            try {
                string QueryString =
                    "select position_name from position;";
                NpgsqlCommand Command =
                    new NpgsqlCommand(QueryString, connection.CreateConnection.connection); // Создаем команду из запроса и COnnection
                NpgsqlDataReader dataReader = Command.ExecuteReader(); // Вызываем команду, выполняем ее на стороне базы
                foreach (DbDataRecord dbDataRecord in dataReader) {
                    position = new Positions(
                        dbDataRecord["position_name"].ToString());
                    positions.Add(position);
                }
                dataReader.Close();
            }
            catch (PostgresException ex) {
                MessageBox.Show("Ошибка базы данных \n" + Convert.ToString(ex));
            }
            return positions;
        }
    }
}
