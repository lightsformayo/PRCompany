namespace PRCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаДоговорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаГородаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаСфераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаРаспределительныйЛистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетнаяТаблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоГородуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоНазваниюОрганизацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоНаправлениюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоТипуУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.выходИзПрограммыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(634, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаДоговорыToolStripMenuItem,
            this.таблицаГородаToolStripMenuItem,
            this.таблицаСфераToolStripMenuItem,
            this.таблицаУслугиToolStripMenuItem,
            this.таблицаРаспределительныйЛистToolStripMenuItem});
            this.таблицыToolStripMenuItem.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.таблицыToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // таблицаДоговорыToolStripMenuItem
            // 
            this.таблицаДоговорыToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.таблицаДоговорыToolStripMenuItem.Name = "таблицаДоговорыToolStripMenuItem";
            this.таблицаДоговорыToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.таблицаДоговорыToolStripMenuItem.Text = "Договоры";
            this.таблицаДоговорыToolStripMenuItem.Click += new System.EventHandler(this.таблицаДоговорыToolStripMenuItem_Click);
            // 
            // таблицаГородаToolStripMenuItem
            // 
            this.таблицаГородаToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.таблицаГородаToolStripMenuItem.Name = "таблицаГородаToolStripMenuItem";
            this.таблицаГородаToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.таблицаГородаToolStripMenuItem.Text = "Города";
            this.таблицаГородаToolStripMenuItem.Click += new System.EventHandler(this.таблицаГородаToolStripMenuItem_Click);
            // 
            // таблицаСфераToolStripMenuItem
            // 
            this.таблицаСфераToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.таблицаСфераToolStripMenuItem.Name = "таблицаСфераToolStripMenuItem";
            this.таблицаСфераToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.таблицаСфераToolStripMenuItem.Text = "Направления работы";
            this.таблицаСфераToolStripMenuItem.Click += new System.EventHandler(this.таблицаСфераToolStripMenuItem_Click);
            // 
            // таблицаУслугиToolStripMenuItem
            // 
            this.таблицаУслугиToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.таблицаУслугиToolStripMenuItem.Name = "таблицаУслугиToolStripMenuItem";
            this.таблицаУслугиToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.таблицаУслугиToolStripMenuItem.Text = "Услуги";
            this.таблицаУслугиToolStripMenuItem.Click += new System.EventHandler(this.таблицаУслугиToolStripMenuItem_Click);
            // 
            // таблицаРаспределительныйЛистToolStripMenuItem
            // 
            this.таблицаРаспределительныйЛистToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.таблицаРаспределительныйЛистToolStripMenuItem.Name = "таблицаРаспределительныйЛистToolStripMenuItem";
            this.таблицаРаспределительныйЛистToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.таблицаРаспределительныйЛистToolStripMenuItem.Text = "Распределительный лист";
            this.таблицаРаспределительныйЛистToolStripMenuItem.Click += new System.EventHandler(this.таблицаРаспределительныйЛистToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетнаяТаблицаToolStripMenuItem,
            this.поискПоГородуToolStripMenuItem,
            this.поискПоНазваниюОрганизацииToolStripMenuItem,
            this.поискПоНаправлениюToolStripMenuItem,
            this.поискПоТипуУслугиToolStripMenuItem});
            this.запросыToolStripMenuItem.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.запросыToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // отчетнаяТаблицаToolStripMenuItem
            // 
            this.отчетнаяТаблицаToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.отчетнаяТаблицаToolStripMenuItem.Name = "отчетнаяТаблицаToolStripMenuItem";
            this.отчетнаяТаблицаToolStripMenuItem.Size = new System.Drawing.Size(378, 26);
            this.отчетнаяТаблицаToolStripMenuItem.Text = "Поиск по номеру договора";
            this.отчетнаяТаблицаToolStripMenuItem.Click += new System.EventHandler(this.отчетнаяТаблицаToolStripMenuItem_Click);
            // 
            // поискПоГородуToolStripMenuItem
            // 
            this.поискПоГородуToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.поискПоГородуToolStripMenuItem.Name = "поискПоГородуToolStripMenuItem";
            this.поискПоГородуToolStripMenuItem.Size = new System.Drawing.Size(378, 26);
            this.поискПоГородуToolStripMenuItem.Text = "Поиск по городу";
            this.поискПоГородуToolStripMenuItem.Click += new System.EventHandler(this.поискПоГородуToolStripMenuItem_Click);
            // 
            // поискПоНазваниюОрганизацииToolStripMenuItem
            // 
            this.поискПоНазваниюОрганизацииToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.поискПоНазваниюОрганизацииToolStripMenuItem.Name = "поискПоНазваниюОрганизацииToolStripMenuItem";
            this.поискПоНазваниюОрганизацииToolStripMenuItem.Size = new System.Drawing.Size(378, 26);
            this.поискПоНазваниюОрганизацииToolStripMenuItem.Text = "Поиск по названию организации";
            this.поискПоНазваниюОрганизацииToolStripMenuItem.Click += new System.EventHandler(this.поискПоНазваниюОрганизацииToolStripMenuItem_Click);
            // 
            // поискПоНаправлениюToolStripMenuItem
            // 
            this.поискПоНаправлениюToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.поискПоНаправлениюToolStripMenuItem.Name = "поискПоНаправлениюToolStripMenuItem";
            this.поискПоНаправлениюToolStripMenuItem.Size = new System.Drawing.Size(378, 26);
            this.поискПоНаправлениюToolStripMenuItem.Text = "Поиск по направлению рекламы";
            this.поискПоНаправлениюToolStripMenuItem.Click += new System.EventHandler(this.поискПоНаправлениюToolStripMenuItem_Click);
            // 
            // поискПоТипуУслугиToolStripMenuItem
            // 
            this.поискПоТипуУслугиToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.поискПоТипуУслугиToolStripMenuItem.Name = "поискПоТипуУслугиToolStripMenuItem";
            this.поискПоТипуУслугиToolStripMenuItem.Size = new System.Drawing.Size(378, 26);
            this.поискПоТипуУслугиToolStripMenuItem.Text = "Поиск по типу услуги";
            this.поискПоТипуУслугиToolStripMenuItem.Click += new System.EventHandler(this.поискПоТипуУслугиToolStripMenuItem_Click);
            // 
            // выходИзПрограммыToolStripMenuItem
            // 
            this.выходИзПрограммыToolStripMenuItem.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выходИзПрограммыToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.выходИзПрограммыToolStripMenuItem.Name = "выходИзПрограммыToolStripMenuItem";
            this.выходИзПрограммыToolStripMenuItem.Size = new System.Drawing.Size(209, 25);
            this.выходИзПрограммыToolStripMenuItem.Text = "Выход из программы";
            this.выходИзПрограммыToolStripMenuItem.Click += new System.EventHandler(this.выходИзПрограммыToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 517);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Корпоративная информационная система \"Рекламная корпорация\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::PRCompany.Properties.Resources._908__Converted__01_e1698745005893_png;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(634, 577);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "КИС \"Рекламная корпорация\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзПрограммыToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem таблицаДоговорыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаГородаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаСфераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаУслугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаРаспределительныйЛистToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетнаяТаблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоГородуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоНазваниюОрганизацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоНаправлениюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоТипуУслугиToolStripMenuItem;
    }
}

