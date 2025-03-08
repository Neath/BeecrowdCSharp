using System;
using System.Globalization;

namespace bc1051
{
    class Program
    {
        static void Taxation(double salary)
        {
            double finaltax = 0.0;
            double aux = 0.0;
            double tax = 0.0;

            if (salary <= 3000.0)
            {
                aux = salary - 2000.0;
                finaltax = aux * 0.08;
            }
            else if (salary <= 4500.0)
            {
                aux = salary - 3000.0;
                tax = aux * 0.18;
                finaltax = tax + 80.0;
            }
            else
            {
                aux = salary - 4500.0;
                tax = aux * 0.28;
                finaltax = tax + 350.0;
                
            }
            Console.WriteLine("R$ " + finaltax.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void Main(string[] args)
        {
            double Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (Salary <= 2000.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Taxation(Salary);
            }
        }
    }
}
