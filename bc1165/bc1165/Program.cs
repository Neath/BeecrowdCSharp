using System;
using static bc1165.Checker;

namespace bc1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int Num = int.Parse(Console.ReadLine());

                if (PrimeCheck(Num) == true)
                    Console.WriteLine(Num + " eh primo");
                else
                    Console.WriteLine(Num + " nao eh primo");
            }
        }
    }
}
