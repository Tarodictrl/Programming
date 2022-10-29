namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет функционал для проверки входных значений.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, находится ли число в заданном диапазоне.
        /// </summary>
        /// <param name="value">Число для проверки.</param>
        /// <param name="min">Левая граница диапазона(включительно).</param>
        /// <param name="max">Правая граница диапазона(включительно).</param>
        /// <param name="propertyName">Имя свойства, из которого был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число
        /// выходит за границы диапазона</exception>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min | value > max)
            {
                throw new ArgumentException($"Выход за диапазон значений в поле: {propertyName}");
            }
        }

        /// <summary>
        /// Проверяет переданную строку на кол-во символов.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="maxLength">Максимальная длина строки.</param>
        /// <param name="propertyName">Имя метода.</param>
        /// <exception cref="ArgumentException">Если строка оказалась длиннее чем заданное
        /// максимальное значения длины.</exception>
        public static void AssertLengthString(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"Строка превышает максимальную длину: " +
                                            $"{maxLength} в поле {propertyName}.");
            }
        }

        /// <summary>
        /// Проверяет является ли переданная строка пустой.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <exception cref="ArgumentException">Если строка оказалась пустой.</exception>
        public static void AssertEmptyValue(string value, string propertyName)
        {
            if (value == "")
            {
                throw new ArgumentException($"Строка не может быть пустой в поле {propertyName}");
            }
        }
    }
}