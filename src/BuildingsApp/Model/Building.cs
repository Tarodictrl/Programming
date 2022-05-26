namespace BuildingsApp.Model
{
    public class Building
    {
        private int _rating;

        public Building()
        {

        }

        public Building(string name, string address, string category, int rating)
        {
            Name = name;
            Address = address;
            Category = category;
            Rating = rating;
        }

        public int Rating
        {
            get 
            { 
                return _rating; 
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 5, nameof(Rating));
                _rating = value;
            }
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Category { get; set; }

        public string GetBuildingInfo()
        {
            return $"{Category} - {Name}";
        }
    }
}
