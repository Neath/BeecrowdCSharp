using System;

namespace bc1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int cont = 0;

            while (cont < 6)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                    cont++;
                }

                num++;
            }
        }
    }
}
