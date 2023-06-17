using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IChangePersonModel
    {
        event EventHandler EventPersonUpdateComboBoxModel;
        event EventHandler <PersonEventArgs> EventPersonSelectedPersonModel;
        event EventHandler EventPersonSubmitChanges;
        void CheckPerson(Person person);
        void SelectedPerson(Person person);
        void SubmitChanges(Person person);
    }
}
