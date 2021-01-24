using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> icecekler = new MyDictionary<string, string>();

            icecekler.Add("1", "Coca-Cola");
            icecekler.Add("2", "Pepsi");

            icecekler.GetAll();
        }
    }
}
