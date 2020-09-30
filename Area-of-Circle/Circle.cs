using System;
using System.Collections.Generic;
using System.Text;

namespace Area_of_Circle
{
    class Circle
    {
        public static double CalcArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        } // CalcArea

        public static double CalcCircumference(double radius)
        {
            return 2 * Math.PI * radius;

        } // CalcCircumference

        public static double CalcDiameter(double radius)
        {
            return 2 * radius;
        } // CalcDiameter

    }
}
