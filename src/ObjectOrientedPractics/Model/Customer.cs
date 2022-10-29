using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        /// <summary>
        /// Общее количество покупателей.
        /// </summary>
        private static int _allCustomersCount;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Поле с полным именем покупателя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Поле с адресом доставки для покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает и задает уникальный идентификатор покупателя.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// Не больше 200 символов.
        /// </summary>
        public string Fullname
        {
            get { return _fullName; }
            set
            {
                Validator.AssertEmptyValue(value, nameof(Fullname));
                Validator.AssertLengthString(value, 200, nameof(Fullname));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// Не больше 500 символов.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                Validator.AssertEmptyValue(value, nameof(Address));
                Validator.AssertLengthString(value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Cоздает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullName">ФИО.</param>
        /// <param name="address">Адрес.</param>
        public Customer(string fullName, string address)
        {
            _allCustomersCount++;
            _id = _allCustomersCount;
            Fullname = fullName;
            Address = address;
        }

        /// <summary>
        /// Cоздает экземпляр класса <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            _allCustomersCount++;
            _id = _allCustomersCount;
        }
    }
}
