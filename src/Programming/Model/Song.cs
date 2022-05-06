namespace Programming.Model
{
    public class Song
    {
        private int _minutes;

        private int _seconds;

        public Song(string title, string artist, string description, int minutes, int seconds)
        {
            Title = title;
            Artist = artist;
            Description = description;
            Minutes = minutes;
            Seconds = seconds;
        }

        public int Minutes
        {
            get 
            { 
                return _minutes; 
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 59, nameof(Minutes));
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
                Validator.AssertValueInRange(value, 0, 59, nameof(Seconds));
                _seconds = value;
            }
        }

        public string Title { get; set; }

        public string Artist { get; set; }

        public string Description { get; set; }
    }
}
