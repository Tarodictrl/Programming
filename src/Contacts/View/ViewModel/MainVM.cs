using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главное окна.
    /// </summary>
    internal class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Сериализатор.
        /// </summary>
        private ContactSerializer _serializer = new ContactSerializer();

        /// <summary>
        /// Возвращает и задает контакт.
        /// </summary>
        public Contact Contact { get; private set; } = new Contact();

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get => Contact.Name;
            set
            {
                Contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get => Contact.PhoneNumber;
            set
            {
                Contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Возвращает и задает электронную почту контакта.
        /// </summary>
        public string Email
        {
            get => Contact.Email;
            set
            {
                Contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Возвращает команду для загрузки данных из файла.
        /// </summary>
        public ICommand LoadCommand { get; }


        /// <summary>
        /// Возвращает команду для сохранения данных в файл.
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            SaveCommand = new RelayCommand(SaveContact);
            LoadCommand = new RelayCommand(LoadContact);
        }

        /// <summary>
        /// Вызывает событие при вызове.
        /// </summary>
        /// <param name="prop">Свойство, вызвавшее событие.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Загружает данные о контакте из файла.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void LoadContact(object parameter)
        {
            var contact = _serializer.Load();
            Name = contact.Name;
            PhoneNumber = contact.PhoneNumber;
            Email = contact.Email;
        }

        /// <summary>
        /// Сохраняет данные о контакте в файл.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void SaveContact(object parameter)
        {
            _serializer.Save(Contact);
        }

        /// <summary>
        /// Событие изменения свойтства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}