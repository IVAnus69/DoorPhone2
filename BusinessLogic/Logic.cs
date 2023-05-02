using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddWindow;
using ChangeWindow;
using PayWindow;
using System.Windows.Forms;
using Model;
using Repository;

namespace BusinessLogic_Main
{
    public class Logic : IModel
    {
        public event EventHandler EventPersonAddModel = delegate { };
        public event EventHandler EventPersonChangeModel = delegate { };
        public event EventHandler EventPersonPayModel = delegate { };

        public event EventHandler EventPersonsCheckHousesNumModel = delegate { };
        public event EventHandler EventPersonsCheckRoomsNumModel = delegate { };
        public event EventHandler EventPersonsCheckPaymentLogModel = delegate { };

        SQLRepository sqlRepository = new SQLRepository();

        public void AddPerson()
        {
            addWindow addWindow = new addWindow();
            addWindow.Show();

            EventPersonAddModel(this, new EventArgs());
        }

        public void ChangePerson()
        {
            changeWindow changeWindow = new changeWindow();
            changeWindow.Show();

            EventPersonChangeModel(this, new EventArgs());
        }
        public void PayPerson()
        {
            payWindow payWindow = new payWindow();
            payWindow.Show();

            EventPersonPayModel(this, new EventArgs());
        }

        public void CheckHousesNum(string street)
        {
            var list = sqlRepository.CheckHousesNum(street);

            EventPersonsCheckHousesNumModel(list, new EventArgs());
        }
        public void CheckRoomsNum(string house)
        {
            var list = sqlRepository.CheckRoomsNum(house);

            EventPersonsCheckRoomsNumModel(list, new EventArgs());
        }
        public void CheckPaymentLog(string room)
        {
            var list = sqlRepository.CheckPaymentLog(room);

            EventPersonsCheckPaymentLogModel(list, new EventArgs());
        }
    }
}