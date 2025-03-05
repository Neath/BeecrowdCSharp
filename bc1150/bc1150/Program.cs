using System;
using System.Collections.Generic;

namespace bc1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            
            while (Z <= X)
            {
                Z = int.Parse(Console.ReadLine());
            }

            List<int> values = new List<int>();
            
            int sum = 0;
            for (int i = 0; sum < Z; i++)
            {
                values.Add(X + i);
                sum += values[i];
            }

            Console.WriteLine(values.Count);
        }
    }
}
