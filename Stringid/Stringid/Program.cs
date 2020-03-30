using System;

namespace Stringid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi: ");
            string name = Console.ReadLine();
            int t2ht = name.IndexOf("a");
            int t2ht2 = name.IndexOf("A");
            if(t2ht != -1 || t2ht2 !=-1)
            {
                Console.WriteLine("Tere " + name + ", su nimi toesti hakkab a tähega");
            } else
            {
                Console.WriteLine(name + " ei hakka A tähega, see hakkab hoopis " + name.Substring(0, 1) + " tähega");
            }
        }
    }
}
