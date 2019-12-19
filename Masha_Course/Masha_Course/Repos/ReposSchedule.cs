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

        public void Create_Schedule(string serv, string cli, string room, string day,
            string stime, string etime) {
            try {
                string QueryString = "select create_schedule(@serv, @cli, @room, @day, '" + stime + "','" + etime + "');";
                MessageBox.Show(etime);
                NpgsqlCommand Command =
                    new NpgsqlCommand(QueryString, connection.CreateConnection.connection);
                Command.Parameters.AddWithValue("@cli", Convert.ToInt32(cli));
                Command.Parameters.AddWithValue("@serv", Convert.ToInt32(serv));
                Command.Parameters.AddWithValue("@room", Convert.ToInt32(room));
                Command.Parameters.AddWithValue("@day", day);

                try {
                    Command.ExecuteNonQuery();
                }
                catch (Exception e) {
                    MessageBox.Show("Ошибка выполнения операции. \nПроверьте корректность введенных данных" + e.ToString());
                }
            }
            catch (Exception e) {
                MessageBox.Show("Ошибка выполнения операции." + e.ToString());
            }
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
