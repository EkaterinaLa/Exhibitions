using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Contracts;

namespace homework
{
	internal class Query
	{
		public List<Exhibitions> ExhibitionsQuery(List<Exhibitions> exhibitions, string city, string filter)
		{
			List<Exhibitions> exhibitions1 = new List<Exhibitions>(100);
			if (filter == "все выставки" && city == "все города")
			{
				IEnumerable<Exhibitions> Query =
					(from num in exhibitions
					 select num);
				int k = 1;
				foreach (Exhibitions t in Query)
				{
					exhibitions1.Add(t);
					k++;
				}
			}
			if (filter != "все выставки" && city == "все города")
			{
				IEnumerable<Exhibitions> Query =
					(from num in exhibitions
					 where num.Filter == filter
					 select num);
				int k = 1;
				foreach (Exhibitions t in Query)
				{
					exhibitions1.Add(t);
					k++;
				}
			}
			if (filter == "все выставки" && city != "все города")
			{
				IEnumerable<Exhibitions> Query =
					(from num in exhibitions
					 where num.City == city
					 select num);
				int k = 1;
				foreach (Exhibitions t in Query)
				{
					exhibitions1.Add(t);
					k++;
				}
			}
			if (filter != "все выставки" && city != "все города")
			{
				IEnumerable<Exhibitions> Query =
					(from num in exhibitions
					 where num.City == city
					 where num.Filter == filter
					 select num);
				int k = 1;
				foreach (Exhibitions t in Query)
				{
					exhibitions1.Add(t);
					k++;
				}
			}
			return exhibitions1;
		}
	}
}
