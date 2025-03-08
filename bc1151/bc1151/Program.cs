using System;

namespace bc1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int primeiro = 0;
            int segundo = 1;
            int result = primeiro + segundo;

            if (N == 1)
            {
                Console.Write(primeiro);
            }
            else if (N == 2)
            {
                Console.Write($"{primeiro} {segundo}");
            }
            else
            {
                Console.Write($"{primeiro} {segundo}");
                for (int i = 2; i < N; i++)
                {
                    result = primeiro + segundo;
                    primeiro = segundo;
                    segundo = result;
                    Console.Write(" " + result);
                }
            }
            Console.WriteLine();
        }
    }
}
