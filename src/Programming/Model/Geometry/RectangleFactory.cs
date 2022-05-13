using Programming.Model.Enums;
using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Статический класс создания прямоугольников.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Отступ от краёв внутри панели.
        /// </summary>
        private static readonly int Margin = 15;

        /// <summary>
        /// Поле, которое представляет генератор случайных чисел.
        /// </summary>
        private static readonly Random _random = new Random();

        /// <summary>
        /// Создаёт прямоугольник со случайными значениями.
        /// </summary>
        /// <param name="canvasWidth">Граница создания по ширине.</param>
        /// <param name="canvasHeight">Граница создания по высоте.</param>
        /// <returns>Возвращает экземпляр Rectangle со случайными значениями.</returns>
        public static Rectangle Randomize(int canvasWidth, int canvasHeight)
        {
            var rectangleHeight = _random.Next(10, 50);
            var rectangleWidth = _random.Next(10, 50);
            var rectangleX = _random.Next(Margin, canvasWidth - rectangleWidth - Margin);
            var rectangleY = _random.Next(Margin, canvasHeight - rectangleHeight - Margin);
            var rectanglePosition = new Point2D(rectangleX, rectangleY);
            var color = "Green";

            return new Rectangle(
                rectangleHeight,
                rectangleWidth,
                color,
                rectanglePosition
                );
        }

        /// <summary>
        /// Создаёт прямоугольник со случайными значениями.
        /// </summary>
        /// <returns>Возвращает экземпляр Rectangle со случайными значениями.</returns>
        public static Rectangle Randomize()
        {
            var colors = Enum.GetValues(typeof(Colors));
            Rectangle rectangle = new Rectangle();
            rectangle.Center = new Point2D(_random.Next(1, 500), _random.Next(1, 500));
            rectangle.Width = _random.Next(30, 100);
            rectangle.Height = _random.Next(30, 100);
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }
    }
}