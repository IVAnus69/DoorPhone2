namespace AddWindow
{
    partial class addWindow
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
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.houseNumLabel = new System.Windows.Forms.Label();
            this.roomNumLabel = new System.Windows.Forms.Label();
            this.telephoneNumLabel = new System.Windows.Forms.Label();
            this.mailAddrLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.houseNumTextBox = new System.Windows.Forms.TextBox();
            this.roomNumTextBox = new System.Windows.Forms.TextBox();
            this.telephoneNumTextBox = new System.Windows.Forms.TextBox();
            this.mailAddrTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.streetComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(63, 28);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(90, 54);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "Имя";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(65, 80);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(54, 13);
            this.middleNameLabel.TabIndex = 2;
            this.middleNameLabel.Text = "Отчество";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(80, 106);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(39, 13);
            this.streetLabel.TabIndex = 3;
            this.streetLabel.Text = "Улица";
            // 
            // houseNumLabel
            // 
            this.houseNumLabel.AutoSize = true;
            this.houseNumLabel.Location = new System.Drawing.Point(49, 132);
            this.houseNumLabel.Name = "houseNumLabel";
            this.houseNumLabel.Size = new System.Drawing.Size(70, 13);
            this.houseNumLabel.TabIndex = 4;
            this.houseNumLabel.Text = "Номер дома";
            // 
            // roomNumLabel
            // 
            this.roomNumLabel.AutoSize = true;
            this.roomNumLabel.Location = new System.Drawing.Point(26, 158);
            this.roomNumLabel.Name = "roomNumLabel";
            this.roomNumLabel.Size = new System.Drawing.Size(93, 13);
            this.roomNumLabel.TabIndex = 5;
            this.roomNumLabel.Text = "Номер квартиры";
            // 
            // telephoneNumLabel
            // 
            this.telephoneNumLabel.AutoSize = true;
            this.telephoneNumLabel.Location = new System.Drawing.Point(314, 28);
            this.telephoneNumLabel.Name = "telephoneNumLabel";
            this.telephoneNumLabel.Size = new System.Drawing.Size(93, 13);
            this.telephoneNumLabel.TabIndex = 6;
            this.telephoneNumLabel.Text = "Номер телефона";
            // 
            // mailAddrLabel
            // 
            this.mailAddrLabel.AutoSize = true;
            this.mailAddrLabel.Location = new System.Drawing.Point(303, 54);
            this.mailAddrLabel.Name = "mailAddrLabel";
            this.mailAddrLabel.Size = new System.Drawing.Size(104, 13);
            this.mailAddrLabel.TabIndex = 7;
            this.mailAddrLabel.Text = "Электронная почта";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(125, 25);
            this.lastNameTextBox.MaxLength = 20;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(125, 51);
            this.firstNameTextBox.MaxLength = 10;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.firstNameTextBox.TabIndex = 9;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(125, 77);
            this.middleNameTextBox.MaxLength = 20;
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.middleNameTextBox.TabIndex = 10;
            this.middleNameTextBox.Tag = "";
            // 
            // houseNumTextBox
            // 
            this.houseNumTextBox.Location = new System.Drawing.Point(125, 129);
            this.houseNumTextBox.MaxLength = 10;
            this.houseNumTextBox.Name = "houseNumTextBox";
            this.houseNumTextBox.Size = new System.Drawing.Size(157, 20);
            this.houseNumTextBox.TabIndex = 12;
            // 
            // roomNumTextBox
            // 
            this.roomNumTextBox.Location = new System.Drawing.Point(125, 155);
            this.roomNumTextBox.MaxLength = 10;
            this.roomNumTextBox.Name = "roomNumTextBox";
            this.roomNumTextBox.Size = new System.Drawing.Size(157, 20);
            this.roomNumTextBox.TabIndex = 13;
            // 
            // telephoneNumTextBox
            // 
            this.telephoneNumTextBox.Location = new System.Drawing.Point(413, 25);
            this.telephoneNumTextBox.MaxLength = 11;
            this.telephoneNumTextBox.Name = "telephoneNumTextBox";
            this.telephoneNumTextBox.Size = new System.Drawing.Size(157, 20);
            this.telephoneNumTextBox.TabIndex = 14;
            // 
            // mailAddrTextBox
            // 
            this.mailAddrTextBox.Location = new System.Drawing.Point(413, 51);
            this.mailAddrTextBox.MaxLength = 40;
            this.mailAddrTextBox.Name = "mailAddrTextBox";
            this.mailAddrTextBox.Size = new System.Drawing.Size(157, 20);
            this.mailAddrTextBox.TabIndex = 15;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(317, 152);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(118, 23);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Добавить абонента";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.streetComboBox.Location = new System.Drawing.Point(125, 103);
            this.streetComboBox.Name = "streetComboBox";
            this.streetComboBox.Size = new System.Drawing.Size(157, 21);
            this.streetComboBox.TabIndex = 17;
            // 
            // addWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 204);
            this.Controls.Add(this.streetComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.mailAddrTextBox);
            this.Controls.Add(this.telephoneNumTextBox);
            this.Controls.Add(this.roomNumTextBox);
            this.Controls.Add(this.houseNumTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.mailAddrLabel);
            this.Controls.Add(this.telephoneNumLabel);
            this.Controls.Add(this.roomNumLabel);
            this.Controls.Add(this.houseNumLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "addWindow";
            this.Text = "Добавление абонента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label houseNumLabel;
        private System.Windows.Forms.Label roomNumLabel;
        private System.Windows.Forms.Label telephoneNumLabel;
        private System.Windows.Forms.Label mailAddrLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox houseNumTextBox;
        private System.Windows.Forms.TextBox roomNumTextBox;
        private System.Windows.Forms.TextBox telephoneNumTextBox;
        private System.Windows.Forms.TextBox mailAddrTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox streetComboBox;
    }
}

