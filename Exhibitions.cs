using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
	internal class Exhibitions
	{
		private string city;
		private string title;
		private int adult_price;
		private int kids_price;
		private string filter;

		public Exhibitions(string city, string title, int adult_price, int kids_price, string filter)
		{
			this.city = city;
			this.title = title;
			this.adult_price = adult_price;
			this.kids_price = kids_price;
			this.filter = filter;
		}

		public Exhibitions() 
		{ 
		}

		public string City { get => city; set => city = value; }
		public string Title { get => title; set => title = value; }
		public int AdultPrice { get => adult_price; set => adult_price = value; }
		public int KidsPrice { get => kids_price; set => kids_price = value; }
		public string Filter { get => filter; set => filter = value; }
	}
}
