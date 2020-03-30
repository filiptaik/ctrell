using System;

namespace Struct
{
    struct Lapp
    {
        public int pikkus;
        public int laius;
        public string toon;
    }
    class Program
    {
        public static void Main(string[] args){
            Lapp[] lapp2 = new Lapp[10];
            public string[] v2rvid = { "roheline", "sinine", "punane", "kollane", "roosa" };
        Random r = new Random();

            for (int i = 0; i<lapp2.Length; i++) 
            {
                lapp2[i].pikkus = r.Next(30);
                lapp2[i].laius = r.Next(30);
                lapp2.toon = v2rvid[r.Next(v2rvid.Length)];
    
    
        } // Ei saa aru miks mingid vead tulema hakkasid
    }

}   


            
        



