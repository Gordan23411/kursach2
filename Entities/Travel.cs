using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristCompany.Entities
{
    public class Travel
    {
       

        public decimal CostTour { get; internal set; }
        public DateTime DateOfIssue { get; internal set; }
        public decimal DiscountedPrice { get; internal set; }
        public decimal Fare { get; internal set; }
        public Tourist Tourist_ { get; internal set; }
        public Employee Employee_ { get; internal set; }
        public Tour Tour { get; internal set; }
        public int id_travel { get; internal set; }
    }
}
