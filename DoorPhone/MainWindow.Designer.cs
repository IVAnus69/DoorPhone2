namespace DoorPhone
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.personClick = new System.Windows.Forms.ToolStripDropDownButton();
            this.addPersonClick = new System.Windows.Forms.ToolStripMenuItem();
            this.changePersonClick = new System.Windows.Forms.ToolStripMenuItem();
            this.payClick = new System.Windows.Forms.ToolStripButton();
            this.aboutClick = new System.Windows.Forms.ToolStripButton();
            this.streetList = new System.Windows.Forms.ListBox();
            this.housesList = new System.Windows.Forms.ListBox();
            this.roomsList = new System.Windows.Forms.ListBox();
            this.paymentLog = new System.Windows.Forms.ListBox();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personClick,
            this.payClick,
            this.aboutClick});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1270, 25);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "toolStrip1";
            // 
            // personClick
            // 
            this.personClick.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.personClick.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPersonClick,
            this.changePersonClick});
            this.personClick.Image = ((System.Drawing.Image)(resources.GetObject("personClick.Image")));
            this.personClick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.personClick.Name = "personClick";
            this.personClick.Size = new System.Drawing.Size(67, 22);
            this.personClick.Text = "Абонент";
            // 
            // addPersonClick
            // 
            this.addPersonClick.Name = "addPersonClick";
            this.addPersonClick.Size = new System.Drawing.Size(128, 22);
            this.addPersonClick.Text = "Добавить";
            this.addPersonClick.Click += new System.EventHandler(this.addPersonClick_Click);
            // 
            // changePersonClick
            // 
            this.changePersonClick.Name = "changePersonClick";
            this.changePersonClick.Size = new System.Drawing.Size(128, 22);
            this.changePersonClick.Text = "Изменить";
            this.changePersonClick.Click += new System.EventHandler(this.changePersonClick_Click);
            // 
            // payClick
            // 
            this.payClick.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.payClick.Image = ((System.Drawing.Image)(resources.GetObject("payClick.Image")));
            this.payClick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.payClick.Name = "payClick";
            this.payClick.Size = new System.Drawing.Size(51, 22);
            this.payClick.Text = "Оплата";
            this.payClick.Click += new System.EventHandler(this.payClick_Click);
            // 
            // aboutClick
            // 
            this.aboutClick.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutClick.Image = ((System.Drawing.Image)(resources.GetObject("aboutClick.Image")));
            this.aboutClick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutClick.Name = "aboutClick";
            this.aboutClick.Size = new System.Drawing.Size(86, 22);
            this.aboutClick.Text = "О программе";
            this.aboutClick.Click += new System.EventHandler(this.aboutClick_Click);
            // 
            // streetList
            // 
            this.streetList.Dock = System.Windows.Forms.DockStyle.Left;
            this.streetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.streetList.FormattingEnabled = true;
            this.streetList.ItemHeight = 18;
            this.streetList.Items.AddRange(new object[] {
            "40ЛЕТвлксм",
            "КУЛЬТУРА",
            "ИНДУСТРИАЛЬНАЯ",
            "СТРОИТЕЛЕЙ",
            "ДЕКАБРИСТОВ",
            "ДРУЖБЫ НАРОДОВ",
            "ЗВЕРЕВА",
            "ФРУНЗЕ",
            "МАНКЕВИЧА",
            "МИРА",
            "МАЛИНОВКА",
            "ДЗЕРЖИНСКОГО",
            "НАЗАРОВА",
            "КАЛИНИНА",
            "КВ.ПОЛИТЕХНИКУМ",
            "ЧКАЛОВА",
            "САДОВАЯ",
            "СВЕРДЛОВА",
            "9 ЯНВАРЯ",
            "КРАВЧЕНКО",
            "НАБЕРЕЖНАЯ",
            "ЛАЗО",
            "ЛЕБЕДЕНКО",
            "ЛЕНИНА",
            "ПУЗАНОВОЙ",
            "ЛЬВА ТОЛСТОГО",
            "КВ 25",
            "КВ 24",
            "28 КВ",
            "ЮВР",
            "7Б",
            "М-ОН 1",
            "М-ОН 2",
            "М-ОН 3",
            "М-ОН 4",
            "М-ОН 5",
            "М-ОН 6",
            "М-ОН 7",
            "М-ОН 8",
            "М-ОН 9",
            "КИРОВА ",
            "CАЯНСТРОЙ",
            "3 ПРИВОКЗАЛЬНЫЙ",
            "4 ПРИВОКЗАЛЬНЫЙ ",
            "ПРИВОКЗАЛЬНАЯ",
            "ДОГАЕВА",
            "АВИАТОРОВ"});
            this.streetList.Location = new System.Drawing.Point(0, 25);
            this.streetList.Name = "streetList";
            this.streetList.Size = new System.Drawing.Size(218, 598);
            this.streetList.TabIndex = 1;
            this.streetList.SelectedIndexChanged += new System.EventHandler(this.streetList_SelectedIndexChanged);
            // 
            // housesList
            // 
            this.housesList.Dock = System.Windows.Forms.DockStyle.Top;
            this.housesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.housesList.FormattingEnabled = true;
            this.housesList.ItemHeight = 18;
            this.housesList.Items.AddRange(new object[] {
            ""});
            this.housesList.Location = new System.Drawing.Point(218, 25);
            this.housesList.Name = "housesList";
            this.housesList.Size = new System.Drawing.Size(1052, 238);
            this.housesList.TabIndex = 2;
            this.housesList.SelectedIndexChanged += new System.EventHandler(this.housesList_SelectedIndexChanged);
            // 
            // roomsList
            // 
            this.roomsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomsList.FormattingEnabled = true;
            this.roomsList.ItemHeight = 18;
            this.roomsList.Location = new System.Drawing.Point(218, 263);
            this.roomsList.Name = "roomsList";
            this.roomsList.Size = new System.Drawing.Size(1052, 238);
            this.roomsList.TabIndex = 3;
            this.roomsList.SelectedIndexChanged += new System.EventHandler(this.roomsList_SelectedIndexChanged);
            // 
            // paymentLog
            // 
            this.paymentLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paymentLog.FormattingEnabled = true;
            this.paymentLog.ItemHeight = 18;
            this.paymentLog.Location = new System.Drawing.Point(218, 501);
            this.paymentLog.Name = "paymentLog";
            this.paymentLog.Size = new System.Drawing.Size(1052, 122);
            this.paymentLog.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 623);
            this.Controls.Add(this.paymentLog);
            this.Controls.Add(this.roomsList);
            this.Controls.Add(this.housesList);
            this.Controls.Add(this.streetList);
            this.Controls.Add(this.Menu);
            this.Name = "MainWindow";
            this.Text = "Главный экран";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripButton payClick;
        private System.Windows.Forms.ToolStripDropDownButton personClick;
        private System.Windows.Forms.ToolStripButton aboutClick;
        private System.Windows.Forms.ToolStripMenuItem addPersonClick;
        private System.Windows.Forms.ToolStripMenuItem changePersonClick;
        private System.Windows.Forms.ListBox streetList;
        private System.Windows.Forms.ListBox housesList;
        private System.Windows.Forms.ListBox roomsList;
        private System.Windows.Forms.ListBox paymentLog;
    }
}

