using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ComplexDataStructure
{
    public struct Coffee
    {        
        public string Name { get; set; }
        public string Bean { get; set; }
        public string CountryOfOrigin { get; set; }
        public int Strength { get; set; }
    }

    class StructDemo
    {
        public void StructExample()
        {
            Coffee coffee = new Coffee();
            coffee.Name = "Fourth Coffee Quencher";
            coffee.CountryOfOrigin = "Indonesia";
            coffee.Strength = 3;

            Console.WriteLine("Name: {0}", coffee.Name);
            Console.WriteLine("Country Of Origin: {0}", coffee.CountryOfOrigin);
            Console.WriteLine("Strength: {0}", coffee.Strength);
        }        
    }
}
