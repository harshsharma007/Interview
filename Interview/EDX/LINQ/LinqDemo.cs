using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Interview.EDX.LINQ
{
    class LinqDemo
    {
        private void LinqMain()
        {
            LinqSamples linqSamples = new LinqSamples();
            linqSamples.LinqOne(); // This sample uses the where clause to find all elements less than 5.
        }
    }

    class LinqSamples
    {
        private List<Product> productList;

        [Description("This sample uses the where clause to find all elements of an array")]
        public void LinqOne()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var lowNums = from num in numbers where num < 5 select num;

            Console.WriteLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
        }

        [Description("This sample uses the where clause to find all products that are sold out")]
        public void LinqTwo()
        {
            List<Product> products = new List<Product>();
            var soldOutProducts = from prod in products where prod.UnitsInStock == 0 select prod;

            Console.WriteLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                Console.WriteLine("{0} is sold out!", product.ProductName);
            }
        }

        [Description("This sample uses orderby to sort a list of words alphabetically!")]
        public void LinqThree()
        {
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords = from word in words orderby word select word;

            Console.WriteLine("The sorted list of words:");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }
        }

        [Description("This sample uses orderby to sort a list of words by length")]
        public void LinqFour()
        {
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords = from word in words orderby word.Length select word;

            Console.WriteLine("The sorted list of words (by length):");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }
        }

        private List<Product> GetProductList()
        {
            if (productList == null)
                CreateList();

            return productList;
        }

        private void CreateList()
        {
            // Product data created in-memory using collection
            productList = new List<Product>
            {
                new Product{ ProductID = 1, ProductName = "Chai", Category = "Beverage", UnitPrice = (decimal)10.0, UnitsInStock = 1 }
            };
        }
    }

    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
