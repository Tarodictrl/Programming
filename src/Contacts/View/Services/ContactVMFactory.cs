using Newtonsoft.Json;
using View.Model;
using View.ViewModel;

namespace View.Services
{
    /// <summary>
    /// Хранит логику для автоматического создания объектов.
    /// </summary>
    public class ContactVMFactory
    {

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVMFactory"/>.
        /// </summary>
        public ContactVMFactory()
        {
            
        }

        /// <summary>
        /// Создает объект на основе сгенерированных данных.
        /// </summary>
        /// <returns>Объект класса <see cref="ContactVM"/>.</returns>
        public ContactVM MakeContactVM()
        {
            var contact = new Contact();
            contact.Name = "Исайченко Никита Евгеньевич";
            contact.Email = "nikita_isaichenk@ro.ru";
            contact.PhoneNumber = "89069512827";
            var contactVM = new ContactVM(contact);
            return contactVM;
        }
    }
}