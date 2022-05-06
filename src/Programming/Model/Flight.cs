namespace Programming.Model
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

        public int FlightTimeInSeconds
        {
            get
            {
                return _flightTimeInSeconds;
            }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeInSeconds));
                _flightTimeInSeconds = value;
            }
        }
        public string DeparturePoint { get; set; }

        public string DestinationPoint { get; set; }
    }
}
