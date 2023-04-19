using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View.Services
{
    /// <summary>
    /// Хранит логику для преобразования значений.
    /// </summary>
    public class VisibleConverter : IValueConverter
    {
        /// <summary>
        /// Конвертирует булевое значение
        /// в соотвествующие значение из перечисления <see cref="Visibility"/>.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="targetType">Целевой тип.</param>
        /// <param name="parameter">Параметр.</param>
        /// <param name="culture">Региональная культура</param>
        /// <returns>Значение из перечисления <see cref="Visibility"/>.</returns>
        public object Convert(object value,
                              Type targetType,
                              object parameter,
                              CultureInfo culture)
        {
            var asBool = (bool)value;
            return asBool ? Visibility.Visible : Visibility.Hidden;
        }

        /// <summary>
        /// Конвертирует значение из перечисления <see cref="Visibility"/>
        /// в соотвествующие булевое значение.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="targetType">Целевой тип.</param>
        /// <param name="parameter">Параметр.</param>
        /// <param name="culture">Региональная культура</param>
        /// <returns>Булевое значение.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var asVisibility = (Visibility)value;
            return true ? asVisibility == Visibility.Visible : false;
        }
    }
}