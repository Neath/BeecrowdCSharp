using System;

namespace bc1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int aux = N;

            for (int i = 1; i < aux; i++)
            {
                N = N*(aux - i);
            }
            Console.WriteLine(N);
        }
    }
}
