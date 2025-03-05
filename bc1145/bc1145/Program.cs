using System;

namespace bc1145
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aux = Console.ReadLine().Split(' ');
            int X = int.Parse(aux[0]);
            int Y = int.Parse(aux[1]);
            int cont = 1;

            while (cont < Y)
            {
                for (int i = 1; i <= X; i++)
                {
                    Console.Write(cont);
                    cont++;

                    if (i == X)
                        break;

                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
