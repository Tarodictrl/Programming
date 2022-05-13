using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о контактных данных человека.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Номер телефона человека.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Имя человека.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия человека.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        ///  Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="phoneNumber">Номер телефоне. Должен состоять только из цифр.
        /// Длина 11 символов.</param>
        /// <param name="name">Имя. Должно состоять только из букв англиского алфавита.</param>
        /// <param name="surname">Фамилия. Должна состоять только из букв англиского алфавита.</param>
        public Contact(string phoneNumber, string name, string surname)
        {
            PhoneNumber = phoneNumber;
            Name = name;
            Surname = surname;
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона человека. Должен состоять только из цифр.
        /// Длина 11 символов.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }

            set
            {
                Validator.AssertNumberContainsElevenDigit(value, nameof(Name));
                Validator.AssertStringContainsOnlyNumbers(value, nameof(Surname));
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя человека. Должно состоять только из букв английского алфавита.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию человека. Должно состоять только из букв английского алфавита.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }
    }
}
