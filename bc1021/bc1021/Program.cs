using System;
using System.Globalization;

namespace bc1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int valor = (int)Math.Round(num * 100);


            Console.WriteLine("NOTAS:");

            int notascem = valor / 10000;
            valor %= 10000;
            Console.WriteLine(notascem + " nota(s) de R$ 100.00");

            int notascinq = valor / 5000;
            valor %= 5000;
            Console.WriteLine(notascinq + " nota(s) de R$ 50.00");

            int notasvint = valor / 2000;
            valor %= 2000;
            Console.WriteLine(notasvint + " nota(s) de R$ 20.00");

            int notasdez = valor / 1000;
            valor %= 1000;
            Console.WriteLine(notasdez + " nota(s) de R$ 10.00");

            int notascinc = valor / 500;
            valor %= 500;
            Console.WriteLine(notascinc + " nota(s) de R$ 5.00");

            int notasdois = valor / 200;
            valor %= 200;
            Console.WriteLine(notasdois + " nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");

            int umreal = valor / 100;
            valor %= 100;
            Console.WriteLine(umreal + " moeda(s) de R$ 1.00");

            int moedacinq = valor / 50;
            valor %= 50;
            Console.WriteLine(moedacinq + " moeda(s) de R$ 0.50");

            int moedavint = valor / 25;
            valor %= 25;
            Console.WriteLine(moedavint + " moeda(s) de R$ 0.25");

            int moedadez = valor / 10;
            valor %= 10;
            Console.WriteLine(moedadez + " moeda(s) de R$ 0.10");

            int moedacinc = valor / 5;
            valor %= 5;
            Console.WriteLine(moedacinc + " moeda(s) de R$ 0.05");

            int umcent = valor;
            Console.WriteLine(umcent + " moeda(s) de R$ 0.01");
        }
    }
}
