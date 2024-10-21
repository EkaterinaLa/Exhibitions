namespace homework
{
	partial class Diagramm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel3 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel4 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel5 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel6 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			customLabel1.ForeColor = System.Drawing.Color.Black;
			customLabel1.FromPosition = -0.5D;
			customLabel1.MarkColor = System.Drawing.Color.Black;
			customLabel1.Text = "Живопись";
			customLabel1.ToPosition = 0.5D;
			customLabel2.ForeColor = System.Drawing.Color.Black;
			customLabel2.FromPosition = 0.5D;
			customLabel2.Text = "Архитектура";
			customLabel2.ToPosition = 1.5D;
			customLabel3.ForeColor = System.Drawing.Color.Black;
			customLabel3.FromPosition = 1.5D;
			customLabel3.Text = "Прикладное искусство";
			customLabel3.ToPosition = 2.5D;
			customLabel4.ForeColor = System.Drawing.Color.Black;
			customLabel4.FromPosition = 2.5D;
			customLabel4.Text = "История";
			customLabel4.ToPosition = 3.5D;
			customLabel5.ForeColor = System.Drawing.Color.Black;
			customLabel5.FromPosition = 3.5D;
			customLabel5.Text = "Точные науки";
			customLabel5.ToPosition = 4.5D;
			customLabel6.ForeColor = System.Drawing.Color.Black;
			customLabel6.FromPosition = 4.5D;
			customLabel6.Text = "Детям";
			customLabel6.ToPosition = 5.5D;
			chartArea1.AxisX.CustomLabels.Add(customLabel1);
			chartArea1.AxisX.CustomLabels.Add(customLabel2);
			chartArea1.AxisX.CustomLabels.Add(customLabel3);
			chartArea1.AxisX.CustomLabels.Add(customLabel4);
			chartArea1.AxisX.CustomLabels.Add(customLabel5);
			chartArea1.AxisX.CustomLabels.Add(customLabel6);
			chartArea1.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelStyle.Angle = -90;
			chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legendItem1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			legend1.CustomItems.Add(legendItem1);
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(127, 34);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(541, 399);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "Статистика по выставкам городов России";
			// 
			// Diagramm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(798, 479);
			this.Controls.Add(this.chart1);
			this.Name = "Diagramm";
			this.Text = "Diagramm";
			this.Load += new System.EventHandler(this.Diagramm_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
	}
}