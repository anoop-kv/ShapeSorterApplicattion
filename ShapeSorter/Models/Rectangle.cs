using System;

namespace ShapeSorter.Models
{
    public class Rectangle : Shape
    {
        private decimal height;
        private decimal width;

        public Rectangle(decimal height, decimal width)
        {
            if (height < 0) throw new ArgumentException($"{nameof(height)} should be non negative");
            if (height < 0) throw new ArgumentException($"{nameof(width)} should be non negative");

            this.height = height;
            this.width = width;
        }

        public override decimal Area => height * width;

        public override string ToString()
        {
            if (height > width)
            {
                return "Tall";
            }

            if (height < width)
            {
                return "Flat";
            }

            return "Square";
        }
    }
}
