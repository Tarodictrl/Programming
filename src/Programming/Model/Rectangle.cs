using System.Drawing;
using Programming.Model.Geometry;

namespace Programming.Model
{
    public class Rectangle
    {
        private static int _allRectanglesCount;

        private readonly int _id;

        private int _height;
        
        private int _width;
        
        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Rectangle(int height, int width, string colour, Point2D center)
        {
            Height = height;
            Colour = colour;
            Width = width;
            Center = center;
            _allRectanglesCount++;
            _id = AllRectanglesCount;
        }

        public int Height
        {
            get 
            {
                return _height;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Height));
                _height = value;
            }
        }

        public int Width
        {
            get
            { 
                return _width; 
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public override string ToString()
        {
            return $"Rectangle {_id}";
        }

        public string GetRectangleInfo()
        {
            return $"{_id}: (X={Center.X}; Y={Center.Y}; W={_width}; H={_height})";
        }

        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }

        public string Colour { get; set; }

        public Point2D Center { get; set; }
    }
}
