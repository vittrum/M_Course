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
    class ReposEmployee {
        private Connection connection;
        public ReposEmployee(Connection connection) {
            this.connection = connection;
        }
        public List<Employee> GetEmployees() {
            Employee employee;
            List<Employee> employees = new List<Employee>();
            try {
                string QueryString =
                    "select * from employee;";
                NpgsqlCommand Command =
                    new NpgsqlCommand(QueryString, connection.CreateConnection.connection); // Создаем команду из запроса и COnnection
                NpgsqlDataReader dataReader = Command.ExecuteReader(); // Вызываем команду, выполняем ее на стороне базы
                foreach (DbDataRecord dbDataRecord in dataReader) {
                    employee = new Employee(
                        dbDataRecord["employee_id"].ToString(),
                        dbDataRecord["passport_number_and_series"].ToString(),
                        dbDataRecord["first_name"].ToString(),
                        dbDataRecord["last_name"].ToString(),
                        dbDataRecord["patronymic"].ToString(),
                        dbDataRecord["phone_number"].ToString(),
                        dbDataRecord["email"].ToString());
                    employees.Add(employee);
                }
                dataReader.Close();
            }
            catch (PostgresException ex) {
                MessageBox.Show("Ошибка базы данных \n" + Convert.ToString(ex));
            }
            return employees;
        }

        public void AddEmployee(
            string pass, 
            string fname,
            string lname,
            string patr,
            string phone,
            string mail,
            string pos,
            string iss_date,
            string exp_date,
            string serv_name) {
            try {
                string QueryString =
                    "select create_employee (@pass, @fname, @lname, @patr, @phone, @mail, @pos, '"+iss_date+"', '"+exp_date+"', @serv_name);";
                NpgsqlCommand Command =
                    new NpgsqlCommand(QueryString, connection.CreateConnection.connection);
                Command.Parameters.AddWithValue("@pass", pass);
                Command.Parameters.AddWithValue("@fname", fname); // Подстановка в строку значений
                Command.Parameters.AddWithValue("@lname", lname);
                Command.Parameters.AddWithValue("@patr", patr);
                Command.Parameters.AddWithValue("@phone", phone);
                Command.Parameters.AddWithValue("@mail", mail);
                Command.Parameters.AddWithValue("@pos", pos);
                Command.Parameters.AddWithValue("@serv_name", serv_name);
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

        public void FreeEmployee (string emp_id) {

        }
    }
}
