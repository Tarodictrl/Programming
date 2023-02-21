using ObjectOrientedPractics.Services;
using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    public class Item
    {
        public event EventHandler<EventArgs> NameChanged;

        public event EventHandler<EventArgs> CostChanged;

        public event EventHandler<EventArgs> InfoChanged;
        
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Все товары.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>
        /// </summary>
        public Item()
        {
            _allItemsCount++;
            _id = _allItemsCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name">Название товара. Должно быть не более 200 символов.</param>
        /// <param name="info">Описание товара. Должно быть не более 1000 символов.</param>
        /// <param name="cost">Стоимость товара. Должна быть в пределах от 0 до 100000.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            _allItemsCount++;
            _id = _allItemsCount;
        }

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает уникальный идентификатор песни.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Возвращает и задаёт название товара. Должно быть не более 200 символов.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                Validator.AssertStringOnLength(nameof(Name), value, 200);
                if (_name != value)
                {
                    _name = value;
                    NameChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт описание товара. Должно быть не более 1000 символов.
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                Validator.AssertStringOnLength(nameof(Info), value, 1000);
                if (_info != value)
                {
                    _info = value;
                    InfoChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара. Должно быть в пределах от 0 до 100000.
        /// </summary>
        public double Cost
        {
            get => _cost;
            set
            {
                Validator.AssertValueInRange(nameof(Cost), value, 0, 100000);
                if (_cost != value)
                {
                    _cost = value;
                    CostChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
