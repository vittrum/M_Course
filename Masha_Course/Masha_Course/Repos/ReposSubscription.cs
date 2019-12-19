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
    class ReposSubscription {
        private Connection connection;
        public ReposSubscription(Connection connection) {
            this.connection = connection;
        }

        public void AddSubscriprion(string cli_id, string sub_type, string idate, string edate) {
            try {
                string QueryString = "select create_subscription(@cid, @ctype, '"+idate+"','"+edate+"');";
                //MessageBox.Show(cli_id);
                NpgsqlCommand Command =
                    new NpgsqlCommand(QueryString, connection.CreateConnection.connection);
                Command.Parameters.AddWithValue("@cid", Convert.ToInt32(cli_id));
                Command.Parameters.AddWithValue("@ctype", sub_type);

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
