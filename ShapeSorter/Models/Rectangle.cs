using System;

namespace ShapeSorter.Models
{
    public class Rectangle : Shape
    {
        private float height;
        private float width;

        public Rectangle(float height, float width)
        {
            if (height < 0) throw new ArgumentException($"{nameof(height)} should be non negative");
            if (height < 0) throw new ArgumentException($"{nameof(width)} should be non negative");

            this.height = height;
            this.width = width;
        }

        public override float Area => height * width;

        public override ShapeName ShapeName 
        {
            get 
            {
                if (height > width)
                {
                    return ShapeName.Tall;
                }

                if (height < width)
                {
                    return ShapeName.Flat;
                }

                return ShapeName.Square;
            } 
        }
    }
}