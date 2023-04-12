using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristCompany.Entities
{
    public class Employee
    {
        public string Phone { get; internal set; }
        public int ID_Employee { get; internal set; }
        public string Email { get; internal set; }
        public string FName { get; internal set; }
        public string LName { get; internal set; }
        public string PassportData { get; internal set; }
        public override string ToString()
        {
            return this.FName + " " + this.LName;
        }
    }
}
