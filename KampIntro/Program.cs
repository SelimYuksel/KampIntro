using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği (her satırda kod tipini belirtmek zorundayız string vs vs)
            //Do not repeat yourself
            //kategoriEtiketi değer tutucu, alias
            //double ondalıklı sayıları gösterirken kullanılır
            //int tam sayıları gösterirken kullanılır fakat basamak sayısında sıkıntı çıkarabilir örneğin 320000000000000 
            //WriteLine komutu pythondaki print gibi çalışır
            //bool şart komutunu belirleyen komut yani bir şart tanımlanır ve false, true durumuna bakılır altına else-if yazılır
            
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            
            
            
            

            
           

           Console.WriteLine(kategoriEtiketi);

        
        }
    }
}
