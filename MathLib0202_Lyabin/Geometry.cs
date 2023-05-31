using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib0202_Lyabin
{
    public class Geometry
    {
        public static double FindTriangleArea(double length, double height)
        {
            return length * height / 2;
        }

            
        public static double FindRightTriangleArea(double length, double height)
        {
            return length * height / 2;
        }

        public static double FindRectangleArea(double length, double width)
        {
            return length * width;
        }

        public static double FindCircleArea(double radius)
        {
            return 3.14 * radius * radius;
        }

        public static double FindTrapezoidArea(double base1, double base2, double height)
        {
            return (base1 + base2) * height / 2;
        }
        

    }
}
