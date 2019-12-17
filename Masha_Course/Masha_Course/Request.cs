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
    }
}
