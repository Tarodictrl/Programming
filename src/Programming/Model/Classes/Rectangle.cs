using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private readonly int _id;

        private int _length;
        
        private int _width;
        
        public Rectangle()
        {
        }

        public Rectangle(int length, int width, string color, int id)
        {
            Length = length;
            Color = color;
            Width = width;
            _id = id;
        }

        public int Length
        {
            get 
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
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

        public string Color { get; set; }
    }
}
