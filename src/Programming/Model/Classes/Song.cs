using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private int _minutes;
        private int _seconds;

        public Song(string title, string artist, string description, int minutes, int seconds)
        {
            Title = title;
            Vocalist = artist;
            Description = description;
            Minutes = minutes;
            Seconds = seconds;
        }

        public string Title { get; set; }

        public string Vocalist { get; set; }

        public string Description { get; set; }

        public int Minutes
        {
            get 
            { 
                return _minutes; 
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentException(
                        "the number is out of bounds of the set ( from 0 to 60 )");
                }
                _minutes = value;
            }
        }

        public int Seconds
        {
            get
            { 
                return _seconds; 
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentException(
                        "the number is out of bounds of the set ( from 0 to 60 )");
                }
                _seconds = value;
            }
        }
    }
}
