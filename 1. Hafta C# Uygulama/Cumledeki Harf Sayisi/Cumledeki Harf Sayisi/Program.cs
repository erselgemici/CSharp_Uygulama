using System;

namespace Cumledeki_Harf_Sayisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Cümle Giriniz : ");
            string cumle = Console.ReadLine();

            string[] kelimeler = cumle.Split(' ');

            Console.Write("Cümledeki Harf Sayısı : ");
            Console.Write(cumle.Length - (kelimeler.Length - 1));
        }
    }
}
