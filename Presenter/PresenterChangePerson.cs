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
            view.EventPersonSubmitChangesView += view_SubmitChanges;

            model = _model;
            model.EventPersonUpdateComboBoxModel += model_UpdateComboBox;
            model.EventPersonSelectedPersonModel += model_SelectedPerson;
            model.EventPersonSubmitChanges += model_SubmitChanges;
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
        public void model_SelectedPerson(object sender, PersonEventArgs e)
        {
            //проба
            view.SelectedPerson(e.person.FirstName,
                                e.person.LastName,
                                e.person.MiddleName,
                                e.person.RoomNum,
                                e.person.HouseNum,
                                e.person.TelephoneNumber,
                                e.person.Street,
                                e.person.MailAddress);
        }
        public void view_SubmitChanges(object sender, PersonEventArgs e)
        {
            model.SubmitChanges(e.person);
        }
        public void model_SubmitChanges(object sender, EventArgs e)
        {
            view.SubmitChanges();
        }
    }
}
