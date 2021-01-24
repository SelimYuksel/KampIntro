using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Kurs kurs1 = new Kurs();   //Kurs kendi veri tipimiz oldu class Kurs yazdığımız için //kurs1'in tipi Kurs, class değişkeni yapmak için bunu yapmamız gerekiyor
            kurs1.KursAdi = "C#";  //neden "" kullandık? Çünkü KursAdi aşağıda string olarak geçiyor.
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68; // "" kullanmadık çünkü Kurs class'ında IzlenmeOrani değişkeni int olarak tanımlanmış (integer)


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            //buradaki " : " sabit bir string
            //" " arasına mesela kodlama.io'daki dersin tamamlanma yüzdesindeki % işareti yazılabilir çünkü değişken değil, oradaki sayı değişken, eğitmen adı değişken

            Kurs[] kurslar = new Kurs[] {kurs1 , kurs2 , kurs3};     //kurs yerine string yazmıştık array konusunda fakat class'ı Kurs olarak tanımladık
            
            foreach (var kurs in kurslar) 
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }



            //Console.WriteLine("Selam Canım Naber!");
           
        }
    }

    //class Kurs yazdığımızda Kurs kelimesi kendi veri tipimiz gibi oluyor ve komut gibi kullanabiliyoruz

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

        //prop propertyden geliyor yani özellik 3 tane özellik tanımladık burada
    }
}
