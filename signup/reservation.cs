using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signup
{
    class reservation
    {
        // Properties
        public string ReservationNumber { get; set; }
        public userSession User { get; set; }
        public flights Flight { get; set; }
        public DateTime ReservationDate { get; set; }
        public int NumberOfPassengers { get; set; }

        // Default constructor
        public reservation()
        {
        }

        // Parameterized constructor
        public reservation(string reservationNumber, userSession user, flights flight, DateTime reservationDate, int numberOfPassengers)
        {
            ReservationNumber = reservationNumber;
            User = user;
            Flight = flight;
            ReservationDate = reservationDate;
            NumberOfPassengers = numberOfPassengers;
        }
    }
}
