using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    class OpenClosedPrinciple
    {
        /*
            The open/closed principle says "A software module/class is open for extension and closed for modification".
            Here "Open for extension" means, we need to design our module/class in such a way that the new functionality can be added only when new requirements
            are generated. "Closed for modification" means we have already developed a class and it has gone through unit testing. We should then not alter it until we 
            find bugs. As it says, a class should be open for extensions, we can use inheritance to do this.
        */
    }

    class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }
    }

    class AreaCalculator
    {
        public double TotalArea(Rectangle[] arrRectangles)
        {
            double area = 0;
            foreach (var objRectangle in arrRectangles)
            {
                area += objRectangle.Height * objRectangle.Width;
            }
            return area;
        }
        //We made our code without violating SRP. But, what if we want to calculate the area of a circle? How should we extend the class in this case?
    }

    //Rectangle class remains the same.
    class Circle
    {
        public double Radius { get; set; }
    }

    class AreaCalculatorModified
    {
        public double TotalArea(object[] arrObjects)
        {
            double area = 0;
            Rectangle objRectangle;
            Circle objCircle;
            foreach (var obj in arrObjects)
            {
                if (obj is Rectangle)
                {
                    objRectangle = (Rectangle)obj;
                    area += objRectangle.Height * objRectangle.Width;
                }
                else
                {
                    objCircle = (Circle)obj;
                    area = objCircle.Radius * objCircle.Radius * Math.PI;
                }
            }
            return area;
        }
        /*
            Here we have introduced circle successfully. But, if we want to calculate the area of a triangle, then we again have to introduce if statement for it.
            This means that the class is not closed for modification. This can be fixed by introducing abstract class.
        */
    }

    //Actual implementation of OCP
    public abstract class Shape
    {
        public abstract double Area();
    }

    class NewRectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double Area()
        {
            return Height * Width;
        }
    }

    class NewCircle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }

    class NewAreaCalculator
    {
        public double TotalArea(Shape[] arrShapes)
        {
            double area = 0;
            foreach (var objShape in arrShapes)
            {
                area += objShape.Area();
            }
            return area;
        }
    }

    /*
        Now our code is following SRP and OCP both. Whenever you introduce a new shape by deriving from the "Shape" abstract class, you need not change the
        "AreaCalculator" class.
    */
}
