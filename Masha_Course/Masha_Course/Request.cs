using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masha_Course {
    class Request {
        // Presenter
        public void Create_Client() {

        }
        // Показать клиентов
        public void Show_Client(Factory factory, DataGridView dgv) {
            foreach (var i in factory.client.GetClients())
                dgv.Rows.Add(i.ID, i.Name, i.Lastname, i.Patronymic, i.Email, i.Phone);
        }
        // Добавить сотрудника
        public void Create_Employee(Factory factory, string pass, string fname, 
            string lname, string patr, string phone, string mail, string pos, 
            string idate, string edate, string sname) {
            factory.employee.AddEmployee(pass, fname, lname, patr, phone, mail, pos,
                idate, edate, sname);
        }
        // Показать сотрудника
        public void Show_Employee(Factory factory, DataGridView dgv) {
            foreach (var i in factory.employee.GetEmployees())
                dgv.Rows.Add(i.Id, i.FName, i.LName, i.Patr, i.Phone, i.Mail, i.Pass);
        }
        // Уволить сотрудника
        public void Fire_Employee(Factory factory, string id) {
            factory.employee.FreeEmployee(id);
        }

        public void Add_Service(Factory factory, string emp_id, string name) {
            factory.service.AddService(emp_id, name);
        }
        public void Add_Subcription(Factory factory, string cli_id, string type, string idate, string edate) {
            factory.sub.AddSubscriprion(cli_id, type, idate, edate);
        }
        public void Show_Schedule(Factory factory, DataGridView dgv) {
            foreach (var i in factory.schedule.Show_Schedules())
                dgv.Rows.Add(i.Name, i.Lname, i.Day, i.Stime, i.Etime, i.Serv, i.Type);
        }
        //public void Cre
        #region ComboFill
        public void FillPositions(Factory factory, ComboBox combo) {
            foreach (var i in factory.positions.GetPositionsNames())
                combo.Items.Add(i.Name);
        }

        public void FillSubTypes(Factory factory, ComboBox combo) {
            foreach (var i in factory.type.GetSubTypes()) {
                combo.Items.Add(i.Type);
            }
        }
        #endregion
    }
}
