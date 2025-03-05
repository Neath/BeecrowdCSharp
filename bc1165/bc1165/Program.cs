using System;

namespace bc1165
{
    class Program
    {
        static bool PrimeCheck(int num)
        {
            for (int i = 2; i < (num - 1); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int Num = int.Parse(Console.ReadLine());
                bool IsPrime = PrimeCheck(Num);

                if (IsPrime == true)
                    Console.WriteLine(Num + " eh primo");
                else
                    Console.WriteLine(Num + " nao eh primo");
            }
        }
    }
}
