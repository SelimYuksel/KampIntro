using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //i'yi 1den başlatıp 10a kadar yazdırıyor, i++ birer birer arttırarak yazdır demek
            //<= deseydik 10u da yazdıracaktı
            //i=i+2 deseydik ikişer ikişer arttıracaktı (i+=2 şeklinde de yazabiliriz)
            //array = dizi [] olarak gösterilir string [] birden fazla string tutmaya yarar yani string kurs1 string kurs2 yazmaya gerek yok 

            //string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            //string kurs2 = "Programlamaya başlangıç için temel kurs";
            //string kurs3 = "Java";

            //böylesi zor

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", "Programlamaya başlangıç için temel kurs", "Java", "Python", "C#",  };

            //böylesi kolay

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

                //kurslar'ın i. elemanını yazdırıyor yani 0. eleman Yazılım geliştirici yetiştirme kampı, 1. eleman programlamaya başlangıç için temel kurs
                //kurslar.Length = kurslar listesinde kaç eleman varsa o kadar yazdırır 
            }
            
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                //in kurslar kursları tek tek dolaş demek 
                //kurs alias yani abc de desek xyz de desek çalışır
                //foreach dizileri tek tek dolaşmaya yarıyor
                //for ile yazmak yerine foreach ile de yazabiliriz

                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
