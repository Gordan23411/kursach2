using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristCompany.Entities
{
   public class Service
    {
   

        public int id_service { get; internal set; }
		public string Title { get; set; }

		public override string ToString()
        {
            return this.Title;
        }

		public override bool Equals(object obj)
		{
			bool flag = obj is Service;
			bool result;
			if (flag)
			{
				result = ((obj as Service).id_service == this.id_service);
			}
			else
			{
				result = base.Equals(obj);
			}
			return result;
		}

		
		public override int GetHashCode()
		{
			return this.id_service;
		}
	}
}
