using System;

namespace Subclass
{
    class Inimene
    {
        protected int vanus;
        protected int pikkus;
        public Inimene(int uvanus, int upikkus)
        {
            vanus = uvanus;
            pikkus = upikkus;
        }
        public void YtleVanus()
        {
            Console.WriteLine("Minu vanus on " + vanus + " aastat");
        }
        public int GetPikkus()
        {
            return pikkus;
        }
    }
    class Modell : Inimene
    {
        protected int ymberm66t;
        protected int pikkus;
        public Modell(int vanus, int uymberm66t, int upikkus) : base(vanus, upikkus)
        {
            ymberm66t = uymberm66t;
        }
        public void Esitle()
        {
            YtleVanus();
            Console.WriteLine("Mu ymberm66duks on " + ymberm66t + " sentimeetrit");
            Console.WriteLine("Mu pikkus on " + pikkus + " sentimeetrit");
        }

    }
    class InimTest
    {

        public static void Main(string[] arg)
        {
            Modell m = new Modell(20, 90, 186);
            Inimene test = new Modell(11, 45, 199);
            test.YtleVanus();
            //m.Esitle();
            Inimene[] massiiv = new Inimene[5];
            massiiv[0] = new Modell(16, 50, 122);
            massiiv[1] = new Inimene(19, 170);
            massiiv[2] = new Modell(23, 32, 394);
            massiiv[3] = new Inimene(22, 199);
            massiiv[4] = new Modell(15, 76, 165);

            for(int i=0;i<massiiv.Length; i ++)
            {
                Console.WriteLine("Mu pikkus on " + massiiv[i].GetPikkus() + " cm");
            }
                static bool kasMahub(int pikkus)
                {
                    bool jaaei;
                    if (pikkus > 165)
                    {
                        jaaei = true;
                    }
                    else
                    {
                        jaaei = false;
                    }
                    return jaaei;
                }
             

        }
    }
}


