using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int _count;
        private int _length;
        private int _width;
        private string _color;
        
        public Rectangle()
        {
            _count++;
        }

        public Rectangle(int length, int width, string color)
        {
            _count++;
            Length = length;
            Color = color;
            Width = width;
        }

        public int Length
        {
            get 
            {
                return _length;
            }
            set
            {
                if (value < 0)
                {
                    _length = 0;
                    throw new ArgumentException("The length cannot be less than zero.");
                }

                _length = value;
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
                if (value < 0)
                {
                    _width = 0;
                    throw new ArgumentException(
                        "The width cannot be less than zero.");
                }
                _width = value;
            }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public override string ToString()
        {
            return $"Rectangle {_count}";
        }
    }
}
