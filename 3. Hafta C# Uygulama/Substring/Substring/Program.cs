using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.Write("Metin giriniz : ");
            string metin = Console.ReadLine();
            Console.Write("Aranan ifadeyi giriniz : ");
            string aranan = Console.ReadLine();

            int metinuzunluk = metin.Length;
            int arananuzunluk = aranan.Length;

            for (int i = 0; i <= (metinuzunluk - arananuzunluk ); i++)
            {
                if (metin.Substring(i, arananuzunluk) == aranan)
                {
                    sayac++;
                }
            }
            Console.WriteLine(sayac);
            Console.ReadLine();
        }
    }
}
