using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Movie
    {
        
        private readonly int _id;

        private int _duration;

        private int _releaseYear;

        private double _rating;

        public Movie()
        {
        }

        public Movie(string title, int duration, int releaseYear, string genre, double rating, int id)
        {
            Title = title;
            Duration = duration;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
            _id = id;
        }

        public int Duration
        {
            get 
            { 
                return _duration; 
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
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
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

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

        public override string ToString()
        {
            return $"Movie {_id}";
        }

        public string Genre { get; set; }

        public string Title { get; set; }
    }
}
