using Model;
using Repository;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BusinessLogic_ChangePerson
{
    public class Logic : IChangePersonModel
    {
        public event EventHandler EventPersonUpdateComboBoxModel = delegate { };
        public event EventHandler <PersonEventArgs> EventPersonSelectedPersonModel = delegate { };
        public event EventHandler EventPersonSubmitChanges;

        SQLRepository sqlRepository = new SQLRepository();

        public void CheckPerson(Person person)
        {
            List<Person> persons = sqlRepository.CheckPeople(person);
            EventPersonUpdateComboBoxModel(persons, new EventArgs());
        }

        public void SelectedPerson(Person person)
        {
            var fullPerson = sqlRepository.SelectedPerson(person);
            EventPersonSelectedPersonModel(this, new PersonEventArgs(fullPerson));
        }

        public void SubmitChanges(Person person)
        {
            bool condition = sqlRepository.UpdatePerson(person);
            if (condition) EventPersonSubmitChanges(this, new EventArgs());
            else MessageBox.Show("Не получилось обновить обонента", "Ошибка!");
        }
    }
}
