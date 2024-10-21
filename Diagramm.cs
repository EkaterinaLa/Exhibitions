using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace homework
{
	public partial class Diagramm : Form
	{
		public Diagramm()
		{
			InitializeComponent();
		}

		private void Diagramm_Load(object sender, EventArgs e)
		{

			List list = new List();
			List<Exhibitions> exhibitions = list.Exhibitions();
			int[] filter_mass = new int[6];
			for (int i = 0; i < exhibitions.Count; i++)
			{
				switch (exhibitions[i].Filter)
				{
					case "Живопись":
						filter_mass[0] += 1;
						break;
					case "Архитектура":
						filter_mass[1] += 1;
						break;
					case "Прикладное искусство":
						filter_mass[2] += 1;
						break;
					case "История":
						filter_mass[3] += 1;
						break;
					case "Точные науки":
						filter_mass[4] += 1;
						break;
					case "Детям":
						filter_mass[5] += 1;
						break;

				}
			}

			chart1.Titles.Add("Статистика по выставкам городов России");

			for (int i = 0; i < 6; i++)
			{
				chart1.Series[0].Points.AddXY(i, filter_mass[i]);
			}


		}

	}
}
