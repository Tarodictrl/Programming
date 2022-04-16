using System;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _phoneNumber;
        
        private string _name;
        
        private string _surname;

        private readonly int _id;

        public Contact()
        {
        }

        public Contact(string phoneNumber, string name, string surname, int id)
        {
            PhoneNumber = phoneNumber;
            Name = name;
            Surname = surname;
            _id = id;
        }

        public string PhoneNumber
        {
            get
            { 
                return _phoneNumber; 
            }

            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException(
                        "Invalid phone number length");
                }
                _phoneNumber = value;
            }
        }

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

        public int Id
        {
            get
            {
                return _id;
            }
        }
    }
}
