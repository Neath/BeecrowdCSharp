using System;

namespace bc1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int QtdPar = 0;
            int QtdImpar = 0;
            int QtdPos = 0;
            int QtdNeg = 0;

            for (int i = 0; i < 5; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                    QtdPar++;
                else
                    QtdImpar++;

                if (num > 0)
                    QtdPos++;
                else if (num < 0)
                    QtdNeg++;

            }
            Console.WriteLine(QtdPar + " valor(es) par(es)");
            Console.WriteLine(QtdImpar + " valor(es) impar(es)");
            Console.WriteLine(QtdPos + " valor(es) positivo(s)");
            Console.WriteLine(QtdNeg + " valor(es) negativo(s)");
        }
    }
}
