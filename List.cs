using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
	internal class List
	{
		public List<Exhibitions> Exhibitions()
		{
			List<Exhibitions> exhibitions = new List<Exhibitions>(100);
			SQLiteConnection connection = new SQLiteConnection("Integrated Security = SSPI; Data Source = Exhibitions.db");
			connection.Open();
			var command = connection.CreateCommand();
			command.CommandText = @"SELECT  City, Title, AdultPrice, KidsPrice, Filter FROM Exhibitions";
			using (var rd1 = command.ExecuteReader())
			{
				while (rd1.Read())
				{
					exhibitions.Add(new Exhibitions(rd1.GetString(0), rd1.GetString(1), rd1.GetInt32(2), rd1.GetInt32(3), rd1.GetString(4)));
				}

			}
			connection.Close();
			return exhibitions;
		}
	}
}
