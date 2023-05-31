﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
<<<<<<< HEAD
using System.Windows.Input;
=======
>>>>>>> 1de554b8355f9469840f9e86e141a56ad7f7e52e
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для окна MainWindow.
    /// </summary>
    public class MainVM : ObservableObject
    {
        /// <summary>
        /// Режим добавления.
        /// </summary>
        private bool _isAddMode;

        /// <summary>
<<<<<<< HEAD
        /// Режим редактирования.
        /// </summary>
        private bool _isEditMode;

        /// <summary>
        /// Текущий контакт.
=======
        /// Объект, хранящий текущий контакт.
>>>>>>> 1de554b8355f9469840f9e86e141a56ad7f7e52e
        /// </summary>
        private ContactVM _selectedContact;

<<<<<<< HEAD
        /// <summary>
        /// Сериалайзер.
        /// </summary>
        private ContactSerializer _serializer;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM" />.
        /// </summary>
        public MainVM()
        {
            _serializer = new ContactSerializer();
            Contacts = _serializer.Load();
            EditCommand = new RelayCommand(EditContact);
            AddCommand = new RelayCommand(AddContact);
            RemoveCommand = new RelayCommand(RemoveContact);
            ApplyCommand = new RelayCommand(ApplyChangesContact);
            IsAddMode = true;
            IsEditMode = false;

        }

=======
>>>>>>> 1de554b8355f9469840f9e86e141a56ad7f7e52e
        /// <summary>
        /// Возвращает и задаёт коллекцию контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; set; }

        /// <summary>
        /// Возвращает и задает исходную версию редактируемого контакта.
        /// </summary>
        public ContactVM Buffer { get; set; }

        /// <summary>
        /// Возвращает и задает текущий контакт.
        /// </summary>
        public ContactVM SelectedContact
        {
            get => _selectedContact;
            set
            {
                _selectedContact = value;
                IsAddMode = true;
                if (SelectedContact == null)
                    IsEditMode = false;
                else
                    IsEditMode = true;

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает команду добавления контакта.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Возвращает команду принятия изменений.
        /// </summary>
        public ICommand ApplyCommand { get; }

        /// <summary>
        /// Возвращает команду редактирования контакта.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Возвращает команду удаления контакта.
        /// </summary>
<<<<<<< HEAD
        public ICommand RemoveCommand { get; }
=======
        public bool IsApply
        {
            get => _isApply;
            set
            {
                _isApply = value;
                IsVisible = !value;
                IsReadOnly = value;

                if (value)
                {
                    IsEdit = false;
                }
            }
        }
>>>>>>> 1de554b8355f9469840f9e86e141a56ad7f7e52e

        /// <summary>
        /// Возвращает и задаёт значение активности режима добавления.
        /// </summary>
        public bool IsAddMode
        {
            get => _isAddMode;
            set => SetProperty(ref _isAddMode, value);
        }

<<<<<<< HEAD
=======
        partial void OnCurrentContactChanged(ContactVM value)
        {
            if (!IsEdit && Contacts.Contains(value))
            {
                CurrentIndex = Contacts.IndexOf(value);
            }

            if (!IsApply)
            {
                IsApply = true;
            }
        }

>>>>>>> 1de554b8355f9469840f9e86e141a56ad7f7e52e
        /// <summary>
        /// Возвращает и задаёт значение активности режима редактирования.
        /// </summary>
        public bool IsEditMode
        {
            get => _isEditMode;
            set => SetProperty(ref _isEditMode, value);
        }

        /// <summary>
        /// Возвращает и задаёт значение доступности кнопки добавления.
        /// </summary>
        /// <summary>
        /// Вызывает редактирование нового экземпляра класса <see cref="ContactVM" />.
        /// </summary>
        private void AddContact()
        {
            SelectedContact = null;
            Buffer = new ContactVM(new Contact())
            {
                Name = "",
                PhoneNumber = "",
                Email = ""
            };
            SelectedContact = Buffer;
            IsAddMode = false;
            IsEditMode = true;
        }

        /// <summary>
        /// Вызывает редактирования текущего контакта.
        /// </summary>
        private void EditContact()
        {
            Buffer = SelectedContact;
            SelectedContact = (ContactVM)SelectedContact.Clone();
            IsAddMode = false;
            IsEditMode = false;
        }

        /// <summary>
        /// Удаляет текущий контакт.
        /// </summary>
        private void RemoveContact()
        {
            if (SelectedContact == null) return;
            var index = Contacts.IndexOf(SelectedContact);
            Contacts.RemoveAt(index);
            if (Contacts.Count == 0)
                SelectedContact = null;
            else if (index == Contacts.Count)
                SelectedContact = Contacts[index - 1];
            else
                SelectedContact = Contacts[index];
            _serializer.Save(Contacts);
        }

        /// <summary>
        /// Принимает изменения редактирования контакта.
        /// </summary>
        private void ApplyChangesContact()
        {
            if (!Contacts.Contains(Buffer))
                Contacts.Add(Buffer);
            IsAddMode = true;
            IsEditMode = true;
            var index = Contacts.IndexOf(Buffer);
            Contacts[index] = SelectedContact;
            SelectedContact = Contacts[index];
            _serializer.Save(Contacts);
        }

        /// <summary>
        /// Сохраняет контакты.
        /// </summary>
        public void SaveContacts()
        {
            _serializer.Save(Contacts);
        }
    }
}