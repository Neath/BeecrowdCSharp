using System;

namespace bc1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                int X = int.Parse(aux[0]);
                int Y = int.Parse(aux[1]);
                int cont = 0;
                int sum = 0;

                if (X % 2 == 0)
                    X++;

                while(cont < Y)
                {
                    sum += X;
                    X += 2;
                    cont++;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
