using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    public class SQLRepository
    {
        IQueryable<Subscribers> query;
        IQueryable<Subscribers> query_checkHouse;
        IQueryable<Subscribers> query_checkRoom;
        IQueryable<Subscribers> query_checkPaymentLog;

        List<int> list = new List<int>();
        List<string> paymentList = new List<string>();

        public bool AddPerson(Person person)
        {
            var db = new DoorPhoneDataContext();
            query = from c in db.Subscribers where c.LastName == person.LastName 
                        && c.FirstName == person.FirstName
                        && c.MiddleName == person.MiddleName select c;
            if (query.Count() == 0 && person.LastName != "" && person.FirstName != "" 
                && person.Street != ""
                && person.HouseNum != "")
            {
                var data = new Subscribers
                {
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    MiddleName = person.MiddleName,
                    Street = person.Street,
                    HouseNum = person.HouseNum,
                    RoomNum = person.RoomNum,
                    TelephoneNumber = person.TelephoneNumber,
                    MailAddress = person.MailAddress
                };
                db.Subscribers.InsertOnSubmit(data);
                db.SubmitChanges();

                return true;
            } else return false;
        }

        public List<string> CheckHousesNum(string street)
        {
            list.Clear();
            var db = new DoorPhoneDataContext();
            query_checkHouse = (from c in db.Subscribers where c.Street == street select c);

            foreach (var person in query_checkHouse)
            {
                list.Add(int.Parse(person.HouseNum.Trim()));
            }

            return list.Distinct().OrderBy(c => c).Select(c => c.ToString()).ToList();
        }

        public List<string> CheckRoomsNum(string house)
        {
            list.Clear();
            query_checkRoom = from c in query_checkHouse where c.HouseNum == house select c;

            foreach (var person in query_checkRoom)
            {
                list.Add(int.Parse(person.RoomNum.Trim()));
            }

            return list.Distinct().OrderBy(c => c).Select(c => c.ToString()).ToList();
        }

        public List<string> CheckPaymentLog(string room)
        {
            paymentList.Clear();
            var db = new DoorPhoneDataContext();
            query_checkPaymentLog = (from c in query_checkRoom where c.RoomNum == room select c);
            var queryLog = (from a in db.PaymentLog.AsEnumerable()
                            join c in query_checkPaymentLog.AsEnumerable()
                            on a.Id_person equals c.Id
                            select $"{a.firstPeriod.ToString("dd-MM-yyyy")} - {a.secondPeriod.ToString("dd-MM-yyyy")} {c.FirstName.Trim()} {c.LastName.Trim()} Оплата произошла: {a.todayData.ToString("dd-MM-yyyy")}");
            //var queryLog = db.PaymentLog.Join()
            //var queryLog = db.PaymentLog.Where((a, c) => );
            foreach (var log in queryLog)
            {
                //list.Add($"{log.Id_person} {log.todayData.ToString("dd-MM-yyyy")}");
                paymentList.Add(log);
            }
            return paymentList;
        }

        public bool PayLogRegister(PayLog payLog)
        {
            var db = new DoorPhoneDataContext();
            var queryLog = from c in db.Subscribers where c.Street == payLog.Street
                           && c.HouseNum == payLog.HouseNum && c.RoomNum == payLog.RoomNum
                           select c;
            if (queryLog.Any())
            {
                var data = new PaymentLog
                {
                    Id_person = queryLog.First().Id,
                    firstPeriod = payLog.FirstPeriod,
                    secondPeriod = payLog.SecondPeriod,
                    todayData = payLog.TodayData
                };
                db.PaymentLog.InsertOnSubmit(data);
                db.SubmitChanges();
                return true;
            } else return false;
        }

        public List<Person> CheckPeople(Person person)
        {
            var db = new DoorPhoneDataContext();
            List<Person> people = new List<Person>();

            var query = from p in db.Subscribers
                        where p.LastName.Contains(person.LastName)  &&
                        (p.FirstName.Contains(person.FirstName) || string.IsNullOrEmpty(person.FirstName)) &&
                        (p.MiddleName.Contains(person.MiddleName) || string.IsNullOrEmpty(person.MiddleName))
                        select p;

            List<Subscribers> a = query.ToList();

            foreach (var p in query)
            {
                people.Add(new Person() { LastName = p.LastName.Trim(),
                    FirstName = p.FirstName.Trim(), MiddleName = p.MiddleName.Trim() });
            }

            return people;
        }
        
        public Person SelectedPerson(Person person)
        {
            var db = new DoorPhoneDataContext();

            var query = from p in db.Subscribers where
                        p.FirstName == person.FirstName &&
                        p.LastName == person.LastName && 
                        p.MiddleName == person.MiddleName 
                        select p;

            Person fullPerson = new Person();
            foreach (var p in query)
            {
                fullPerson.FirstName = p.FirstName.Trim();
                fullPerson.LastName = p.LastName.Trim();
                fullPerson.MiddleName = p.MiddleName.Trim();
                fullPerson.RoomNum = p.RoomNum.Trim();
                fullPerson.HouseNum = p.HouseNum.Trim();
                fullPerson.TelephoneNumber = p.TelephoneNumber.Trim();
                fullPerson.Street = p.Street.Trim();
                fullPerson.MailAddress = p.MailAddress.Trim();
                break;
            }

            return fullPerson;
        }
    }
}
