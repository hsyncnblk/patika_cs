using System;

namespace patika_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("isminizi girin");
            string name = Console.ReadLine();
            Console.WriteLine("soyisim giriniz");
            string surname = Console.ReadLine();
            Console.WriteLine("merhaba " + name + " " + surname);
        }
    }
}
