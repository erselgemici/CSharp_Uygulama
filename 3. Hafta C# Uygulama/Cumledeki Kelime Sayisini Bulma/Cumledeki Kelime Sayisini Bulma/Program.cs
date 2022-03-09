using System;

namespace Cumledeki_Kelime_Sayisini_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin;
            Console.Write("Metni giriniz : ");
            metin = Console.ReadLine();

            string[] kelimeler = metin.Split(' ');
            Console.WriteLine("Kelime Sayısı : " + kelimeler.Length);

            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
            Console.ReadLine();
        }
    }
}
