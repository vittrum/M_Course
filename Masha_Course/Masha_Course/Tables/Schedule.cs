using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masha_Course.Tables {
    class Schedule {
        public string Name { get; set; }
        public string Lname { get; set; }
        public string Day { get; set; }
        public string Stime { get; set; }
        public string Etime { get; set; }
        public string Serv { get; set; }
        public string Type { get; set; }

        public Schedule(string name, string lname, string day,
            string stime, string etime, string serv, string type) {
            Name = name;
            Lname = lname;
            Day = day;
            Stime = stime;
            Etime = etime;
            Serv = serv;
            Type = type;
        }
    }
}
