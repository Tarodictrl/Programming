using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Сontact
    {
        private string _phoneNumber;

        private string _firstName;

        private string _lastName;

        public Сontact()
        {
        }

        public Сontact(string phoneNumber, string firstName, string lastName)
        {
            PhoneNumber = phoneNumber;
            FirstName = firstName;
            LastName = lastName;
        }

        public string PhoneNumber
        {
            get
            { 
                return _phoneNumber; 
            }
            set
            {
                if (_phoneNumber.Length != 11)
                {
                    throw new ArgumentException("Invalid phone number length");
                }
                if (!int.TryParse(value, out int result))
                {
                    throw new ArgumentException("Invalid characters in phone number");
                }
                _phoneNumber = value;
            }
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
