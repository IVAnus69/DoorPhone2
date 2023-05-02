namespace PayWindow
{
    partial class payWindow
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
            this.streetLabel = new System.Windows.Forms.Label();
            this.houseNumTextBox = new System.Windows.Forms.TextBox();
            this.houseNumLabel = new System.Windows.Forms.Label();
            this.roomNumTextBox = new System.Windows.Forms.TextBox();
            this.roomNumLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.firstPeriod = new System.Windows.Forms.DateTimePicker();
            this.secondPeriod = new System.Windows.Forms.DateTimePicker();
            this.dataLabel = new System.Windows.Forms.Label();
            this.todayData = new System.Windows.Forms.DateTimePicker();
            this.streetComboBox = new System.Windows.Forms.ComboBox();
            this.payButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(90, 29);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(39, 13);
            this.streetLabel.TabIndex = 28;
            this.streetLabel.Text = "Улица";
            // 
            // houseNumTextBox
            // 
            this.houseNumTextBox.Location = new System.Drawing.Point(135, 52);
            this.houseNumTextBox.MaxLength = 10;
            this.houseNumTextBox.Name = "houseNumTextBox";
            this.houseNumTextBox.Size = new System.Drawing.Size(157, 20);
            this.houseNumTextBox.TabIndex = 31;
            // 
            // houseNumLabel
            // 
            this.houseNumLabel.AutoSize = true;
            this.houseNumLabel.Location = new System.Drawing.Point(59, 55);
            this.houseNumLabel.Name = "houseNumLabel";
            this.houseNumLabel.Size = new System.Drawing.Size(70, 13);
            this.houseNumLabel.TabIndex = 30;
            this.houseNumLabel.Text = "Номер дома";
            // 
            // roomNumTextBox
            // 
            this.roomNumTextBox.Location = new System.Drawing.Point(135, 78);
            this.roomNumTextBox.MaxLength = 10;
            this.roomNumTextBox.Name = "roomNumTextBox";
            this.roomNumTextBox.Size = new System.Drawing.Size(157, 20);
            this.roomNumTextBox.TabIndex = 33;
            // 
            // roomNumLabel
            // 
            this.roomNumLabel.AutoSize = true;
            this.roomNumLabel.Location = new System.Drawing.Point(36, 81);
            this.roomNumLabel.Name = "roomNumLabel";
            this.roomNumLabel.Size = new System.Drawing.Size(93, 13);
            this.roomNumLabel.TabIndex = 32;
            this.roomNumLabel.Text = "Номер квартиры";
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Location = new System.Drawing.Point(90, 114);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(45, 13);
            this.periodLabel.TabIndex = 34;
            this.periodLabel.Text = "Период";
            // 
            // firstPeriod
            // 
            this.firstPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.firstPeriod.Location = new System.Drawing.Point(93, 130);
            this.firstPeriod.Name = "firstPeriod";
            this.firstPeriod.Size = new System.Drawing.Size(102, 20);
            this.firstPeriod.TabIndex = 35;
            // 
            // secondPeriod
            // 
            this.secondPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.secondPeriod.Location = new System.Drawing.Point(201, 130);
            this.secondPeriod.Name = "secondPeriod";
            this.secondPeriod.Size = new System.Drawing.Size(102, 20);
            this.secondPeriod.TabIndex = 36;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(132, 166);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(33, 13);
            this.dataLabel.TabIndex = 37;
            this.dataLabel.Text = "Дата";
            // 
            // todayData
            // 
            this.todayData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.todayData.Location = new System.Drawing.Point(135, 182);
            this.todayData.Name = "todayData";
            this.todayData.Size = new System.Drawing.Size(102, 20);
            this.todayData.TabIndex = 38;
            // 
            // streetComboBox
            // 
            this.streetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.streetComboBox.FormattingEnabled = true;
            this.streetComboBox.Items.AddRange(new object[] {
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
            this.streetComboBox.Location = new System.Drawing.Point(135, 25);
            this.streetComboBox.Name = "streetComboBox";
            this.streetComboBox.Size = new System.Drawing.Size(157, 21);
            this.streetComboBox.TabIndex = 39;
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(268, 183);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(75, 23);
            this.payButton.TabIndex = 40;
            this.payButton.Text = "Принять";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // payWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 235);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.streetComboBox);
            this.Controls.Add(this.todayData);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.secondPeriod);
            this.Controls.Add(this.firstPeriod);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.roomNumTextBox);
            this.Controls.Add(this.roomNumLabel);
            this.Controls.Add(this.houseNumTextBox);
            this.Controls.Add(this.houseNumLabel);
            this.Controls.Add(this.streetLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "payWindow";
            this.Text = "Оплата";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox houseNumTextBox;
        private System.Windows.Forms.Label houseNumLabel;
        private System.Windows.Forms.TextBox roomNumTextBox;
        private System.Windows.Forms.Label roomNumLabel;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.DateTimePicker firstPeriod;
        private System.Windows.Forms.DateTimePicker secondPeriod;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.DateTimePicker todayData;
        private System.Windows.Forms.ComboBox streetComboBox;
        private System.Windows.Forms.Button payButton;
    }
}

