using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservations
{
    public class Booking
    {
        int startDay;
        int endDay;

        public int StartDay { get => startDay; }
        public int EndDay { get => endDay; }

        public Booking(int startDay, int endDay)
        {
            this.startDay = startDay;
            this.endDay = endDay;
        }
    }
}
