using System;

namespace SquareLibrary
{
    public static class Square
    {
        // function for compute area
        public static double SquareArea(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("Number should be > 0");

            }
            return width * height;
        }
        // function for compute triangle's area
        public static double SquareOfTriangle(this double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Number should be > 0");
            }
            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                return 1 / 2.0 * b * c;
            }
            else if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
            {
                return 1 / 2.0 * a * c;
            }
            else if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                return 1 / 2.0 * a * b;
            }
            else 
            {
                double halfPerimetr;
                halfPerimetr = (a + b + c) / 2;
                return Math.Sqrt(halfPerimetr * (halfPerimetr - a) * (halfPerimetr - b) * (halfPerimetr - c));
            }
        }
        // function for compute circle's area
        public static double SquareOfCircle(this double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Number should be > 0");
            }
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
