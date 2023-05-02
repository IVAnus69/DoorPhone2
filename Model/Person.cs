using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Street { get; set; }
        public string HouseNum { get; set; }
        public string RoomNum { get; set; }
        public string TelephoneNumber { get; set; }
        public string MailAddress { get; set; }
    }
}
