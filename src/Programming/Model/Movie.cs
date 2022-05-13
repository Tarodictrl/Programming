using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Общее количество фильмов.
        /// </summary>
        private static int _allMoviesCount = 0;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Длительность фильма в минутах.
        /// </summary>
        private int _durationTimeInMinutes;

        /// <summary>
        /// Год релиза фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {
            _allMoviesCount++;
            _id = _allMoviesCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="title">Название фильма.</param>
        /// <param name="durationTimeInMinutes">Длительность фильма в минутах. Положительное число.</param>
        /// <param name="releaseYear">Год релиза фильма. Число в диапазоне от 1900 до 2022.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма. Число в диапазоне от 0 до 10.</param>
        public Movie(string title, int durationTimeInMinutes, int releaseYear, string genre, double rating)
        {
            Title = title;
            DurationTimeInMinutes = durationTimeInMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
            _allMoviesCount++;
            _id = _allMoviesCount;
        }

        /// <summary>
        /// Возвращает и задаёт длительность фильма в минутах. Положительное число.
        /// </summary>
        public int DurationTimeInMinutes
        {
            get
            {
                return _durationTimeInMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationTimeInMinutes));
                _durationTimeInMinutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт год релиза фильма. Число в диапазоне от 1900 до 2022.
        /// </summary>
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор фильма.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задаёт рейтинг фильма. Число в диапазоне от 0 до 10.
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задаёт название фильма.
        /// </summary>
        public string Title { get; set; }
    }
}
