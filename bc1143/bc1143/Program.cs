using System;

namespace bc1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{i} {i*i} {i*i*i}");
            }
        }
    }
}
