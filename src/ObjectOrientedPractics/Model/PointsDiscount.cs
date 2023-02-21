using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class PointsDiscount : IDiscount
    {
        private int _points;

        public PointsDiscount()
        {

        }
        
        /// <summary>
        /// Возвращает и задаёт скидку. Число не меньше нуля.
        /// </summary>
        public int Points
        {
            get { return _points; }
            set 
            {
                Validator.AssertOnPositiveValue(nameof(Points), value);
                _points = value; 
            }
        }

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get 
            {
                return $"Накопительная - {Points} баллов";
            }
        }

        /// <summary>
        /// Высчитывает скидку на товары.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Стоимость с учетом скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double amount = 0;
            foreach (var item in items)
            {
                amount += item.Cost;
            }
            if (_points <= (int)(amount * 0.3))
            {
                return _points;
            }
            if (_points > (int)(amount * 0.3))
            {
                return Math.Ceiling(amount * 0.3);
            }

            return 0;
        }

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возвращает скидку.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            _points -= (int)discount;
            return discount;
        }

        /// <summary>
        /// Накапливает скидку.
        /// </summary>
        /// <param name="items">Товары.</param>
        public void Update(List<Item> items)
        {
            double amount = 0;
            foreach (var item in items)
            {
                amount += item.Cost;
            }

            _points += (int)Math.Ceiling(amount * 0.1);
        }
    }
}
