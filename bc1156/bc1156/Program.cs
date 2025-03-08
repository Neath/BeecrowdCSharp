using System;
using System.Globalization;


namespace bc1156
{
    class Program
    {
        static void Main(string[] args)
        {
            double Soma = 0.0;

            for (int i = 1, j = 1; i < 40; i += 2, j *= 2)
            {
                Soma += (Convert.ToDouble(i) / Convert.ToDouble(j));
            }
            Console.WriteLine(Soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
