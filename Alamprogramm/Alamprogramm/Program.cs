using System;

namespace Alamprogramm
{
    class Program
    {
        static int keskmine(int a, int b)
        {
            return a * b / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kaks numbrit");
            int arv1 = int.Parse(Console.ReadLine());
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Esimene arv on {0}, teine on {1} ja nende keskmine on {2}", arv1, arv2, keskmine(arv1, arv2));
        }
    }
}
