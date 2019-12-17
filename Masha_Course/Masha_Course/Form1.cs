using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masha_Course {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        Request requester = new Request();
        Factory factory = new Factory("127.0.0.1", "5432", "postgres", "1", "fitness");
        private void BtnCreateClient_Click(object sender, EventArgs e) {
            requester.Create_Client();
        }

        private void BtnShowClients_Click(object sender, EventArgs e) {
            fillDgvClient();
            requester.Show_Client(factory, dgvShowClients);
        }

        #region Filler
        public void fillDgvClient() {
            dgvShowClients.Columns.Clear();
            dgvShowClients.Columns.Add("id", "Id");
            dgvShowClients.Columns.Add("name", "Name");
            dgvShowClients.Columns.Add("lname", "Last name");
            dgvShowClients.Columns.Add("patr", "Patronymic");
            dgvShowClients.Columns.Add("mail", "Email");
            dgvShowClients.Columns.Add("phone", "Phone");
        }


        #endregion
    }
}
