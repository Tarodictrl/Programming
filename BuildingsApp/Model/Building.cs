namespace BuildingsApp.Model
{
    /// <summary>
    /// Хранит данные о строении.
    /// </summary>
    public class Building
    {
        /// <summary>
        /// Название строения.
        /// </summary>
        private string _name;

        /// <summary>
        /// Рейтинг строения.
        /// </summary>
        private int _rating;

        /// <summary>
        /// Адрес строения.
        /// </summary>
        private string _address;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Building"/>.
        /// </summary>
        public Building()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Building"/>.
        /// </summary>
        /// <param name="name">Название строения.</param>
        /// <param name="address">Адрес строения.</param>
        /// <param name="category">Категория строения.</param>
        /// <param name="rating">Рейтинг строения.</param>
        public Building(string name, string address, string category, int rating)
        {
            Name = name;
            Address = address;
            Category = category;
            Rating = rating;
        }

        /// <summary>
        /// Возвращает и задаёт название строения.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertValueInRange(value.Length, 1, 200, nameof(Name));
                _name = value;
            }

        }

        /// <summary>
        /// Возвращает и создаёт рейтинг строения.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт адрес строения.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                Validator.AssertValueInRange(value.Length, 1, 200, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        ///Возвращает и задаёт категорию строения. 
        /// </summary>
        public string Category { get; set; }
    }
}
