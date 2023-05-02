using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IModel
    {
        event EventHandler EventPersonAddModel;
        event EventHandler EventPersonChangeModel;
        event EventHandler EventPersonPayModel;

        event EventHandler EventPersonsCheckHousesNumModel;
        event EventHandler EventPersonsCheckRoomsNumModel;
        event EventHandler EventPersonsCheckPaymentLogModel;

        void AddPerson();
        void ChangePerson();
        void PayPerson();
        void CheckHousesNum(string street);
        void CheckRoomsNum(string house);
        void CheckPaymentLog(string room);
    }
}
