using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PayLog
    {
        public string Street { get; set; }
        public string HouseNum { get; set; }
        public string RoomNum { get; set; }
        public DateTime FirstPeriod { get; set; }
        public DateTime SecondPeriod { get; set; }
        public DateTime TodayData { get; set; }
    }
}
