using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeSorter.Models;

namespace ShapeSorter.Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Ctor_ShouldbeAbleToConstruct_WithHeighthAndWidth()
        {
            var rectangle = new Rectangle(10, 10);
            Assert.IsNotNull(rectangle);
        }

        [TestMethod]
        public void Ctor_ShouldbeAbleToConstruct_WithHeighthAndWidthDecimalPlaces()
        {
            var rectangle = new Rectangle(10.10f, 10.123f);
            Assert.IsNotNull(rectangle);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Ctor_ShouldNotAcceptNegativeValues()
        {
            new Rectangle(-10.10f, -10.123f);
        }

        [TestMethod]
        public void Area_ShouldCalculateAreaFromLengthWidth()
        {
            var rectangle = new Rectangle(10, 10);
            Assert.AreEqual(100, rectangle.Area);
        }

        [TestMethod]
        public void ToString_WhenHeigthIsGreaterThanWidth_ShouldGetTall()
        {
            var rectangle = new Rectangle(11, 10);
            Assert.AreEqual(ShapeName.Tall, rectangle.ShapeName);
        }

        [TestMethod]
        public void ToString_WhenHeigthIsLesserThanWidth_ShouldGetFlat()
        {
            var rectangle = new Rectangle(9, 10);
            Assert.AreEqual(ShapeName.Flat, rectangle.ShapeName);
        }

        [TestMethod]
        public void ToString_WhenHeigthIsEqualToWidth_ShouldGetSquare()
        {
            var rectangle = new Rectangle(10, 10);
            Assert.AreEqual(ShapeName.Square, rectangle.ShapeName);
        }
    }
}
