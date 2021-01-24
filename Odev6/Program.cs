using System;

namespace Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Gomlekler = new string[] { "Sarı Gömlek", "Mavi Gömlek", "Mor Gömlek", "Pembe Gömlek" };
            
            for (int a = 0; a<Gomlekler.Length; a++)
            {
                Console.WriteLine(Gomlekler[a]);
            }

            Console.WriteLine("For için");



            foreach (string Gomlek in Gomlekler)
            {
                Console.WriteLine(Gomlek);
            }

            Console.WriteLine("Foreach için");

            
            int b = 0;
            while (b<Gomlekler.Length)
            {
                Console.WriteLine(Gomlekler[b]);
                b++;
            }

            Console.WriteLine("While için");


        }
    }
}
