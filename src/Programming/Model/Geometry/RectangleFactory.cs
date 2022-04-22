using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = Programming.Model.Classes.Rectangle;
using Point2D = Programming.Model.Classes.Point2D;


namespace Programming.Model.Geometry
{
    public static class RectangleFactory
    {
        public static Rectangle Randomize()
        {
            Random random = new Random();
            var rectangleHeight = random.Next(0, 200);
            var rectangleWidth = random.Next(0, 100);
            var rectangleX = random.Next(0, 425);
            var rectangleY = random.Next(0, 425);
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