using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signup
{
    public class FlightAdapter : IFlight
    {
        private airlineSystem airlineSystem;
        public FlightAdapter (airlineSystem airlineSystem)
        {
            this.airlineSystem = airlineSystem;
        }
        public void AddFlight( string Departure, string Arrival, string Price, string Date)
        {
            //throw new NotImplementedException();
            airlineSystem.reserveSeat(   Departure,  Arrival,  Price,  Date);

        }
    }
}
