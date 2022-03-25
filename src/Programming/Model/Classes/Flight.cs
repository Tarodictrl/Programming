using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private string _departurePoint;

        private string _destination;

        private int _flightTimeInMinutes;

        public Flight()
        {
        }

        public Flight(string departurePoint, string destination, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTimeInMinutes = flightTimeInMinutes;
        }

        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
        public int FlightTimeInMinutes { get; set; }
    }
}
