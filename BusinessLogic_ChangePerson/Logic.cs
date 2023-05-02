using Model;
using Repository;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic_ChangePerson
{
    public class Logic : IChangePersonModel
    {
        public event EventHandler EventPersonUpdateComboBoxModel = delegate { };
        public event EventHandler EventPersonSelectedPersonModel = delegate { };
        SQLRepository sqlRepository = new SQLRepository();

        public void CheckPerson(Person person)
        {
            List<Person> persons = sqlRepository.CheckPeople(person);
            EventPersonUpdateComboBoxModel(persons, new EventArgs());
        }

        public void SelectedPerson(Person person)
        {
            var fullPerson = sqlRepository.SelectedPerson(person);
            EventPersonSelectedPersonModel(person, new EventArgs());
        }
    }
}
