using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signup
{
    interface IFlight
    {
        void AddFlight( String Departure, String Arrival, String Price, String Date);
    }
}
