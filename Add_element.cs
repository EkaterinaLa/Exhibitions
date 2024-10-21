using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity.Core.Common.CommandTrees;

namespace homework
{
	public partial class Add_element : Form
	{
		public Add_element()
		{
			InitializeComponent();
		}

		public string city;
		public string title;
		public int adultPrice;
		public int kidsPrice;
		public string filter;



		private void Add_element_Load(object sender, EventArgs e)
		{
			List list = new List();
			List<Exhibitions> exhibitions = list.Exhibitions();

			dataGridView1.DataSource = exhibitions;


		}

		private void Choose_city_SelectedIndexChanged(object sender, EventArgs e)
		{
			city = Choose_city.Text;
		}

		private void Add_title_TextChanged(object sender, EventArgs e)
		{
			title = Add_title.Text;
		}

		private void Add_AdultPrice_TextChanged(object sender, EventArgs e)
		{
			adultPrice = int.Parse(Add_AdultPrice.Text);
		}

		private void Add_KidsPrice_TextChanged(object sender, EventArgs e)
		{
			kidsPrice = int.Parse (Add_KidsPrice.Text);
		}

		private void Choose_Filter_SelectedIndexChanged(object sender, EventArgs e)
		{
			filter = Choose_Filter.Text;
		}

		private void Add_Button_Click(object sender, EventArgs e)
		{
			SQLiteConnection connection = new SQLiteConnection("Integrated Security = SSPI; Data Source = Exhibitions.db");
			connection.Open();
			var command = connection.CreateCommand();
			command.CommandText = "INSERT INTO Exhibitions(City, Title, AdultPrice, KidsPrice, Filter) VALUES (:City, :Title, :AdultPrice, :KidsPrice, :Filter)";
			command.Parameters.AddWithValue("City", city);
			command.Parameters.AddWithValue("Title", title);
			command.Parameters.AddWithValue("AdultPrice", adultPrice);
			command.Parameters.AddWithValue("KidsPrice", kidsPrice);
			command.Parameters.AddWithValue("Filter", filter);
			command.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Данные внесены");
			List list = new List();
			List<Exhibitions> exhibitions = list.Exhibitions();

			dataGridView1.DataSource = exhibitions;
		}

		
	}
}
