using System;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные об адресе. 
    /// </summary>
    public class Address
    {
        /// <summary>
        /// 
        /// </summary>
        public EventHandler<EventArgs> AddressChanged;

        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город (населенный пункт).
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Количество цифр в поле <see cref="Index"/>.
        /// </summary>
        private readonly int _numberDigitsInIndex = 6;

        /// <summary>
        /// Максимальное количество символов в поле <see cref="Country"/>.
        /// </summary>
        private readonly int _maxCountSymbolsInCountry = 50;

        /// <summary>
        /// Максимальное количество символов в поле <see cref="City"/>.
        /// </summary>
        private readonly int _maxCountSymbolsInCity = 50;

        /// <summary>
        /// Максимальное количество символов в поле <see cref="Street"/>.
        /// </summary>
        private readonly int _maxCountSymbolsInStreet = 100;

        /// <summary>
        /// Максимальное количество символов в поле <see cref="Building"/>.
        /// </summary>
        private readonly int _maxCountSymbolsInBuilding = 10;

        /// <summary>
        /// Максимальное количество символов в поле <see cref="Apartment"/>.
        /// </summary>
        private readonly int _maxCountSymbolsInApartment = 10;

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 140060;
            Country = "Россия";
            City = "Москва";
            Street = "Ленина";
            Building = "1";
            Apartment = "1";
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс. Должен содержать 6 цифр.</param>
        /// <param name="country">Страна/регион. Должно быть не более 50 символов.</param>
        /// <param name="city">Город (населенный пункт). Должно быть не более 50 символов.</param>
        /// <param name="street">Улица. Должно быть не более 100 символов.</param>
        /// <param name="building">Номер дома. Должно быть не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения. Должно быть не более 10 символов.</param>
        public Address(int index, string country, string city,
                        string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Возвращает и задает почтовый индекс.
        /// Должен содержать 6 цифр.
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                Validator.AssertStringLength(nameof(Index), value, _numberDigitsInIndex);
                if (_index != value)
                {
                    _index = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает название страны/региона.
        /// Должно быть не более 50 символов.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                Validator.AssertStringOnLength(nameof(Country), value, _maxCountSymbolsInCountry);
                if (_country != value)
                {
                    _country = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает название города (населенного пункта).
        /// Должно быть не более 50 символов.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                Validator.AssertStringOnLength(nameof(City), value, _maxCountSymbolsInCity);
                if (_city != value)
                {
                    _city = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает название улицы.
        /// Должно быть не более 100 символов.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                Validator.AssertStringOnLength(nameof(Street), value, _maxCountSymbolsInStreet);
                if (_street != value)
                {
                    _street = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер дома.
        /// Должно быть не более 10 символов.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                Validator.AssertStringOnLength(nameof(Building), value, _maxCountSymbolsInBuilding);
                if (_building != value)
                {
                    _building = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры/помещения.
        /// Должно быть не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                Validator.AssertStringOnLength(nameof(Apartment), value, _maxCountSymbolsInApartment);
                if (_apartment != value)
                {
                    _apartment = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
