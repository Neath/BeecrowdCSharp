using System;
using System.Globalization;

namespace bc1043
{
    class Program
    {
        static bool IsTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            else
                return false;
        }

        static double Area(double a, double b, double c)
        {
            return (((a + b) * c) / 2.0);
        }

        static double Perimeter(double a, double b, double c)
        {
            return (a + b + c);

        }

        static void Main(string[] args)
        {
            string[] aux = Console.ReadLine().Split(' ');
            double A = double.Parse(aux[0], CultureInfo.InvariantCulture);
            double B = double.Parse(aux[1], CultureInfo.InvariantCulture);
            double C = double.Parse(aux[2], CultureInfo.InvariantCulture);
            if (IsTriangle(A, B, C))
            {
                Console.WriteLine("Perimetro = " + Perimeter(A, B, C).ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Area = " + Area(A, B, C).ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
