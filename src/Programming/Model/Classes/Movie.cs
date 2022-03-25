using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private static int _count = 0;

        private string _title;

        private int _durationInMinutes;

        private int _yearOfIssue;

        private string _genre;

        private double _rating;

        public Movie()
        {
            _count++;
        }

        public Movie(string title, int durationInMinutes, int yearOfIssue, string genre, double rating)
        {
            Title = title;
            DurationInMinutes = durationInMinutes;
            YearOfIssue = yearOfIssue;
            Genre = genre;
            Rating = rating;
            _count++;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set
            {
                if (_durationInMinutes < 0)
                {
                    _durationInMinutes = 0;
                    throw new ArgumentException("Длительность фильма не может быть меньше нуля");
                }
                _durationInMinutes = value;
            }
        }

        public int YearOfIssue
        {
            get { return _yearOfIssue; }
            set
            {
                if (value < 1900 | value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Введенная дата меньше 1900 года или больше настоящего года");
                }
                _yearOfIssue = value;
            }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public double Rating
        {
            get { return _rating; }
            set
            {
                if (value < 0 | value > 10)
                {
                    throw new ArgumentException("Число вышло за допустимые пределы" + "(от 0 до 10)");
                }
                _rating = value;
            }
        }

        public override string ToString()
        {
            return $"Movie {_count}";
        }
    }
}
