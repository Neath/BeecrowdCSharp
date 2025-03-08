using System;
using System.Globalization;

namespace bc1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int QtdPos = 0;
            for (int i = 0; i < 6; i++)
            {
                double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (num > 0.0)
                    QtdPos++;
            }
            Console.WriteLine(QtdPos + " valores positivos");
        }
    }
}
