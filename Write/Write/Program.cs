using System;
using System.IO;

namespace Write
{
    class Program
    {

        public static void Main(string[] args)
        {
            FileStream f = new FileStream("arvud.txt",
                FileMode.Create, FileAccess.Write);
            StreamWriter valja = new StreamWriter(f);
            for(int i=1; i < 21; i++)
            {
                valja.WriteLine("Arv on {0} ja selle ruut {1}", i, i*i);
            }
            
            valja.Close();

        }
    }
}
