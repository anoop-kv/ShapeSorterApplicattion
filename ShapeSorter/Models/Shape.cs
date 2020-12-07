namespace ShapeSorter.Models
{
    public abstract class Shape
    {
        public abstract float Area { get; }

        public abstract ShapeName ShapeName { get; }
    }
}
