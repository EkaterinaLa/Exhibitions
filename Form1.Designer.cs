namespace homework
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ChooseCity = new System.Windows.Forms.ComboBox();
			this.ChooseFilter = new System.Windows.Forms.ComboBox();
			this.ShowInfoButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.диаграммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ShowCityTextBox = new System.Windows.Forms.TextBox();
			this.ShowInfoTextBox = new System.Windows.Forms.RichTextBox();
			this.know_price = new System.Windows.Forms.Button();
			this.write_title = new System.Windows.Forms.TextBox();
			this.show_price = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ChooseCity
			// 
			this.ChooseCity.FormattingEnabled = true;
			this.ChooseCity.Items.AddRange(new object[] {
            "все города",
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
			this.ChooseCity.Location = new System.Drawing.Point(12, 147);
			this.ChooseCity.Name = "ChooseCity";
			this.ChooseCity.Size = new System.Drawing.Size(169, 24);
			this.ChooseCity.TabIndex = 0;
			this.ChooseCity.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// ChooseFilter
			// 
			this.ChooseFilter.FormattingEnabled = true;
			this.ChooseFilter.Items.AddRange(new object[] {
            "все выставки",
            "Живопись",
            "Архитектура",
            "Прикладное искусство",
            "История",
            "Точные науки",
            "Детям"});
			this.ChooseFilter.Location = new System.Drawing.Point(291, 147);
			this.ChooseFilter.Name = "ChooseFilter";
			this.ChooseFilter.Size = new System.Drawing.Size(169, 24);
			this.ChooseFilter.TabIndex = 1;
			this.ChooseFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// ShowInfoButton
			// 
			this.ShowInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ShowInfoButton.Location = new System.Drawing.Point(161, 211);
			this.ShowInfoButton.Name = "ShowInfoButton";
			this.ShowInfoButton.Size = new System.Drawing.Size(150, 35);
			this.ShowInfoButton.TabIndex = 2;
			this.ShowInfoButton.Text = "Поиск";
			this.ShowInfoButton.UseVisualStyleBackColor = true;
			this.ShowInfoButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(42, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(402, 29);
			this.label1.TabIndex = 3;
			this.label1.Text = "выберите город и тип выставки";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.UseMnemonic = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(43, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Город";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(308, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Тип выставки";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1164, 30);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// менюToolStripMenuItem
			// 
			this.менюToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
			this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.обАвтореToolStripMenuItem,
            this.диаграммаToolStripMenuItem});
			this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
			this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
			this.менюToolStripMenuItem.Text = "Меню";
			// 
			// добавитьToolStripMenuItem
			// 
			this.добавитьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
			this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
			this.добавитьToolStripMenuItem.Text = "Добавить";
			this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
			// 
			// обАвтореToolStripMenuItem
			// 
			this.обАвтореToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
			this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
			this.обАвтореToolStripMenuItem.Text = "Об авторе";
			this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
			// 
			// диаграммаToolStripMenuItem
			// 
			this.диаграммаToolStripMenuItem.Name = "диаграммаToolStripMenuItem";
			this.диаграммаToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
			this.диаграммаToolStripMenuItem.Text = "Диаграмма";
			this.диаграммаToolStripMenuItem.Click += new System.EventHandler(this.диаграммаToolStripMenuItem_Click);
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
			// 
			// ShowCityTextBox
			// 
			this.ShowCityTextBox.Location = new System.Drawing.Point(531, 52);
			this.ShowCityTextBox.Name = "ShowCityTextBox";
			this.ShowCityTextBox.Size = new System.Drawing.Size(607, 22);
			this.ShowCityTextBox.TabIndex = 9;
			// 
			// ShowInfoTextBox
			// 
			this.ShowInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ShowInfoTextBox.Location = new System.Drawing.Point(531, 124);
			this.ShowInfoTextBox.Name = "ShowInfoTextBox";
			this.ShowInfoTextBox.Size = new System.Drawing.Size(607, 405);
			this.ShowInfoTextBox.TabIndex = 10;
			this.ShowInfoTextBox.Text = "";
			// 
			// know_price
			// 
			this.know_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.know_price.Location = new System.Drawing.Point(114, 389);
			this.know_price.Name = "know_price";
			this.know_price.Size = new System.Drawing.Size(264, 47);
			this.know_price.TabIndex = 11;
			this.know_price.Text = "Узнать цену";
			this.know_price.UseVisualStyleBackColor = true;
			this.know_price.Click += new System.EventHandler(this.know_price_Click);
			// 
			// write_title
			// 
			this.write_title.Location = new System.Drawing.Point(47, 323);
			this.write_title.Multiline = true;
			this.write_title.Name = "write_title";
			this.write_title.Size = new System.Drawing.Size(390, 44);
			this.write_title.TabIndex = 12;
			// 
			// show_price
			// 
			this.show_price.Location = new System.Drawing.Point(82, 474);
			this.show_price.Name = "show_price";
			this.show_price.Size = new System.Drawing.Size(330, 22);
			this.show_price.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(15, 284);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(445, 18);
			this.label4.TabIndex = 14;
			this.label4.Text = "введите полное название выставки, чтобы узнать цену";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1164, 587);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.show_price);
			this.Controls.Add(this.write_title);
			this.Controls.Add(this.know_price);
			this.Controls.Add(this.ShowInfoTextBox);
			this.Controls.Add(this.ShowCityTextBox);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ShowInfoButton);
			this.Controls.Add(this.ChooseFilter);
			this.Controls.Add(this.ChooseCity);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox ChooseCity;
		private System.Windows.Forms.ComboBox ChooseFilter;
		private System.Windows.Forms.Button ShowInfoButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.TextBox ShowCityTextBox;
		private System.Windows.Forms.RichTextBox ShowInfoTextBox;
		private System.Windows.Forms.ToolStripMenuItem диаграммаToolStripMenuItem;
		private System.Windows.Forms.Button know_price;
		private System.Windows.Forms.TextBox write_title;
		private System.Windows.Forms.TextBox show_price;
		private System.Windows.Forms.Label label4;
	}
}

