using BusinessLogic_PayPerson;
using Model;
using Presenter;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayWindow
{
    public partial class payWindow : Form, IPayPersonView
    {
        PresenterPayPerson presenter;
        public event EventHandler<PayLogEventArgs> EventPersonPayView = delegate { };
        public payWindow()
        {
            InitializeComponent();
            presenter = new PresenterPayPerson(this, new Logic());

            //var a2 = todayData.Value.ToString("dd-MM-yyyy");
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            EventPersonPayView(this, new PayLogEventArgs(streetComboBox.Text, houseNumTextBox.Text,
                roomNumTextBox.Text, firstPeriod.Value, secondPeriod.Value, todayData.Value));
        }
        
        public void PayPerson()
        {
            MessageBox.Show("Запись прошла успешно", "Успех!");
        }
    }
}
