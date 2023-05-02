using Model;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresenterAddPersonView
{
    public class PresenterAddPerson
    {
        private IAddPersonModel model = null;
        private IAddPersonView view = null;
        public PresenterAddPerson(IAddPersonView _view, IAddPersonModel _model)
        {
            view = _view;
            view.EventPersonAddView += view_PersonAdd;

            model = _model;
            model.EventPersonAddModel += model_PersonAdd;
        }
        public void view_PersonAdd(object sender, PersonEventArgs e)
        {
            model.AddPerson(e.person);
        }
        public void model_PersonAdd(object sender, PersonEventArgs e)
        {
            view.AddPerson(e.person.LastName, e.person.FirstName, e.person.MiddleName);
        }
    }
}
