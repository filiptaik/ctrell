using System;

namespace Massiivid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta viis numbrit");
            int[] mas = new int[5];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.In.ReadLine());
            }
            Console.WriteLine();
            for (int i = mas.Length - 1; i >= 0 ; i--)
            {
                Console.WriteLine(mas[i]);
            }
            
        }
    }
}
