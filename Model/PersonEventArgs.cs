using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class PersonEventArgs
    {
        public Person person { get; set; }
        public PersonEventArgs(Person person)
        {
            this.person = person;
        }
        public PersonEventArgs(string searchNAME)
        {
            string[] names = searchNAME.Split(' ');
            person = new Person() { LastName = names[0],
                FirstName = names.ElementAtOrDefault(1) != null ? names[1] : null,
                MiddleName = names.ElementAtOrDefault(2) != null ? names[2] : null };
        }
        public PersonEventArgs(string _lastname, string _firstname, string _middlename,
            string _street, string _housenum, string _roomnum,
            string _telephonenumber, string _mailaddress)
        {
            person = new Person() {LastName = _lastname,
                FirstName = _firstname, MiddleName = _middlename, 
                Street = _street, HouseNum = _housenum,
                RoomNum = _roomnum, TelephoneNumber = _telephonenumber,
                MailAddress = _mailaddress };
        }
    }
}
