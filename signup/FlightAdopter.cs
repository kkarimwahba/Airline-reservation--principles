using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin
{
    class FlightAdopter : IFlight
    {
        private AirlineSystem airlineSystem;
        public FlightAdopter(AirlineSystem airlineSystem)
        {
            this.airlineSystem = airlineSystem;

        }


        public void AddFlight(string ID, string Departure, string Arrival, String Price, string Date)
        {
            //throw new NotImplementedException();
            airlineSystem.ReserveSeat(ID, Departure, Arrival, Price, Date);
        }
    }
}
