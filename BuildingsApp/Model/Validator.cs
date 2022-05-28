using System;
using System.Windows.Forms;

namespace BuildingsApp.Model
{
    /// <summary>
    /// Предоставляет методы для проверки данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что строка состоит только из букв английского алфавита.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Ошибка, когда в строке есть цифры или буквы не английского алфавита.</exception>
        public static void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            foreach (var i in value)
            {
                if (!char.IsLetter(i))
                {
                    throw new ArgumentException(
                        $"{propertyName} must consist only of letters");
                }
            }
        }

        /// <summary>
        /// Проверяет, что строка состоит только из цифр.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Ошибка, когда в строке есть другие символы.</exception>
        public static void AssertStringContainsOnlyNumbers(string value, string propertyName)
        {
            if (!long.TryParse(value, out _))
            {
                throw new ArgumentException(
                    $"{propertyName} must consist only of numbers");
            }
        }

        /// <summary>
        /// Проверяет, что число является положительным.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Ошибка, когда число меньше или равно нулю.</exception>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"{propertyName} must be greater than 0");
            }
        }

        /// <summary>
        /// Проверяет, что число лежит в диапазоне.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Ошибка, если число находится вне диапазона.</exception>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"{propertyName} must be in range ({min} to {max})");
            }
        }

        /// <summary>
        /// Проверяет, что число является положительным.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Ошибка, когда число меньше или равно нулю.</exception>
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"{propertyName} must be greater than 0");
            }
        }

        /// <summary>
        /// Проверяет, что число лежит в диапазоне.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Ошибка, если число находится вне диапазона.</exception>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"{propertyName} must be in range ({min} to {max})");
            }
        }

        /// <summary>
        /// Проверяет, что все поля данных заполнены правильно.
        /// </summary>
        /// <param name="textBox1">Первый TextBox</param>
        /// <param name="textBox2">Второй TextBox</param>
        /// <param name="textBox3">Третий TextBox</param>
        /// <param name="comboBox">Первый ComboBox</param>
        /// <returns>true, если все поля заполнены правильно,
        ///          false, если в полях есть ошибка.</returns>
        public static bool AssertCorrectText(TextBox textBox1, TextBox textBox2, TextBox textBox3, ComboBox comboBox)
        {
            return (textBox1.BackColor == AppColors.CorrectColor) &&
                   (textBox2.BackColor == AppColors.CorrectColor) &&
                   (textBox3.BackColor == AppColors.CorrectColor) &&
                   (textBox1.Text != "") &&
                   (textBox2.Text != "") &&
                   (textBox3.Text != "") &&
                   (comboBox.SelectedIndex != -1);
        }
    }
}
