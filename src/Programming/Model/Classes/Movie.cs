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
        
        private int _id;

        private string _title;

        private int _duration;

        private int _releaseYear;

        private string _genre;

        private double _rating;

        public Movie()
        {
            _count++;
        }

        public Movie(string title, int duration, int releaseYear, string genre, double rating)
        {
            Title = title;
            Duration = duration;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
            _count++;
            Id = _count;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Duration
        {
            get 
            { 
                return _duration; 
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "The number must be greater than 0");
                }
                _duration = value;
            }
        }

        public int ReleaseYear
        {
            get 
            { 
                return _releaseYear; 
            }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException(
                        "The entered date is less than 1900 " +
                        "or more than the present year.");
                }
                _releaseYear = value;
            }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public double Rating
        {
            get 
            { 
                return _rating; 
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException(
                        "The number has exceeded the " +
                        "permissible limits of (from 0 to 10)");
                }
                _rating = value;
            }
        }

        public override string ToString()
        {
            return $"Movie {_id}";
        }
    }
}
