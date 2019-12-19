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
    class ReposService {
        private Connection connection;
        public ReposService(Connection connection) {
            this.connection = connection;
        }

        public void AddService(string emp_id, string name) {
            try {
                string QueryString = "select create_service(@id, @name);";
                MessageBox.Show(emp_id);
                NpgsqlCommand Command =
                    new NpgsqlCommand(QueryString, connection.CreateConnection.connection);
                Command.Parameters.AddWithValue("@id", Convert.ToInt32(emp_id));
                Command.Parameters.AddWithValue("@name", name);

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
    }
}
