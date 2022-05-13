namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о полёте.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Время полёта в минутах.
        /// </summary>
        private int _flightTimeInSeconds;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>
        /// </summary>
        public Flight()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>
        /// </summary>
        /// <param name="departurePoint">Пункт отправления.</param>
        /// <param name="destinationPoint">Пункт назначения.</param>
        /// <param name="flightTimeInSeconds">Время полёта в минутах. Положительное число.</param>
        public Flight(string departurePoint, string destinationPoint, int flightTimeInSeconds)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeInSeconds = flightTimeInSeconds;
        }

        /// <summary>
        /// Возвращает и задаёт время полёта в минутах. Положительное число.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт пункт отправления.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Возвращает и задаёт пункт прибытия.
        /// </summary>
        public string DestinationPoint { get; set; }
    }
}
