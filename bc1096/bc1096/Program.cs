using System;

namespace bc1096
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i += 2)
            {
                for (int j = 7; j > 4; j--)
                {
                    Console.WriteLine($"I={i} J={j}");
                }
            }
        }
    }
}
