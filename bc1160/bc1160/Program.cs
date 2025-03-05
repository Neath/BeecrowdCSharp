using System;
using System.Globalization;

namespace bc1160
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int PA, PB, AGrowth, BGrowth;
            double G1, G2;
            string[] aux;

            for (int i = 0; i < T; i++)
            {
                aux = Console.ReadLine().Split(' ');
                PA = int.Parse(aux[0]);
                PB = int.Parse(aux[1]);
                G1 = double.Parse(aux[2], CultureInfo.InvariantCulture);
                G2 = double.Parse(aux[3], CultureInfo.InvariantCulture);

                AGrowth = PA;
                BGrowth = PB;

                int anos = 0;
                while (AGrowth <= BGrowth)
                {
                    AGrowth += (int)(AGrowth * (G1 / 100));
                    BGrowth += (int)(BGrowth * (G2 / 100));
                    anos++;

                    if (anos > 100)
                        break;
                }
                if (anos > 100)
                    Console.WriteLine("Mais de 1 seculo.");
                else
                    Console.WriteLine(anos + " anos.");
            }
        }
    }
}
