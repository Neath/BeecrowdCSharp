using System;

namespace bc1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{num} {num+1} {num+2} PUM");
                num += 4;
            }
        }
    }
}
