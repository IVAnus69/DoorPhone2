using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IAddPersonView
    {
        event EventHandler<PersonEventArgs> EventPersonAddView;

        void AddPerson(string lastname, string firstname, string middlename);
    }
}
