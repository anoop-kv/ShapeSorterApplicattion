using ShapeSorter.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShapeSorter
{
    public class ShapeSorter<T> where T : Shape
    {
        public IEnumerable<T> SortByArea(IEnumerable<T> shapes)
        {
            return shapes.OrderBy(s => s.Area);
        }
    }
}
