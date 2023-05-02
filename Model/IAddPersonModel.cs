using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IAddPersonModel
    {
        event EventHandler<PersonEventArgs> EventPersonAddModel;

        void AddPerson(Person person);
    }
}
