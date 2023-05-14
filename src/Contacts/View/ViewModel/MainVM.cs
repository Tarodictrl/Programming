using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главное окна.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Сериализатор.
        /// </summary>
        private ContactSerializer _serializer = new ContactSerializer();

        /// <summary>
        /// Объект, хранящий текущий контакт.
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(EditContactCommand), nameof(RemoveContactCommand))]
        private ContactVM _currentContact;

        /// <summary>
        /// Поле, хранящее значение для свойства окна IsReadOnly.
        /// </summary>
        [ObservableProperty]
        private bool _isReadOnly = true;

        /// <summary>
        /// Поле, хранящее значение для свойства окна Visibility.
        /// </summary>
        [ObservableProperty]
        private bool _isVisible = false;

        /// <summary>
        /// Поле, хранящее значение, которое говорит о том, была ли нажата кнопка Apply.
        /// </summary>
        private bool _isApply = false;

        /// <summary>
        /// Возвращает и задает индекс текущего контакты.
        /// </summary>
        public int CurrentIndex { get; set; }

        /// <summary>
        /// Возвращает список контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; private set; }
            = new ObservableCollection<ContactVM>();

        /// <summary>
        /// Возвращает и задает, включен ли редактор контактов.
        /// </summary>
        public bool IsEdit { get; set; }

        /// <summary>
        /// Возвращает и задает, подтверждены ли изменения.
        /// </summary>
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

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = _serializer.Load();
        }

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

        /// <summary>
        /// Принимает добавление/изменение контакта.
        /// </summary>
        [RelayCommand]
        private void ApplyContact()
        {
            if (!IsEdit)
            {
                Contacts.Add(CurrentContact);
                CurrentContact = null;
                CurrentContact = Contacts[Contacts.Count - 1];
            }
            else
            {
                Contacts[CurrentIndex] = CurrentContact;
                CurrentContact = Contacts[CurrentIndex];
            }

            IsApply = true;
        }

        /// <summary>
        /// Добавляет контакт.
        /// </summary>
        [RelayCommand]
        private void AddContact()
        {
            CurrentContact = new ContactVM(new Contact());

            IsApply = false;
        }

        /// <summary>
        /// Изменяет контакт.
        /// </summary> 
        [RelayCommand(CanExecute = nameof(CanExecuteEdit))]
        private void EditContact()
        {
            IsEdit = true;

            var tempContact = CurrentContact;

            CurrentContact = null;
            CurrentContact = (ContactVM?)tempContact.Clone();

            IsApply = false;
        }

        /// <summary>
        /// Определяет возможность выполнения команды <see cref="EditCommand"/>.
        /// </summary>
        private bool CanExecuteEdit()
        {
            return Contacts.Count > 0 && CurrentContact != null;
        }

        /// <summary>
        /// Удаляет контакт.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanExecuteRemove))]
        private void RemoveContact()
        {
            if (Contacts.Count == 1)
            {
                Contacts.Remove(CurrentContact);
            }
            else if (CurrentIndex < Contacts.Count - 1)
            {
                Contacts.Remove(CurrentContact);
                CurrentContact = Contacts[CurrentIndex];
            }
            else
            {
                Contacts.Remove(CurrentContact);
                CurrentContact = Contacts[CurrentIndex - 1];
            }
        }

        /// <summary>
        /// Определяет возможность выполнения команды <see cref="RemoveCommand"/>.
        /// </summary
        private bool CanExecuteRemove()
        {
            return Contacts.Count > 0 && CurrentContact != null;
        }

        /// <summary>
        /// Сохраняет список контактов.
        /// </summary>
        public void SaveContacts()
        {
            _serializer.Save(Contacts);
        }
    }
}