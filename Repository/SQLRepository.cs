using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Linq;
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
        IQueryable<Subscribers> query_checkUser;

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

            query_checkUser = from p in db.Subscribers where
                        p.FirstName == person.FirstName &&
                        p.LastName == person.LastName && 
                        p.MiddleName == person.MiddleName 
                        select p;

            var q = query_checkUser.FirstOrDefault();

            Person fullPerson = new Person();

            fullPerson.FirstName = q.FirstName.Trim();
            fullPerson.LastName = q.LastName.Trim();
            fullPerson.MiddleName = q.MiddleName.Trim();
            fullPerson.RoomNum = q.RoomNum.Trim();
            fullPerson.HouseNum = q.HouseNum.Trim();
            fullPerson.TelephoneNumber = q.TelephoneNumber.Trim();
            fullPerson.Street = q.Street.Trim();
            fullPerson.MailAddress = q.MailAddress.Trim();


            return fullPerson;
        }

        public bool UpdatePerson(Person person)
        {
            var db = new DoorPhoneDataContext();
            db.Log = Console.Out;

            try
            {
                Subscribers subscriber = query_checkUser.SingleOrDefault();
                int sub_id = subscriber.Id;
                Subscribers sub = (from c in db.Subscribers where c.Id == sub_id select c).First();

                sub.FirstName = person.FirstName.Trim();
                sub.LastName = person.LastName.Trim();
                sub.MiddleName = person.MiddleName.Trim();
                sub.RoomNum = person.RoomNum.Trim();
                sub.HouseNum = person.HouseNum.Trim();
                sub.TelephoneNumber = person.TelephoneNumber.Trim();
                sub.Street = person.Street.Trim();
                sub.MailAddress = person.MailAddress.Trim();

                db.SubmitChanges(ConflictMode.ContinueOnConflict);
                Console.WriteLine(db);
            }
            catch 
            {
                return false;
            }
            return true;
        }
    }
}
