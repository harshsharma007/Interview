using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.ObjectOrientedProgramming
{
    class ClassDemo
    {
        public void MainMethod()
        {
            DrinksMachine drinksMachine = new DrinksMachine();
            drinksMachine._location = "Kitchen";
            drinksMachine._model = "DM1000";
            drinksMachine._make = "DM";
            drinksMachine.MakeCappuccino();
        }
    }
}
