using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signup
{
    public class FlightAdapter : IFlightAdd
    {
        private airlineSystem airlineSystem;
        public FlightAdapter (airlineSystem airlineSystem)
        {
            this.airlineSystem = airlineSystem;
        }
        public void addflight(string arrivalCity, string departureCity, string departureDate, string arrivalTime, string price)
        {
            //throw new NotImplementedException();
            airlineSystem.reserveSeat(arrivalCity, departureCity, departureDate, arrivalTime, price);

        }
    }
}
