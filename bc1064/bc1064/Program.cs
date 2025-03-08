using System;
using System.Globalization;

namespace bc1064
{
    class Program
    {
        static void Main(string[] args)
        {
            int QtdPos = 0;
            double SomaPos = 0.0;
            for (int i = 0; i < 6; i++)
            {
                double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (num > 0.0)
                {
                    SomaPos += num;
                    QtdPos++;
                }
            }
            double MediaPos = (double)(SomaPos / QtdPos);
            Console.WriteLine(QtdPos + " valores positivos");
            Console.WriteLine(MediaPos.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
