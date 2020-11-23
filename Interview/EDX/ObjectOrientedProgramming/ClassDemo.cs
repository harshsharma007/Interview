using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.EDX.ObjectOrientedProgramming
{
    class ClassDemo
    {
        public void MainMethod()
        {
            DrinksMachine drinksMachine = new DrinksMachine("Kitchen", "Brand", "DM1000");
            //drinksMachine.Location = "Kitchen";
            //drinksMachine.Model = "DM1000";
            //drinksMachine.Make = "DM";
            Console.WriteLine(drinksMachine.Location);
            Console.WriteLine(drinksMachine.Make);
            Console.WriteLine(drinksMachine.Model);
            drinksMachine.MakeCappuccino();
        }
    }
}
