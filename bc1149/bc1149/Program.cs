using System;

namespace bc1149
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] val = Console.ReadLine().Split(' ');
            int A = int.Parse(val[0]);
            int sum = 0;

            int i = 1;
            int N = int.Parse(val[i]);
            while (N < 1)
            {
                i++;
                N = int.Parse(val[i]);
            }

            for (i = 0; i < N; i++)
            {
                sum += A + i;
            }
            Console.WriteLine(sum);
        }
    }
}
