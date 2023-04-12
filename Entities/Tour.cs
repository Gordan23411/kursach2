using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristCompany.Entities
{
    public class Tour
    {
        public DateTime DateBegin { get; internal set; }
        public string Information { get; internal set; }
        public DateTime DateEnd { get; internal set; }
        public int Seats { get; internal set; }
        public decimal Price { get; internal set; }
        public string TourName { get; internal set; }
        public Country _Country { get; internal set; }
        public int tour_id { get; internal set; }
        public Hotel _Hotel { get; set; }

        public override string ToString()
        {
            return this.TourName;
        }

        public override bool Equals(object obj)
        {
            bool flag = obj is Tour;
            return flag && (obj as Tour).tour_id == this.tour_id;
        }

        // Token: 0x060001F2 RID: 498 RVA: 0x00019F44 File Offset: 0x00018144
        public override int GetHashCode()
        {
            return this.tour_id;
        }

    }
}
