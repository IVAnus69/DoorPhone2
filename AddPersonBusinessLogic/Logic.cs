using AddPersonBusinessLogic;
using Model;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using System.Windows.Forms;

namespace BusinessLogic_AddPerson
{
    public class Logic : IAddPersonModel
    {
        public event EventHandler<PersonEventArgs> EventPersonAddModel = delegate { };
        SQLRepository sqlRepository = new SQLRepository();

        public void AddPerson(Person person)
        {
            bool condition = sqlRepository.AddPerson(person);

            if (condition) EventPersonAddModel(this, new PersonEventArgs(person));
            else MessageBox.Show("Не получилось добавить абонента", "Ошибка!");
        }
    }
}
