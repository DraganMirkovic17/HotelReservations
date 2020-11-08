using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservations
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAllTests();
            
            Console.ReadLine();
        }
        private static void Test1a()
        {
            Hotel hotel = new Hotel(1);
            Booking booking = new Booking(-4,2);

            try
            {
                hotel.ReserveRoomFromBooking(booking);
                Console.WriteLine($"Booking with ({booking.StartDay} , {booking.EndDay}) was accepted!");
            }
            catch (Exception)
            {
                Console.WriteLine($"Booking with ({booking.StartDay} , {booking.EndDay}) was declined! \n");
            }
            hotel.ReviewOfHotelAfterBookings();
        }
        private static void Test1b()
        {
            Hotel hotel = new Hotel(1);
            Booking booking = new Booking(200, 400);
            try
            {
                hotel.ReserveRoomFromBooking(booking);
                Console.WriteLine($"Booking with ({booking.StartDay} , {booking.EndDay}) was accepted!");
            }
            catch (Exception)
            {
                Console.WriteLine($"Booking with ({booking.StartDay} , {booking.EndDay}) was declined! \n");
                
            }
            hotel.ReviewOfHotelAfterBookings();
        }
        private static void Test2()
        {
            Hotel hotel = new Hotel(3);
            List<Booking> newBookings = new List<Booking>()
            {
                new Booking(0, 5),
                new Booking(7, 13),
                new Booking(3, 9),
                new Booking(5, 7),
                new Booking(6, 6),
                new Booking(0, 4)
            };

            int i = 0;
            foreach (Booking booking in newBookings)
            {
                i++;
                if (hotel.ReserveRoomFromBooking(booking))
                {
                    Console.WriteLine($"Booking{i} with ({booking.StartDay} , {booking.EndDay}) was accepted!");
                }
                else
                {
                    Console.WriteLine($"Booking{i} with ({booking.StartDay} , {booking.EndDay}) was declined!");
                }
            }
            hotel.ReviewOfHotelAfterBookings();
        }
        private static void Test3()
        {
            Hotel hotel = new Hotel(3);
            List<Booking> newBookings = new List<Booking>()
            {
                new Booking(1, 3),
                new Booking(2, 5),
                new Booking(1, 9),
                new Booking(0,15)
            };

            int i = 0;
            foreach (Booking booking in newBookings)
            {
                i++;
                if (hotel.ReserveRoomFromBooking(booking))
                {
                    Console.WriteLine($"Booking{i} with ({booking.StartDay} , {booking.EndDay}) was accepted!");
                }
                else
                {
                    Console.WriteLine($"Booking{i} with ({booking.StartDay} , {booking.EndDay}) was declined!");
                }
            }
            hotel.ReviewOfHotelAfterBookings();
        }
        private static void Test4()
        {
            // When I started a program with this examples, Day14 and Day15 are automatically moving to a new line.
            // This is because console is limited widths on my computer.
            Hotel hotel = new Hotel(3);
            List<Booking> newBookings = new List<Booking>()
            {
                new Booking(1, 3),
                new Booking(0, 15),
                new Booking(1, 9),
                new Booking(2, 5),
                new Booking(4, 9)
            };

            int i = 0;
            foreach (Booking booking in newBookings)
            {
                i++;
                if (hotel.ReserveRoomFromBooking(booking))
                {
                    Console.WriteLine($"Booking{i} with ({booking.StartDay} , {booking.EndDay}) was accepted!");
                }
                else
                {
                    Console.WriteLine($"Booking{i} with ({booking.StartDay} , {booking.EndDay}) was declined!");
                }
            }
            hotel.ReviewOfHotelAfterBookings();
        }
        private static void Test5()
        {
            Hotel hotel = new Hotel(2);
            List<Booking> newBookings = new List<Booking>()
            {
                new Booking(1, 3),
                new Booking(0, 4),
                new Booking(2, 3),
                new Booking(5, 5),
                new Booking(4, 10),
                new Booking(10, 10),
                new Booking(6, 7),
                new Booking(8, 10),
                new Booking(8, 9)
            };

            int i = 0;
            foreach (Booking booking in newBookings)
            {
                i++;
                if (hotel.ReserveRoomFromBooking(booking))
                {
                    Console.WriteLine($"Booking{i} with ({booking.StartDay} , {booking.EndDay}) was accepted!");
                }
                else
                {
                    Console.WriteLine($"Booking{i} with ({booking.StartDay} , {booking.EndDay}) was declined!");
                }
            }
            hotel.ReviewOfHotelAfterBookings();
        }
        
        // This method is only used to run all tests
        private static void RunAllTests()
        {
            Console.WriteLine("Test 1a:");
            Test1a();

            Console.WriteLine("\nTest 1b:");
            Test1b();

            Console.WriteLine("\nTest 2:");
            Test2();

            Console.WriteLine("\nTest 3:");
            Test3();

            Console.WriteLine("\nTest 4:");
            Test4();

            Console.WriteLine("\nTest 5:");
            Test5();
        }
    }
}
