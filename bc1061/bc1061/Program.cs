using System;

namespace bc1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int W1, X1, Y1, Z1, W2, X2, Y2, Z2;
            string[] aux;

            aux = Console.ReadLine().Split(' ');
            W1 = int.Parse(aux[1]);

            aux = Console.ReadLine().Split(' ');
            X1 = int.Parse(aux[0]);
            Y1 = int.Parse(aux[2]);
            Z1 = int.Parse(aux[4]);

            aux = Console.ReadLine().Split(' ');
            W2 = int.Parse(aux[1]);

            aux = Console.ReadLine().Split(' ');
            X2 = int.Parse(aux[0]);
            Y2 = int.Parse(aux[2]);
            Z2 = int.Parse(aux[4]);

            DateTime FirstDate = new DateTime(2025, 4, W1, X1, Y1, Z1);
            DateTime LastDate = new DateTime(2025, 4, W2, X2, Y2, Z2);

            TimeSpan Duration = new TimeSpan();
            Duration = LastDate.Subtract(FirstDate);


            Console.WriteLine(Duration.Days.ToString() + " dia(s)");
            Console.WriteLine(Duration.Hours.ToString() + " hora(s)");
            Console.WriteLine(Duration.Minutes.ToString() + " minuto(s)");
            Console.WriteLine(Duration.Seconds.ToString() + " segundo(s)");
        }
    }
}
