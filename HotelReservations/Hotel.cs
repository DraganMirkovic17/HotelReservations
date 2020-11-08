using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservations
{
    public class Hotel
    {
        // size of rooms in hotel
         int size;
        // matrix with a rooms and days.
        // the rows represent the rooms, columns represent days
        public int[,] hotel;
        //Each guest who will successfully reserve room will get their ID.
        //With that ID, we will know who is in the room. Also we will know what is starting date and ending date.
         int IDGuest = 0;
        //
         int lastDay = 0;

        public Hotel(int size)
        {
            if (size < 1 || size > 1000)
            {
                Console.WriteLine("Error: Number of rooms have to be between 1 and 1000!");
                return;
            }
            this.size = size;
            hotel = new int[this.size, 366];
        }
        public bool ReserveRoomFromBooking(Booking booking)
        {
            BookingValidation(booking);

            for (int i = 0; i < size; i++)
            {
                if (AvailableRoom(i, booking) && ReserveRoom(i, booking))
                {
                    if (lastDay < booking.EndDay)
                        lastDay = booking.EndDay;
                    return true;
                }
            }
            return false;
        }
        public void BookingValidation(Booking booking)
        {
            if (booking.StartDay < 0 || booking.StartDay > 365 || booking.EndDay < 0 || booking.EndDay > 365)
            {
                Console.WriteLine("Error: Start day and end day have to be between 0 and 365!");
                return;
            }

            if (booking.StartDay > booking.EndDay)
            {
                Console.WriteLine("Error: Start day have to be before end day!");
                return;
            }
        }
        public bool ReserveRoom(int room, Booking booking)
        {
            try
            {
                ++IDGuest;
                for (int i = booking.StartDay; i <= booking.EndDay; i++)
                {
                    hotel[room, i] = IDGuest;
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            } 
        }
        
        public bool AvailableRoom(int room, Booking booking)
        {
            for(int i = booking.StartDay;i <= booking.EndDay; i++)
            {
                if (hotel[room, i] != 0) {

                    return false;
                }
            }
            return true;
        }

        public void ReviewOfHotelAfterBookings()
        {            
            Console.Write("\nDays: \t");
            for (int i = 0; i <=lastDay; i++)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine("\n__________________________________________________________________");
            int m = 1;
            for (int i = 0; i <size; i++)
            {
                Console.Write($"Room{m++}=>\t");

                for (int j = 0; j <= lastDay; j++)
                    Console.Write($"{hotel[i, j]}\t");

                Console.WriteLine("");
            }
        }
    }
}
