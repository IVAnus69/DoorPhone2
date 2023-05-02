using Model;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public class PresenterPayPerson
    {
        private IPayPersonView view = null;
        private IPayPersonModel model = null;

        public PresenterPayPerson(IPayPersonView _view, IPayPersonModel _model)
        {
            view = _view;
            view.EventPersonPayView += view_PayPerson;

            model = _model;
            model.EventPayPersonModel += model_PayPerson;
        }

        public void view_PayPerson(object sender, PayLogEventArgs e)
        {
            model.PayPerson(e.payLog);
        }
        public void model_PayPerson(object sender, EventArgs e)
        {
            view.PayPerson();
        }
    }
}
