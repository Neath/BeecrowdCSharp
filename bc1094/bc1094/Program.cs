using System;
using System.Globalization;

namespace bc1094
{
    class Program
    {
        static int Ratos = 0;
        static int Sapos = 0;
        static int Coelhos = 0;
        static void StoreData(int qtd, char tipo)
        {
            if (tipo == 'C')
                Coelhos += qtd;
            else if (tipo == 'R')
                Ratos += qtd;
            else if (tipo == 'S')
                Sapos += qtd;
        }

        static double AnimalPercent(int qtd, int total)
        {
            double percent = Convert.ToDouble(qtd)/Convert.ToDouble(total);
            return percent*100;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                int Qtd = int.Parse(aux[0]);
                char Tipo = char.Parse(aux[1]);
                StoreData(Qtd, Tipo);
            }

            int TotalCobaias = (Ratos + Sapos + Coelhos);
            Console.WriteLine("Total: " + TotalCobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + Coelhos);
            Console.WriteLine("Total de ratos: " + Ratos);
            Console.WriteLine("Total de sapos: " + Sapos);
            Console.WriteLine("Percentual de coelhos: " + AnimalPercent(Coelhos, TotalCobaias).ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + AnimalPercent(Ratos, TotalCobaias).ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + AnimalPercent(Sapos, TotalCobaias).ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}
