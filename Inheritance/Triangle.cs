using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Triangle : Shape
    {
        private double bas, height,side1,side2,side3;

        public Triangle(double bas,double height)
        {
            this.bas = bas;
            this.height = height;
        }
        public Triangle(double side1,double side2,double side3)
        {
            this.side1 = side1;
            this.side2=side2;
            this.side3=side3;
        }
        public override double CalculateArea()
        {
            return (bas*height)/2;
        }

        public override double Perimeter()
        {
            return (side1+side2+side3);
        }
    }
}
