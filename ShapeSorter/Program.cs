using ShapeSorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapeSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangles = new List<Rectangle>();

            Console.Write("Enter the number of rectangles : ");
            var count = ReadIntiger();

            for (int i = 0; i < count; i++)
            {
                Console.Clear();
                Console.Write($"Enter the heigth of rectangle {i + 1} : ");
                var height = ReadDecimal();

                Console.Write($"Enter the width of rectangle {i + 1} : ");
                var width = ReadDecimal();

                rectangles.Add(new Rectangle(height, width));
            }

            Console.Clear();
            Console.WriteLine($"---Sorted rectangles are ----");
            var shapeSorter = new ShapeSorter<Rectangle>();
            var sortedRectangles = shapeSorter.SortByArea(rectangles);

            sortedRectangles.ToList().ForEach(r => Console.WriteLine(r));
        }

        private static decimal ReadDecimal()
        {
            decimal number;
            while (!decimal.TryParse(Console.ReadLine(), out number))
            {
                Console.Write($"Invalid input ! Please enter valid value : ");
            }
            return number;
        }

        private static int ReadIntiger()
        {
            int number;
            while (!Int32.TryParse(Console.ReadLine(), out number))
            {
                Console.Write($"Invalid input ! Please enter valid value : ");
            }
            return number;
        }
    }
}
