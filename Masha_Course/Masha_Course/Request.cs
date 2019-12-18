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
        public void Show_Client(Factory factory, DataGridView dgv) {
            foreach (var i in factory.client.GetClients())
                dgv.Rows.Add(i.ID, i.Name, i.Lastname, i.Patronymic, i.Email, i.Phone);
        }

        public void Create_Employee(Factory factory, string pass, string fname, 
            string lname, string patr, string phone, string mail, string pos, 
            string idate, string edate, string sname) {
            factory.employee.AddEmployee(pass, fname, lname, patr, phone, mail, pos,
                idate, edate, sname);
        }

        #region ComboFill
        public void FillPositions(Factory factory, ComboBox combo) {
            foreach (var i in factory.positions.GetPositionsNames())
                combo.Items.Add(i.Name);
        }
        #endregion
    }
}
