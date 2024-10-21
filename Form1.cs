using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			

		}

		private string city_name;
		private string filter_name;

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			city_name = ChooseCity.Text;
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			filter_name = ChooseFilter.Text;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ShowInfoTextBox.Clear();
			Query query = new Query();
			List list = new List();
			List<Exhibitions> exhibitions = list.Exhibitions();
			ShowCityTextBox.Text = $"Выставки по городу {city_name} в категории {filter_name}";
			List<Exhibitions> exhibitions1 = query.ExhibitionsQuery(exhibitions, city_name, filter_name);
			int k = 1;
			if (exhibitions1.Count > 0)
			{
				foreach(var exhibition in exhibitions1)
				{
					if (city_name == "все города" && filter_name == "все выставки")
					{
						ShowInfoTextBox.AppendText($"{k}  ");
						ShowInfoTextBox.AppendText($"{exhibition.Title} в городе {exhibition.City} в категории {exhibition.Filter} \n");
						k++;
					}
					else if (city_name == "все города" && filter_name != "все выставки")
					{
						ShowInfoTextBox.AppendText($"{k}  ");
						ShowInfoTextBox.AppendText($"{exhibition.Title} в городе {exhibition.City}\n");
						k++;
					}
					else if (city_name != "все города" && filter_name == "все выставки")
					{
						ShowInfoTextBox.AppendText($"{k}  ");
						ShowInfoTextBox.AppendText($"{exhibition.Title} в категории {exhibition.Filter} \n");
						k++;
					}
					else
					{
						ShowInfoTextBox.AppendText($"{k}  ");
						ShowInfoTextBox.AppendText(exhibition.Title + "\n");
						k++;
					}
					
				}
			}
			else
			{
				ShowInfoTextBox.AppendText("Данных пока нет");
			}
			
		}

		private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("работу выполнила Лаптева Екатерина\nстудентка 1 курса НИТУ МИСИС\n");
		}

		private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Add_element add_Element = new Add_element();
			add_Element.ShowDialog();
			
		}

		private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Delete_element delete_Element = new Delete_element();
			delete_Element.ShowDialog();
		}

		private void диаграммаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Diagramm diagramm = new Diagramm();
			diagramm.ShowDialog();
		}

		private string name;
		private int adult;
		private int kids;
		private void know_price_Click(object sender, EventArgs e)
		{
			show_price.Clear();
			name = write_title.Text;
			List list = new List();
			List<Exhibitions> exhibitions = list.Exhibitions();

			for (int i = 0; i < exhibitions.Count; i++)
			{
				if (exhibitions[i].Title == name)
				{
					adult = exhibitions[i].AdultPrice;
					kids = exhibitions[i].KidsPrice;
					break;
				}
			}

			show_price.AppendText($"взросылй {adult}₽ ; детский {kids}₽ ");

		}
			
	}
}
