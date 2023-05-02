using Model;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public class PresenterChangePerson
    {
        private IChangePersonView view = null;
        private IChangePersonModel model = null;
        
        public PresenterChangePerson(IChangePersonView _view, IChangePersonModel _model)
        {
            view = _view;
            view.EventPersonUpdateComboBoxView += view_UpdateComboBox;
            view.EventPersonSelectedPersonView += view_SelectedPerson;

            model = _model;
            model.EventPersonUpdateComboBoxModel += model_UpdateComboBox;
            model.EventPersonSelectedPersonModel += model_SelectedPerson;
        }
        public void view_UpdateComboBox(object sender, PersonEventArgs e)
        {
            model.CheckPerson(e.person);
        }
        public void model_UpdateComboBox(object sender, EventArgs e)
        {
            //view.UpdateComboBox();
            List<string> persons = new List<string>();
            foreach (var p in (List<Person>)sender)
                persons.Add($"{p.LastName} {p.FirstName} {p.MiddleName}");
            view.UpdateComboBox(persons);
        }
        public void view_SelectedPerson(object sender, PersonEventArgs e)
        {
            model.SelectedPerson(e.person);
        }
        public void model_SelectedPerson(object sender, EventArgs e)
        {
            
            view.SelectedPerson();
        }
    }
}
