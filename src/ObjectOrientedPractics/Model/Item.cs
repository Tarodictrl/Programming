using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        /// <summary>
        /// Общее количество предметов.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Поле названия предмета.
        /// </summary>
        private string _name;

        /// <summary>
        /// Поле информации о предмете.
        /// </summary>
        private string _info;

        /// <summary>
        /// Поле стоимости предмета.
        /// </summary>
        private double _cost;


        /// <summary>
        /// Возвращает и задает id товара.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                Validator.AssertEmptyValue(value, nameof(Name));
                Validator.AssertLengthString(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает информацию о товаре.
        /// Не больше 1000 символов.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                Validator.AssertLengthString(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара.
        /// От 0 до 100000.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                Validator.AssertValueInRange(value, 0, 100_000, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="description">Информация о товаре</param>
        /// <param name="cost">Стоимость товара.</param>
        public Item(string name, string info, double cost)
        {
            _allItemsCount++;
            _id = _allItemsCount;
            Name = name;
            Info = info;
            Cost = cost;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _allItemsCount++;
            _id = _allItemsCount;
        }
    }
}
