using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Circle : Shape
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return 3.14*radius*radius;
        }

        public override double Perimeter()
        {
            return 2 * 3.14 * radius;
        }
    }
}
