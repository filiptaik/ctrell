using System;

namespace Classes
{
    class Lapp
    {
        private int pikkus;
        private int laius;
        private string toon;
        
        public Lapp(int upikkus, int ulaius, string utoon)
        {
            pikkus = upikkus;
            laius = ulaius;
            toon = utoon;
        }
        public int GetPikkus()
        {
            return pikkus;
        }
        public int GetLaius() {
            return laius;
        }
        public string GetToon()
        {
            return toon;
        }
        public int Pindala()
        {
            return pikkus * laius;
        }

        public void Poolitaja()
        {
            int newPikkus;
            if(pikkus > laius)
            { 
                pikkus = pikkus / 2;
            } else
            {
                laius = laius / 2;
            }
        }
    }

    class Lapptest
    {
        static void Main(string[] args)
        {
            Lapp lapp1 = new Lapp(100, 25, "sinine");
            int pindala = lapp1.Pindala();
            Console.WriteLine("pindala on: " + pindala);
        }
    }
}
