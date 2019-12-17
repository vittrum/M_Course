using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masha_Course.Tables {
    class Client {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Client (string id, string name, string lastname, string patr,
            string phone, string email) {
            Phone = phone;
            ID = id;
            Name = name;
            Lastname = lastname;
            Patronymic = patr;
            Email = email;
        }
    }
}
