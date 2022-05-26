using System;

namespace BuildingsApp.Model
{
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
    }
}
