using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signup
{
    public class AirlineSystem1
    {
        private static AirlineSystem1 instance;
        private static readonly object lockObject = new object();

        // Private constructor to prevent direct instantiation
        private AirlineSystem1()
        {
            // Add any initialization logic here
        }

        public static AirlineSystem1 Instance
        {
            get
            {
                // Double-checked locking for thread safety
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new AirlineSystem1();
                        }
                    }
                }
                return instance;
            }
        }
        public void ReserveSeat(string username, string FlyingFrom, string FlyingTo, string Departing, string Returning, string Adults, string Children, string TravelClass)
        {
            // Perform seat reservation logic in the airline system
            Console.WriteLine($"username {username} Flight flyging from{FlyingFrom} to{FlyingTo} departing time {Departing} returning {Returning} adults {Adults} childrens {Children} travel class {TravelClass}.");
        }
    }
}
