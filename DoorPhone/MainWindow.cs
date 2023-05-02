using System;
using System.Windows.Forms;
using Shared;
using PresenterView;
using BusinessLogic_Main;
using AboutWindow;

namespace DoorPhone
{
    public partial class MainWindow : Form, IMainView
    {
        PresenterPerson presenter;
        public MainWindow()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            presenter = new PresenterPerson(this, new Logic());
        }

        public event EventHandler EventPersonAddView = delegate { };
        public event EventHandler EventPersonChangeView = delegate { };
        public event EventHandler EventPersonPayView = delegate { };

        public event EventHandler EventPersonsCheckHousesNumView = delegate { };
        public event EventHandler EventPersonsCheckRoomsNumView = delegate { };
        public event EventHandler EventPersonsCheckPaymentLogView = delegate { };

        public void AddPerson() { }
        public void ChangePerson() { }
        public void PayPerson() { }

        private void addPersonClick_Click(object sender, EventArgs e)
        {
            EventPersonAddView(this, e);
        }

        private void changePersonClick_Click(object sender, EventArgs e)
        {
            EventPersonChangeView(this, e);
        }

        private void payClick_Click(object sender, EventArgs e)
        {
            EventPersonPayView(this, e);
        }

        private void aboutClick_Click(object sender, EventArgs e)
        {
            aboutWindow aboutWindow = new aboutWindow();
            aboutWindow.Show();
        }

        private void streetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            housesList.Items.Clear();
            roomsList.Items.Clear();
            paymentLog.Items.Clear();
            if (streetList.SelectedItem != null)
                EventPersonsCheckHousesNumView(((ListBox)sender).SelectedItem, e);
        }

        private void housesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomsList.Items.Clear();
            paymentLog.Items.Clear();
            if (housesList.SelectedItem != null) 
                EventPersonsCheckRoomsNumView(((ListBox)sender).SelectedItem, e);
        }

        private void roomsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            paymentLog.Items.Clear();
            if (roomsList.SelectedItem != null)
                EventPersonsCheckPaymentLogView(((ListBox)sender).SelectedItem, e);
        }

        public void CheckHousesNum(string house)
        {
            housesList.Items.Add(house);
        }

        public void CheckRoomsNum(string room)
        {
            roomsList.Items.Add(room);
        }

        public void CheckPaymentLog(string data)
        {
            paymentLog.Items.Add(data);
        }
    }
}
