using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Informations
    {
        //login
        public string username { get; set; }
        public string password { get; set; }

        //new student
        public string firstName { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string level { get; set; }
        public string course { get; set; }
        public int studentNumber { get; set; }

        public string operation { get; set; }

    }
}
