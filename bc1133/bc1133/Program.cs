using System;

namespace bc1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int Min = Math.Min(X, Y);
            int Max = Math.Max(X, Y);

            for (int i = Min+1; i < Max; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                    Console.WriteLine(i);
            }
        }
    }
}
