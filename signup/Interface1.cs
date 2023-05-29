using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signup
{
    public interface IFlightAdd
    {
        void addflight(string arrivalCity, string departureCity, string departureDate, string arrivalTime, string price);
    }
}
