using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristCompany.Entities
{
    public class Tourist
    {
        public string FName { get; internal set; }
        public string Email { get; internal set; }
        public int ID_Tourist { get; internal set; }
        public string LName { get; internal set; }
        public string PassportData { get; internal set; }
        public string Phone { get; internal set; }

        public override string ToString()
        {
            return this.FName + " " + this.LName;
        }
        public override bool Equals(object obj)
        {
            bool flag = obj is Tourist;
            return flag && (obj as Tourist).ID_Tourist == this.ID_Tourist;
        }

        // Token: 0x06000200 RID: 512 RVA: 0x0001A014 File Offset: 0x00018214
        public override int GetHashCode()
        {
            return this.ID_Tourist;
        }
    }
}
