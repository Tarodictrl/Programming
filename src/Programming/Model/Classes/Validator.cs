using System;

namespace Programming.Model.Classes
{
    public static class Validator
    {
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

        public static bool ContainsOnlyLetters(string value)
        {
            foreach (var i in value)
            {
                if (!char.IsLetter(i))
                {
                    return false;
                }
            }

            return true;
        }

        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    $"{propertyName} must be greater than 0");
            }
        }

        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"{propertyName} must be in range ({min} to {max})");
            }
        }

        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    $"{propertyName} must be greater than 0");
            }
        }

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
