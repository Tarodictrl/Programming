using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        public Flight()
        {
        }

        public Flight(string departurePoint, string destination, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destination;
            FlightTimeInMinutes = flightTimeInMinutes;
        }

        public string DeparturePoint { get; set; }

        public string DestinationPoint { get; set; }

        public int FlightTimeInMinutes { get; set; }
    }
}
