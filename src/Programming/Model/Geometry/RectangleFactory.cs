using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = Programming.Model.Rectangle;
using Point2D = Programming.Model.Geometry.Point2D;


namespace Programming.Model.Geometry
{
    public static class RectangleFactory
    {
        private static readonly Random _random = new Random();
        public static Rectangle Randomize(int width, int height)
        {
            var rectangleHeight = _random.Next(10, 100);
            var rectangleWidth = _random.Next(10, 100);
            var rectangleX = _random.Next(_random.Next(1, width - 100 - 15));
            var rectangleY = _random.Next(_random.Next(1, height - 100 + 15));
            var rectanglePosition = new Point2D(rectangleX, rectangleY);

            return new Rectangle(
                rectangleHeight,
                rectangleWidth,
                "Green",
                rectanglePosition
                );
        }
    }
}