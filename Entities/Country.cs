using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristCompany.Entities
{
    public class Country
    {
        public int country_id { get; internal set; }
        public string Name { get; internal set; }

        public override string ToString()
        {
            return this.Name;
        }
		public override bool Equals(object obj)
		{
			bool flag = obj is Country;
			bool result;
			if (flag)
			{
				result = ((obj as Country).country_id == this.country_id);
			}
			else
			{
				result = base.Equals(obj);
			}
			return result;
		}

		
		public override int GetHashCode()
		{
			return this.country_id;
		}

	}
}
