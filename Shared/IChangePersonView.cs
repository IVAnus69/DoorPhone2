using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IChangePersonView
    {
        event EventHandler<PersonEventArgs> EventPersonUpdateComboBoxView;
        event EventHandler<PersonEventArgs> EventPersonSelectedPersonView;
        event EventHandler<PersonEventArgs> EventPersonSubmitChangesView;

        void UpdateComboBox(List<string> persons);
        void SelectedPerson(string firstName, string lastName, string middleName,
            string roomNum, string houseNum, string telephoneNumber, string street,
            string mailAddress);
        void SubmitChanges();
    }
}
