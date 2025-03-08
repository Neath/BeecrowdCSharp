using System;
using System.Collections.Generic;

namespace bc1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aux = Console.ReadLine().Split(' ');
            int[] values = new int[3];
            List<int> Sorted = new List<int>();

            for (int i = 0; i < 3; i++)
                values[i] = int.Parse(aux[i]);

            for (int i = 0; i < 3; i++)
                Sorted.Add(values[i]);

            Sorted.Sort();

            foreach (int num in Sorted)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            foreach (int num in values)
            {
                Console.WriteLine(num);
            }          
        }
    }
}
