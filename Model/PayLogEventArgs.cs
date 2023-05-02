using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PayLogEventArgs
    {
        public PayLog payLog { get; set; }
        public PayLogEventArgs(string _street, string _houseNum, string _roomNum, 
            DateTime _firstPeriod, DateTime _secondPeriod, DateTime _todayData)
        {
            payLog = new PayLog() { Street = _street, HouseNum = _houseNum, RoomNum = _roomNum,
            FirstPeriod = _firstPeriod, SecondPeriod = _secondPeriod, TodayData = _todayData};
        }
    }
}
