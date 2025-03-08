using System;

namespace bc1131
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aux = Console.ReadLine().Split(' ');
            int GInter = int.Parse(aux[0]);
            int GGremio = int.Parse(aux[1]);
            int VInter = 0;
            int VGremio = 0;
            int Empate = 0;
            int Grenais = 1;

            if (GInter > GGremio)
            {
                VInter++;
            }
            else if (GInter < GGremio)
            {
                VGremio++;
            }
            else
            {
                Empate++;
            }

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            int NovoGrenal = int.Parse(Console.ReadLine());

            while (NovoGrenal == 1)
            {
                aux = Console.ReadLine().Split(' ');
                GInter = int.Parse(aux[0]);
                GGremio = int.Parse(aux[1]);

                if (GInter > GGremio)
                {
                    VInter++;
                }
                else if (GInter < GGremio)
                {
                    VGremio++;
                }
                else
                {
                    Empate++;
                }

                Grenais++;
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                NovoGrenal = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(Grenais + " grenais");
            Console.WriteLine("Inter:" + VInter);
            Console.WriteLine("Gremio:" + VGremio);
            Console.WriteLine("Empates:" + Empate);

            if (VInter > VGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (VInter < VGremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
