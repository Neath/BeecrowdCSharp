using System;

namespace bc1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] X = new int[N];
            int[] Y = new int[N];
            int[] somaImp = new int[N];

            for (int i = 0; i < N; i++)
            {
                string[] aux = Console.ReadLine().Split(' ');
                X[i] = int.Parse(aux[0]);
                Y[i] = int.Parse(aux[1]);
                int min = Math.Min(X[i], Y[i]);
                int max = Math.Max(X[i], Y[i]);

                if ((max - min) > 1)
                {
                    for (int cont = min + 1; cont < max; cont++)
                    {
                        if (cont % 2 != 0)
                            somaImp[i] += cont;
                    }
                }
                else
                {
                    somaImp[i] = 0;
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(somaImp[i]);
            }
            
        }
    }
}
