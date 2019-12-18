using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masha_Course.Tables {
    class Employee {
        public string Id { get; set; }
        public string Pass { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Patr { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

        public Employee(string id, string pass, string name, 
            string sname, string patr, string phone, string mail) {
            Id = id;
            Pass = pass;
            FName = name;
            LName = sname;
            Patr = patr;
            Phone = phone;
            Mail = mail;
        }
    }
}
