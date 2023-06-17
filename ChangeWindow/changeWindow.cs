using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Presenter;
using BusinessLogic_ChangePerson;

namespace ChangeWindow
{
    public partial class changeWindow : Form, IChangePersonView
    {
        PresenterChangePerson presenter;
        List<string> persons;
        public changeWindow()
        {
            InitializeComponent();
            presenter = new PresenterChangePerson(this, new Logic());
            EventPersonUpdateComboBoxView(this, new PersonEventArgs(searchComboBox.Text));
            var bindSource = new BindingSource();
            bindSource.DataSource = persons;
            searchComboBox.DataSource = bindSource.DataSource;
        }

        public event EventHandler<PersonEventArgs> EventPersonUpdateComboBoxView = delegate { };
        public event EventHandler<PersonEventArgs> EventPersonSelectedPersonView = delegate { };
        public event EventHandler<PersonEventArgs> EventPersonSubmitChangesView = delegate { };


        private void search_TextChanged(object sender, EventArgs e)
        {
            
            
            //EventPersonUpdateComboBoxView(this, new PersonEventArgs(searchComboBox.Text));
        }

        private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //searchLabel.Text = searchComboBox.Text;
            if (searchComboBox.Text.Trim() != "")
            {
                EventPersonSelectedPersonView(this, new PersonEventArgs(searchComboBox.Text));
            }
        }

        public void UpdateComboBox(List<string> persons)
        {
            //strings = persons;
            //searchComboBox.DroppedDown = true;
            //Cursor.Current = Cursors.Default;
            this.persons = persons;
            searchComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public void SelectedPerson(string firstName, string lastName, string middleName,
            string roomNum, string houseNum, string telephoneNumber, string street,
            string mailAddress)
        {
            firstNameTextBox.Text = firstName.Trim();
            lastNameTextBox.Text = lastName.Trim();
            middleNameTextBox.Text = middleName.Trim();
            roomNumTextBox.Text = roomNum.Trim();
            houseNumTextBox.Text = houseNum.Trim();
            telephoneNumTextBox.Text = telephoneNumber.Trim();
            streetTextBox.Text = street.Trim();
            mailAddrTextBox.Text = mailAddress.Trim();
        }

        public void SubmitChanges()
        {
            MessageBox.Show("Успешно");

            this.Close();
        }

        private void submitChange_Click(object sender, EventArgs e)
        {
            EventPersonSubmitChangesView(this, new PersonEventArgs(lastNameTextBox.Text,
                firstNameTextBox.Text, middleNameTextBox.Text, streetTextBox.Text,
                houseNumTextBox.Text, roomNumTextBox.Text, telephoneNumTextBox.Text,
                mailAddrTextBox.Text));
        }
    }
}
