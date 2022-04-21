using System;

namespace Programming.Model.Classes
{
    public class Ring
    {
        private double _outerRadius;

        private double _innerRadius;

        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }

        public Point2D Center { get; set; }

        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                Validator.AssertValueInRange(value, _innerRadius, double.MaxValue, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                Validator.AssertValueInRange(value, 0, _outerRadius, nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * (_outerRadius * _outerRadius - _innerRadius * _innerRadius);
            }
        }
    }
}
