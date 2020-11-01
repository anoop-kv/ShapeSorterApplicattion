using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeSorter.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShapeSorter.Tests
{
    [TestClass]
    public class ShapeSorterTests
    {
        [TestMethod]
        public void SortByArea_ShouldAcceptListOfRectangles()
        {
            var sorter = new ShapeSorter<Rectangle>();
            sorter.SortByArea(new List<Rectangle>());
        }

        [TestMethod]
        public void SortByArea_GivenAList_ShouldSortByArea()
        {
            var sorter = new ShapeSorter<Rectangle>();
            var result = sorter.SortByArea(new List<Rectangle> {  new Rectangle(11, 11), new Rectangle(10, 10)  } ).ToList();

            Assert.IsTrue(result.First().Area == 100);
        }
    }
}
