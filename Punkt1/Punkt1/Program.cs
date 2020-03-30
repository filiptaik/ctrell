using System;

namespace Punkt1
{
    class Punkt1
    {
        static int loendur = 0;
        private int nr;
        private int pikkus;
        private int laius;
        private string toon;

        public Punkt1(int pikkus, int laius, string toon)
        {
            this.pikkus = pikkus;
            this.laius = laius;
            this.toon = toon;
            nr=++loendur;
        }
        public int GetPikkus()
        {
            return pikkus;
        }
        public int GetLaius()
        {
            return laius;
        }
        public string GetToon()
        {
            return toon;
        }
        public int GetPindala()
        {
            return pikkus * laius;
        }
    }
    class Program
    {
        
        public static void Main(string[] args)
        {
            string[] v2rvid = {"Sinine", "Roheline", "Kollane", "Roosa", "Punane" };
            Punkt1[] lapp1 = new Punkt1[10];
            Random r = new Random();
            for (int i = 0;  i < lapp1.Length; i++){
                lapp1[i] = new Punkt1(r.Next(30), r.Next(25), v2rvid[r.Next(v2rvid.Length)]);
            }
            Console.WriteLine();
        }
    }
}
