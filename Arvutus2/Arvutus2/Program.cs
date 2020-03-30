using System;

namespace Arvutus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta temperatuur: ");
            double temp = double.Parse(Console.ReadLine());
            if(temp < 18)
            {
                Console.WriteLine("Pane kütet juurde!");
            }
            else
            {
                Console.WriteLine("Väga tore temperatuur");
            }
        }
    }
}
