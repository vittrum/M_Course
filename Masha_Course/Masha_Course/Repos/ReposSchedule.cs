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
    class ReposSchedule {
        private Connection connection;
        public ReposSchedule(Connection connection) {
            this.connection = connection;
        }

        public List<Schedule> Show_Schedules() {
            Schedule schedule;
            List<Schedule> schedules = new List<Schedule>();
            try {
                string QueryString =
                    "select * from schedule_info;";
                NpgsqlCommand Command =
                    new NpgsqlCommand(QueryString, connection.CreateConnection.connection); // Создаем команду из запроса и COnnection
                NpgsqlDataReader dataReader = Command.ExecuteReader(); // Вызываем команду, выполняем ее на стороне базы
                foreach (DbDataRecord dbDataRecord in dataReader) {
                    schedule = new Schedule(
                        dbDataRecord["first_name"].ToString(),
                        dbDataRecord["last_name"].ToString(),
                        dbDataRecord["day"].ToString(),
                        dbDataRecord["start_time"].ToString(),
                        dbDataRecord["end_time"].ToString(),
                        dbDataRecord["service_name"].ToString(),
                        dbDataRecord["type"].ToString());
                    schedules.Add(schedule);
                }
                dataReader.Close();
            }
            catch (PostgresException ex) {
                MessageBox.Show("Ошибка базы данных \n" + Convert.ToString(ex));
            }
            return schedules;
        }
    }
}
