using System;

namespace Arvutus
{
    class Program
    {
        static void Main(string[] args)
        {
            double pirnihind = 1.5;

            Console.WriteLine("mitu pirni ostad?");
            double kogus = double.Parse(Console.ReadLine());
            double summa = kogus * pirnihind;

            Console.WriteLine("Kilekotti soovid? [jah/ei]");
            string input = Console.ReadLine();
            if(input == "jah")
            {
                summa = summa + 0.5;
            } else
            {
                Console.WriteLine("Tubli!");
            }
            
            Console.WriteLine("maksma läks: {0} eurot",
                summa
                );
        }
    }
}
