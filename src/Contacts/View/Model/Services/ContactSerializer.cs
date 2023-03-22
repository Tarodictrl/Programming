using System;
using System.IO;
using System.IO.Enumeration;
using System.Windows;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace View.Model.Services
{
    /// <summary>
    /// Представляет реализацию для сериализации. 
    /// </summary>
    internal class ContactSerializer
    {
        /// <summary>
        /// Возвращает и задает путь сохранения файла.
        /// </summary>
        public string Path { get; set; }
            = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\contacts.json";

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactSerializer"/>.
        /// </summary>
        public ContactSerializer()
        {

        }

        /// <summary>
        /// Загружает данные из файла в приложение.
        /// </summary>
        /// <returns>Объект класса <see cref="ContactSerializer"/>.</returns>
        public Contact? Load()
        {
            var contact = new Contact();

            if (File.Exists(Path))
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    contact = JsonConvert.DeserializeObject<Contact>(sr.ReadToEnd());
                }
            }

            return contact;
        }

        /// <summary>
        /// Сохраняет объект в файл.
        /// </summary>
        /// <param name="contact">Контакт.</param>
        public void Save(Contact? contact)
        {
            using (StreamWriter wr = new StreamWriter(Path))
            {
                wr.Write(JsonConvert.SerializeObject(contact));
            }
        }
    }
}