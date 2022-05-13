namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Длительность песни в секундах.
        /// </summary>
        private int _durationTimeInSeconds;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="title">Название песни.</param>
        /// <param name="artist">Псевдоним музыканта.</param>
        /// <param name="durationTimeInSeconds">Длительность песни в секундах. Положительное число.</param>
        public Song(string title, string artist, int durationTimeInSeconds)
        {
            Title = title;
            Artist = artist;
            DurationTimeInSeconds = durationTimeInSeconds;
        }

        /// <summary>
        /// Возвращает и задаёт длительность песни в секундах. Положительное число.
        /// </summary>
        public int DurationTimeInSeconds
        {
            get
            {
                return _durationTimeInSeconds;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 59, nameof(DurationTimeInSeconds));
                _durationTimeInSeconds = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт название песни.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задаёт псевдоним музыканта.
        /// </summary>
        public string Artist { get; set; }
    }
}
