using BusinessLogic_AddPerson;
using PresenterAddPersonView;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddWindow
{
    public partial class addWindow : Form, IAddPersonView
    {
        PresenterAddPerson presenter;
        public addWindow()
        {
            InitializeComponent();

            presenter = new PresenterAddPerson(this, new Logic());
        }

        public event EventHandler<PersonEventArgs> EventPersonAddView = delegate { };

        public void AddPerson(string lastname, string firstname, string middlename)
        {
            MessageBox.Show($"Абонент {lastname} {firstname} был успешно добавлен", "Успех!");
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EventPersonAddView(this, new PersonEventArgs(lastNameTextBox.Text, firstNameTextBox.Text,
                middleNameTextBox.Text, streetComboBox.Text, houseNumTextBox.Text, roomNumTextBox.Text, 
                telephoneNumTextBox.Text, mailAddrTextBox.Text));
        }
    }
}
