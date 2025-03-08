using System;
using System.Globalization;

namespace bc1155
{
    class Program
    {
        static void Main(string[] args)
        {
            double Soma = 0.0;

            for (int i = 1; i <= 100; i++)
            {
                Soma += 1.0 / Convert.ToDouble(i);
            }
            Console.WriteLine(Soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
