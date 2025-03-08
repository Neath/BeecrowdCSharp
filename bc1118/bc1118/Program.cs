using System;
using System.Globalization;

namespace bc1118
{
    class Program
    {
        static void ScoreCalc()
        {
            double avg = 0.0;
            double first = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (first < 0.0 || first > 10.0)
            {
                Console.WriteLine("nota invalida");
                first = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double second = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (second < 0.0 || second > 10.0)
            {
                Console.WriteLine("nota invalida");
                second = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            avg = (first + second) / 2.0;
            Console.WriteLine("media = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void Main(string[] args)
        {
            ScoreCalc();
            while (true)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                int answr = int.Parse(Console.ReadLine());

                if (answr < 1 || answr > 2)
                    continue;

                if (answr == 2)
                    break;

                ScoreCalc();
            }
        }
    }
}
