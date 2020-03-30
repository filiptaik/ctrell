using System;

namespace While1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Kirjuta elevant");
                input = Console.ReadLine();
            } while (input != "elevant");
            Console.WriteLine(input);
        }


    }
}

