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
            requester.FillPositions(factory, comboEmpPos);
            requester.FillSubTypes(factory, comboSubType);
        }
        Request requester = new Request();
        Factory factory = new Factory("127.0.0.1", "5432", "postgres", "1", "masha");
        private void BtnCreateClient_Click(object sender, EventArgs e) {
            requester.Create_Client();
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

        public void fillDgvEmp() {
            dgvShowEmployee.Columns.Clear();
            dgvShowEmployee.Columns.Add("id", "Id");
            dgvShowEmployee.Columns.Add("name", "Name");
            dgvShowEmployee.Columns.Add("lname", "Last name");
            dgvShowEmployee.Columns.Add("patr", "Patronymic");
            dgvShowEmployee.Columns.Add("mail", "Email");
            dgvShowEmployee.Columns.Add("phone", "Phone");
            dgvShowEmployee.Columns.Add("pass", "Pass");
        }
        public void fillDgvSchedule() {
            dgvShowSchedule.Columns.Clear();
            dgvShowSchedule.Columns.Add("fname", "Name");
            dgvShowSchedule.Columns.Add("lname", "LastName");
            dgvShowSchedule.Columns.Add("day", "day");
            dgvShowSchedule.Columns.Add("stime", "start time");
            dgvShowSchedule.Columns.Add("etime", "end time");
            dgvShowSchedule.Columns.Add("sname", "service name");
            dgvShowSchedule.Columns.Add("type", "type");
        }

        #endregion

        private void btnEmpCreate_Click(object sender, EventArgs e) {
            requester.Create_Employee(factory, tbEmpPass.Text,
                tbEmpFname.Text, tbEmpLname.Text, tbEmpPatr.Text, tbEmpPhone.Text,
                tbEmpMail.Text, comboEmpPos.SelectedItem.ToString(), dateEmpIss.Value.ToShortDateString(),
                dateEmpExp.Value.ToShortDateString(), tbEmpService.Text);
        }

        private void btnShowEmp_Click(object sender, EventArgs e) {
            fillDgvEmp();
            requester.Show_Employee(factory, dgvShowEmployee);
        }

        private void btnFireEmp_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in dgvShowEmployee.SelectedRows) {
                requester.Fire_Employee(factory, row.Cells["id"].Value.ToString());
                dgvShowEmployee.Rows.Remove(row);
            }
        }

        private void btnAddServ_Click(object sender, EventArgs e) {
            requester.Add_Service(factory, tbEmpId.Text, tbServName.Text);
        }

        private void btnShowClients_Click_1(object sender, EventArgs e) {
            fillDgvClient();
            requester.Show_Client(factory, dgvShowClients);
        }

        private void btnCreateSub_Click(object sender, EventArgs e) {
            requester.Add_Subcription(factory, tbSubCliId.Text, comboSubType.SelectedItem.ToString(),
                dateSubIss.Value.ToShortDateString(), dateSubExp.Value.ToShortDateString());
        }

        private void bnShowSchedule_Click(object sender, EventArgs e) {
            fillDgvSchedule();
            requester.Show_Schedule(factory, dgvShowSchedule);
        }

        private void btnCreateSchedule_Click(object sender, EventArgs e) {

        }
    }
}
