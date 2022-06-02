using System;

namespace MoviesApp.Model
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Название фильма.
        /// </summary>
        private string _name;

        /// <summary>
        /// Год релиза фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Длительность фильма в минутах.
        /// </summary>
        private int _durationTimeInMinutes;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {
            Name = "Movie";
            ReleaseYear = 1900;
            Genre = "Other";
            Rating = 1;
            DurationTimeInMinutes = 90;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="name">Название фильма.</param>
        /// <param name="releaseYear">Год релиза фильма.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма.</param>
        /// <param name="durationTimeInMinutes">Длительность фильма в минутах.</param>
        public Movie(string name, int releaseYear, string genre, 
                     int rating, int durationTimeInMinutes)
        {
            Name = name;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
            DurationTimeInMinutes = durationTimeInMinutes;
        }

        /// <summary>
        /// Возвращает и задаёт название фильма. Число в диапазоне от 1 до 100.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertValueInRange(value.Length, 1, 100, nameof(Name));
                _name = value;
            }

        }

        /// <summary>
        /// Возвращает и создаёт рейтинг фильма. Число в диапазоне от 0 до 10.
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
        /// Возвращает и задаёт длительность фильма в минутах.
        /// </summary>
        public int DurationTimeInMinutes
        {
            get
            {
                return _durationTimeInMinutes;
            }
            set
            {
                Validator.AssertValueInRange(value, 1, 300, nameof(DurationTimeInMinutes));
                _durationTimeInMinutes = value;
            }
        }

        /// <summary>
        ///Возвращает и задаёт жанр фильма. 
        /// </summary>
        public string Genre { get; set; }
    }
}
