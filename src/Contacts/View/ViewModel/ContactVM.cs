<<<<<<< HEAD
﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;
=======
﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
>>>>>>> 1de554b8355f9469840f9e86e141a56ad7f7e52e
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для Contact.
    /// </summary>
    public class ContactVM : ObservableValidator, ICloneable
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="ContactVM" />.
        /// </summary>
        /// <param name="contact">Контакт.</param>
        public ContactVM(Contact contact)
        {
<<<<<<< HEAD
            Contact = contact;
=======
            get { return Contact.Name; }
            set
            {
                Contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
>>>>>>> 1de554b8355f9469840f9e86e141a56ad7f7e52e
        }

        /// <summary>
        /// Возвращает и задаёт контакт.
        /// </summary>
<<<<<<< HEAD
        public Contact Contact { get; }
=======
        public string PhoneNumber
        {
            get { return Contact.PhoneNumber; }
            set
            {
                Contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }
>>>>>>> 1de554b8355f9469840f9e86e141a56ad7f7e52e

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        [CustomValidation(typeof(Model.Validator), nameof(Model.Validator.ValidateName))]
        public string Name
        {
<<<<<<< HEAD
            get => Contact.Name;
            set => SetProperty(
                Contact.Name,
                value,
                Contact,
                (contact, name) => Contact.Name = name,
                true);
=======
            get { return Contact.Email; }
            set
            {
                Contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
>>>>>>> 1de554b8355f9469840f9e86e141a56ad7f7e52e
        }

        /// <summary>
        /// Возвращает и задаёт электронную почту контакта.
        /// </summary>
        [CustomValidation(typeof(Model.Validator), nameof(Model.Validator.ValidateEmail))]
        public string Email
        {
            get => Contact.Email;
            set => SetProperty(
                Contact.Email,
                value,
                Contact,
                (contact, email) => Contact.Email = email,
                true);
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта.
        /// </summary>
        [CustomValidation(typeof(Model.Validator), nameof(Model.Validator.ValidatePhone))]
        public string PhoneNumber
        {
            get => Contact.PhoneNumber;
            set => SetProperty(
                Contact.PhoneNumber,
                value,
                Contact,
                (contact, phone) => Contact.PhoneNumber = phone,
                true);
        }

        /// <summary>
        /// Клонирует текущий экземпляр класса <see cref="ContactVM" />.
        /// </summary>
        /// <returns>Возвращает дубликат текущего экземпляра.</returns>
        public object Clone()
        {
            return new ContactVM((Contact)Contact.Clone());
        }
    }
}