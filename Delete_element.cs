using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
	public partial class Delete_element : Form
	{
		public Delete_element()
		{
			InitializeComponent();
		}

		private void Delete_element_Load(object sender, EventArgs e)
		{
			List list = new List();

			List<Exhibitions> exhibitions = list.Exhibitions();
			dataGridView2.DataSource = exhibitions;
			
		}

		
		
		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
			int rowIndex = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].RowIndex;
			if (rowIndex >= 0)
			{
				string city = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
				string title = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
				int adult_price = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());
				int kids_price = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());
				string filter = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();

				DeleteExhibitionFromDatabase(city, title, adult_price, kids_price, filter);

				List list = new List();
				List<Exhibitions> exhibitions = list.Exhibitions();
				dataGridView2.DataSource = exhibitions;
				

			}

		}

		private void DeleteExhibitionFromDatabase(string city, string title, int adult_price, int kids_price, string filter)
		{
			SQLiteConnection connection = new SQLiteConnection("Integrated Security = SSPI; Data Source = Exhibitions.db");
			connection.Open();
			SQLiteCommand command = connection.CreateCommand();
			command.CommandText = "DELETE FROM Exhibitions WHERE City = @City AND Title = @Title AND AdultPrice = @AdultPrice AND KidsPrice = @KidsPrice AND Filter = @Filter";
			command.Parameters.AddWithValue("@City", city);
			command.Parameters.AddWithValue("@Title", title);
			command.Parameters.AddWithValue("@AdultPrice", adult_price);
			command.Parameters.AddWithValue("@KidsPrice", kids_price);
			command.Parameters.AddWithValue("@Filter", filter);
			command.ExecuteNonQuery();
			connection.Close();

		}
		
	}

}
