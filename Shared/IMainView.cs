using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IMainView
    {
        event EventHandler EventPersonAddView;
        event EventHandler EventPersonChangeView;
        event EventHandler EventPersonPayView;

        event EventHandler EventPersonsCheckHousesNumView;
        event EventHandler EventPersonsCheckRoomsNumView;
        event EventHandler EventPersonsCheckPaymentLogView;
        void AddPerson();
        void ChangePerson();
        void PayPerson();
        void CheckHousesNum(string house);
        void CheckRoomsNum(string room);
        void CheckPaymentLog(string data);
    }
}
