﻿using System;
using Programming.Model.Enums;

namespace Programming.Model.Geometry
{
    public static class RectangleFactory
    {
        private static readonly int Margin = 15;

        private static readonly Random _random = new Random();
        public static Rectangle Randomize(int canvasWidth, int canvasHeight)
        {
            var rectangleHeight = _random.Next(10, 50);
            var rectangleWidth = _random.Next(10, 50);
            var rectangleX = _random.Next(Margin, canvasWidth - rectangleWidth - Margin - 100);
            var rectangleY = _random.Next(Margin, canvasHeight - rectangleHeight - Margin - 100);
            var rectanglePosition = new Point2D(rectangleX, rectangleY);
            var color = "Green";

            return new Rectangle(
                rectangleHeight,
                rectangleWidth,
                color,
                rectanglePosition
                );
        }

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