using System;

namespace bc1101
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string[] aux = Console.ReadLine().Split(' ');
                int M = int.Parse(aux[0]);
                int N = int.Parse(aux[1]);
                int sum = 0;

                if (M <= 0 || N <= 0)
                    break;

                for (int i = Math.Min(M, N); i <= Math.Max(M, N); i++)
                {
                    sum += i;
                    Console.Write(i + " ");                   
                }
                Console.WriteLine("Sum=" + sum);
            }
        }
    }
}
