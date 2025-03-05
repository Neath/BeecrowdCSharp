using System;

namespace bc1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string BigGroup = Console.ReadLine();
            string MidGroup = Console.ReadLine();
            string FeedingType = Console.ReadLine();
            string answear;

            if (BigGroup == "vertebrado")
            {
                if (MidGroup == "ave")
                {
                    if (FeedingType == "carnivoro")
                        answear = "aguia";
                    else
                        answear = "pomba";
                }
                else 
                {
                    if (FeedingType == "onivoro")
                        answear = "homem";
                    else
                        answear = "vaca";
                }
            }
            else
            {
                if (MidGroup == "inseto")
                {
                    if (FeedingType == "hematofago")
                        answear = "pulga";
                    else
                        answear = "lagarta";
                }
                else
                {
                    if (FeedingType == "hematofago")
                        answear = "sanguessuga";
                    else
                        answear = "minhoca";
                }
            }

            Console.WriteLine(answear);

        }
    }
}
