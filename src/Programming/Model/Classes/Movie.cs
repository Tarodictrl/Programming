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
                    throw new ArgumentException("The duration of the movie cannot be less than zero.");
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
                    throw new ArgumentException("The entered date is less than 1900 or more than the present year.");
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
                    throw new ArgumentException("The number has exceeded the permissible limits of (from 0 to 10)");
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
