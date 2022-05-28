using System.Drawing;

namespace BuildingsApp.Model
{
    /// <summary>
    /// Хранит данные об используемых цветах.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        public static Color CorrectColor = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        public static Color ErrorColor = Color.FromArgb(255, 182, 193);
    }
}