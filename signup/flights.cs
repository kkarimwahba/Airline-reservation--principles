using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signup
{
    public class flights
    {
            public string FlightNumber { get; set; }
            public string DepartureCity { get; set; }
            public string ArrivalCity { get; set; }
            public DateTime DepartureTime { get; set; }
            public DateTime ArrivalTime { get; set; }
            public double Price { get; set; }

        // Additional properties, constructors, and methods can be added as needed
        public flights()
        {
        }

        // Parameterized constructor
        public flights(string flightNumber, string departureCity, string arrivalCity, DateTime departureTime, DateTime arrivalTime, double price)
        {
            FlightNumber = flightNumber;
            DepartureCity = departureCity;
            ArrivalCity = arrivalCity;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            Price = price;
        }
        /*Flight flight1 = new Flight(); // Using the default constructor

        Flight flight2 = new Flight("ABC123", "New York", "London", DateTime.Now, DateTime.Now.AddHours(6), 500.00); // Using the parameterized constructor
        */

    }
}
