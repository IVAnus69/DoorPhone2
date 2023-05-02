using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Shared;

namespace PresenterView
{
    public class PresenterPerson
    {
        private IModel model = null;
        private IMainView mainView = null;

        public PresenterPerson(IMainView _mainView, IModel _model)
        {
            mainView = _mainView;
            mainView.EventPersonAddView += view_PersonAdd;
            mainView.EventPersonChangeView += view_ChangePerson;
            mainView.EventPersonPayView += view_PayPerson;
            mainView.EventPersonsCheckHousesNumView += view_CheckHousesNum;
            mainView.EventPersonsCheckRoomsNumView += view_CheckRoomsNum;
            mainView.EventPersonsCheckPaymentLogView += view_PaymentLog;

            model = _model;
            model.EventPersonAddModel += model_PersonAdd;
            model.EventPersonChangeModel += model_ChangePerson;
            model.EventPersonPayModel += model_PayPerson;
            model.EventPersonsCheckHousesNumModel += model_CheckHousesNum;
            model.EventPersonsCheckRoomsNumModel += model_CheckRoomsNum;
            model.EventPersonsCheckPaymentLogModel += model_PaymentLog;

        }
        #region { Add / Change / Pay } Methods
        public void view_PersonAdd(object sender, EventArgs e) => model.AddPerson();
        public void model_PersonAdd(object sender, EventArgs e) => mainView.AddPerson();
        public void view_ChangePerson(object sender, EventArgs e) => model.ChangePerson();
        public void model_ChangePerson(object sender, EventArgs e) => mainView.ChangePerson();
        public void view_PayPerson(object sender, EventArgs e) => model.PayPerson();
        public void model_PayPerson(object sender, EventArgs e) => mainView.PayPerson();
        #endregion

        public void view_CheckHousesNum(object sender, EventArgs e)
        {
            model.CheckHousesNum(sender.ToString());
        }
        public void model_CheckHousesNum(object sender, EventArgs e)
        {
            //Sort.CountingSort((List<string>)sender);

            foreach (var house in (List<string>)sender) mainView.CheckHousesNum(house);
        }

        public void view_CheckRoomsNum(object sender, EventArgs e)
        {
            model.CheckRoomsNum(sender.ToString());
        }
        public void model_CheckRoomsNum(object sender, EventArgs e)
        {
            foreach (var room in (List<string>)sender) mainView.CheckRoomsNum(room);
        }

        public void view_PaymentLog(object sender, EventArgs e)
        {
            model.CheckPaymentLog(sender.ToString());
        }
        public void model_PaymentLog(object sender, EventArgs e)
        {
            foreach (var data in (List<string>)sender) mainView.CheckPaymentLog(data);
        }
    }
}
