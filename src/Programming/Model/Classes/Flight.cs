using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private int _flightTimeInSeconds;

        public Flight()
        {
        }

        public Flight(string departurePoint, string destinationPoint, int flightTimeInSeconds)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeInSeconds = flightTimeInSeconds;
        }

        public string DeparturePoint { get; set; }

        public string DestinationPoint { get; set; }

        public int FlightTimeInSeconds
        {
            get
            {
                return _flightTimeInSeconds;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "The number must be greater than 0");
                }
                _flightTimeInSeconds = value;
            }
        }
    }
}
