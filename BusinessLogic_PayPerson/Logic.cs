using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic_PayPerson
{
    public class Logic : IPayPersonModel
    {
        public event EventHandler EventPayPersonModel = delegate { };
        SQLRepository sqlRepository = new SQLRepository();

        public void PayPerson(PayLog payLog)
        {
            bool condition = sqlRepository.PayLogRegister(payLog);

            if (condition) EventPayPersonModel(this, new EventArgs());
            
            else MessageBox.Show("Извините, запись не была добавлена", "Ошибка!");
        }
    }
}
