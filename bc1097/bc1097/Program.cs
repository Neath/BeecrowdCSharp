using System;

namespace bc1097
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 7;
            for (int i = 1; i < 10; i += 2)
            {
                for (int j = aux; j > aux-3; j--)
                {
                    Console.WriteLine($"I={i} J={j}");                    
                }
                aux += 2;
            }
        }
    }
}
