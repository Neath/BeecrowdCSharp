using System;

namespace bc1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int QtdPar = 0;
            for (int i = 0; i < 5; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)              
                    QtdPar++;
                
            }
            Console.WriteLine(QtdPar + " valores pares");
        }
    }
}
