namespace homework
{
	partial class Add_element
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.Add_title = new System.Windows.Forms.TextBox();
			this.Add_AdultPrice = new System.Windows.Forms.TextBox();
			this.Add_KidsPrice = new System.Windows.Forms.TextBox();
			this.Choose_city = new System.Windows.Forms.ComboBox();
			this.Choose_Filter = new System.Windows.Forms.ComboBox();
			this.Add_Button = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(143, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(540, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "введите данные по выставке, которую хотите добавить";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(56, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Город";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(405, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Название";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(56, 179);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(158, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Цена(взрослый)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(405, 179);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(146, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Цена(ребенок)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(712, 179);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(107, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "Категория";
			// 
			// Add_title
			// 
			this.Add_title.Location = new System.Drawing.Point(392, 122);
			this.Add_title.Name = "Add_title";
			this.Add_title.Size = new System.Drawing.Size(627, 22);
			this.Add_title.TabIndex = 7;
			this.Add_title.TextChanged += new System.EventHandler(this.Add_title_TextChanged);
			// 
			// Add_AdultPrice
			// 
			this.Add_AdultPrice.Location = new System.Drawing.Point(60, 222);
			this.Add_AdultPrice.Name = "Add_AdultPrice";
			this.Add_AdultPrice.Size = new System.Drawing.Size(133, 22);
			this.Add_AdultPrice.TabIndex = 8;
			this.Add_AdultPrice.TextChanged += new System.EventHandler(this.Add_AdultPrice_TextChanged);
			// 
			// Add_KidsPrice
			// 
			this.Add_KidsPrice.Location = new System.Drawing.Point(392, 222);
			this.Add_KidsPrice.Name = "Add_KidsPrice";
			this.Add_KidsPrice.Size = new System.Drawing.Size(122, 22);
			this.Add_KidsPrice.TabIndex = 9;
			this.Add_KidsPrice.TextChanged += new System.EventHandler(this.Add_KidsPrice_TextChanged);
			// 
			// Choose_city
			// 
			this.Choose_city.FormattingEnabled = true;
			this.Choose_city.Items.AddRange(new object[] {
            "Адлер",
            "Балтийск",
            "Барнаул",
            "Белгород",
            "Великий Устюг",
            "Владивосток",
            "Волгоград",
            "Галич",
            "Дагомыс",
            "Екатеринбург",
            "Забайкальск",
            "Иркутск",
            "Йошкар-Ола",
            "Казань",
            "Краснодар",
            "Магнитогорск",
            "Москва",
            "Набережные Челны",
            "Нижный Новгород",
            "Новосибирск",
            "Омск",
            "Пенза",
            "Пермь",
            "Ростов-на-Дону",
            "Самара",
            "Санкт-Петербург",
            "Севастополь",
            "Северодвинск",
            "Сочи",
            "Томск",
            "Ульяновск",
            "Уфа",
            "Хабаровск",
            "Челябинск",
            "Ярославль"});
			this.Choose_city.Location = new System.Drawing.Point(56, 120);
			this.Choose_city.Name = "Choose_city";
			this.Choose_city.Size = new System.Drawing.Size(168, 24);
			this.Choose_city.TabIndex = 10;
			this.Choose_city.SelectedIndexChanged += new System.EventHandler(this.Choose_city_SelectedIndexChanged);
			// 
			// Choose_Filter
			// 
			this.Choose_Filter.FormattingEnabled = true;
			this.Choose_Filter.Items.AddRange(new object[] {
            "Живопись",
            "Архитектура",
            "Прикладное искусство",
            "История",
            "Точные науки",
            "Детям"});
			this.Choose_Filter.Location = new System.Drawing.Point(701, 222);
			this.Choose_Filter.Name = "Choose_Filter";
			this.Choose_Filter.Size = new System.Drawing.Size(163, 24);
			this.Choose_Filter.TabIndex = 11;
			this.Choose_Filter.SelectedIndexChanged += new System.EventHandler(this.Choose_Filter_SelectedIndexChanged);
			// 
			// Add_Button
			// 
			this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Add_Button.Location = new System.Drawing.Point(956, 214);
			this.Add_Button.Name = "Add_Button";
			this.Add_Button.Size = new System.Drawing.Size(156, 34);
			this.Add_Button.TabIndex = 12;
			this.Add_Button.Text = "Добавить";
			this.Add_Button.UseVisualStyleBackColor = true;
			this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(71, 270);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(837, 343);
			this.dataGridView1.TabIndex = 13;
			// 
			// Add_element
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1245, 720);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Add_Button);
			this.Controls.Add(this.Choose_Filter);
			this.Controls.Add(this.Choose_city);
			this.Controls.Add(this.Add_KidsPrice);
			this.Controls.Add(this.Add_AdultPrice);
			this.Controls.Add(this.Add_title);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Add_element";
			this.Text = "Add_element";
			this.Load += new System.EventHandler(this.Add_element_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Add_title;
		private System.Windows.Forms.TextBox Add_AdultPrice;
		private System.Windows.Forms.TextBox Add_KidsPrice;
		private System.Windows.Forms.ComboBox Choose_city;
		private System.Windows.Forms.ComboBox Choose_Filter;
		private System.Windows.Forms.Button Add_Button;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}