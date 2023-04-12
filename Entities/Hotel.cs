using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristCompany.Entities
{
   public class Hotel
    {
		public string Name { get; set; }
		public string City { get; set; }
		public string Information { get; set; }
		public int Rating { get; set; }

		public int id_hotel { get; internal set; }
        public List<Service> _hotelServices { get; internal set; }
        public Country _Country { get; internal set; }
		public string HotelServices
		{
			get
			{
				string text = string.Empty;
				int num = 0;
				foreach (Service service in this._hotelServices)
				{
					bool flag = num == 0;
					if (flag)
					{
						text = text + service + " ";
					}
					else
					{
						text = text + ", " + service;
					}
					num++;
				}
				return text;
			}
		}
		public override string ToString()
		{
			return this.Name;
		}

		public override bool Equals(object obj)
		{
			bool flag = obj is Hotel;
			return flag && (obj as Hotel).id_hotel == this.id_hotel;
		}

	
		public override int GetHashCode()
		{
			return this.id_hotel;
		}
	}
}
